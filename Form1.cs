using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.IO.Ports;


namespace TextToSpeech
{
    public partial class Form1 : Form
    {

        SpeechSynthesizer tts = new SpeechSynthesizer();
        string text_to_speech = "Hope We Can Help. Have A Good Trip.";
        string[] messages = new string[] { "Hope We Can Help.", "Have A Good Trip" };

        int moving = 1;
        int counter = 100;

        int distance = 320;
        string status = "Far";
        Color status_colour = Color.DeepSkyBlue;

        public Form1()
        {
            InitializeComponent();


            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            comboBox_listPort.DropDownStyle = ComboBoxStyle.DropDownList;

            textBox_distance.Text = distance.ToString();

            UpdateDataToShow();

            serialPort_arduino = new SerialPort();

            try
            {
                string[] list_port = SerialPort.GetPortNames();
                foreach (string item in list_port)
                {
                    comboBox_listPort.Items.Add(item);
                }

                try
                {
                    comboBox_listPort.SelectedIndex = 0;
                }
                catch (Exception)
                {
                    comboBox_listPort.Items.Add("No Port Detected");
                    comboBox_listPort.SelectedIndex = 0;
                }
            }
            catch (Exception)
            {
                comboBox_listPort.Items.Add("Cannot Get Port Data");
                comboBox_listPort.SelectedIndex = 0;
            }


            
        }
        

        public void UpdateDataToShow()
        {
            label_distance.Text = distance.ToString();
            label_status.Text = status;
            label_statusColour.BackColor = status_colour;

            label_messageToSpeak.Text = messages[0];
            label_messageToSpeak2.Text = messages[1];
        }

        public void SpeakBasedOnDistance(int d)
        {
            
            if (distance > 220)
            {
                status = "Far";
                status_colour = Color.DeepSkyBlue;

                messages[0] = "Object is detected " + distance + " centimeter from us.";
                messages[1] = "Please keep that in mind.";
                text_to_speech = messages[0] + " " + messages[1];
            }
            else if (distance > 140)
            {
                status = "Moderate";
                status_colour = Color.Chartreuse;

                messages[0] = "Object is detected " + distance + " centimeter from us.";
                messages[1] = "Please watch your step.";
                text_to_speech = messages[0] + " " + messages[1];
            }
            else if (distance > 60)
            {
                status = "Close";
                status_colour = Color.Yellow;

                messages[0] = "Object is near, it is " + distance + " centimeter from us.";
                messages[1] = "Please be carefull.";
                text_to_speech = messages[0] + " " + messages[1];
            }
            else if (distance > 0)
            {
                status = "Danger";
                status_colour = Color.Red;

                messages[0] = "Object is " + distance + " centimeter from us.";
                messages[1] = "Please stop moving right now.";
                text_to_speech = messages[0] + " " + messages[1];

                BackgroundBeep.Beep();
            }

            if (distance <= 0)
            {
                timer_refresh.Enabled = false;
                distance = 0;
                counter = 100;

                messages[0] = "To prevent collision we have stop the movement.";
                messages[1] = "Please be carefull next time.";
                text_to_speech = messages[0] + " " + messages[1];

                try
                {
                    byte[] MyMessage = System.Text.Encoding.UTF8.GetBytes("500");
                    serialPort_arduino.Write(MyMessage, 0, MyMessage.Length);
                }
                catch (Exception)
                {
                    Console.WriteLine("Problem Connecting To Port");
                }
            }

            if (status != label_status.Text)
            {
                counter = 100;
            }

            UpdateDataToShow();

            if (counter > 20)
            {
                tts.SpeakAsyncCancelAll();

                counter = 0;

                try
                {
                    byte[] MyMessage = System.Text.Encoding.UTF8.GetBytes(distance.ToString());
                    serialPort_arduino.Write(MyMessage, 0, MyMessage.Length);
                }
                catch (Exception)
                {
                    Console.WriteLine("Problem Connecting To Port");
                }

                tts.SpeakAsync(text_to_speech);
            }
            
            
        }

        private void button_connectPort_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort_arduino.PortName = comboBox_listPort.Text;
                serialPort_arduino.BaudRate = 9600;
                serialPort_arduino.Open();

                MessageBox.Show("Successfully Connect To Port " + serialPort_arduino.PortName);

            }
            catch (Exception)
            {
                MessageBox.Show("Cannot Connect To The Port");
            }
        }

        private void timer_refresh_Tick(object sender, EventArgs e)
        {
            
            //counter++;

            SpeakBasedOnDistance(distance);

            distance -= 10;

        }

        private void serialPort_arduino_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data_recieved = serialPort_arduino.ReadLine();
            textBox_distance.Text = data_recieved;
        }

        private void button_insertDistance_Click(object sender, EventArgs e)
        {
           

            if (!int.TryParse(textBox_distance.Text, out _))
            {
                MessageBox.Show("Please Input Number Only");
            }
            else
            {
                int check_input = int.Parse(textBox_distance.Text);

                if (check_input >= 0)
                {
                    if (moving == 1)
                    {
                        timer_refresh.Enabled = false;
                        timer_refresh.Enabled = true;
                        label_status.Text = label_status.Text + " ";

                        distance = int.Parse(textBox_distance.Text);

                        
                    }
                    else if (moving == 0)
                    {
                        timer_refresh.Enabled = false;
                        label_status.Text = label_status.Text + " ";

                        distance = int.Parse(textBox_distance.Text);

                        SpeakBasedOnDistance(distance);
                    }



                }
                else
                {
                    MessageBox.Show("Distance Cannot Be Negative");
                }


            }

            
        }

        private void button_moving_Click(object sender, EventArgs e)
        {
            if (moving == 1)
            {
                moving = 0;
                button_moving.Text = "Stationary";
                timer_refresh.Enabled = false;
            }
            else if (moving == 0)
            {
                moving = 1;
                button_moving.Text = "Moving";
            }
        }
    }
}
