namespace TextToSpeech
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_distance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_insertDistance = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_distance = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_statusColour = new System.Windows.Forms.Label();
            this.button_connectPort = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_listPort = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label_messageToSpeak = new System.Windows.Forms.Label();
            this.timer_refresh = new System.Windows.Forms.Timer(this.components);
            this.serialPort_arduino = new System.IO.Ports.SerialPort(this.components);
            this.button_moving = new System.Windows.Forms.Button();
            this.label_messageToSpeak2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_distance
            // 
            this.textBox_distance.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_distance.Location = new System.Drawing.Point(185, 9);
            this.textBox_distance.Name = "textBox_distance";
            this.textBox_distance.Size = new System.Drawing.Size(215, 35);
            this.textBox_distance.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Distance : ";
            // 
            // button_insertDistance
            // 
            this.button_insertDistance.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_insertDistance.Location = new System.Drawing.Point(421, 9);
            this.button_insertDistance.Name = "button_insertDistance";
            this.button_insertDistance.Size = new System.Drawing.Size(130, 35);
            this.button_insertDistance.TabIndex = 2;
            this.button_insertDistance.Text = "Insert";
            this.button_insertDistance.UseVisualStyleBackColor = true;
            this.button_insertDistance.Click += new System.EventHandler(this.button_insertDistance_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Distance";
            // 
            // label_distance
            // 
            this.label_distance.AutoSize = true;
            this.label_distance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_distance.Location = new System.Drawing.Point(180, 95);
            this.label_distance.Name = "label_distance";
            this.label_distance.Size = new System.Drawing.Size(51, 25);
            this.label_distance.TabIndex = 4;
            this.label_distance.Text = "300";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.Location = new System.Drawing.Point(180, 134);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(62, 25);
            this.label_status.TabIndex = 6;
            this.label_status.Text = "Save";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(302, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "cm";
            // 
            // label_statusColour
            // 
            this.label_statusColour.AutoSize = true;
            this.label_statusColour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_statusColour.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_statusColour.Location = new System.Drawing.Point(310, 134);
            this.label_statusColour.Name = "label_statusColour";
            this.label_statusColour.Size = new System.Drawing.Size(26, 25);
            this.label_statusColour.TabIndex = 8;
            this.label_statusColour.Text = "  ";
            // 
            // button_connectPort
            // 
            this.button_connectPort.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_connectPort.Location = new System.Drawing.Point(421, 405);
            this.button_connectPort.Name = "button_connectPort";
            this.button_connectPort.Size = new System.Drawing.Size(130, 32);
            this.button_connectPort.TabIndex = 11;
            this.button_connectPort.Text = "Connect";
            this.button_connectPort.UseVisualStyleBackColor = true;
            this.button_connectPort.Click += new System.EventHandler(this.button_connectPort_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Available Port : ";
            // 
            // comboBox_listPort
            // 
            this.comboBox_listPort.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_listPort.FormattingEnabled = true;
            this.comboBox_listPort.Location = new System.Drawing.Point(185, 407);
            this.comboBox_listPort.Name = "comboBox_listPort";
            this.comboBox_listPort.Size = new System.Drawing.Size(215, 28);
            this.comboBox_listPort.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Message";
            // 
            // label_messageToSpeak
            // 
            this.label_messageToSpeak.AutoSize = true;
            this.label_messageToSpeak.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_messageToSpeak.Location = new System.Drawing.Point(14, 233);
            this.label_messageToSpeak.Name = "label_messageToSpeak";
            this.label_messageToSpeak.Size = new System.Drawing.Size(97, 25);
            this.label_messageToSpeak.TabIndex = 14;
            this.label_messageToSpeak.Text = "Message";
            // 
            // timer_refresh
            // 
            this.timer_refresh.Interval = 1000;
            this.timer_refresh.Tick += new System.EventHandler(this.timer_refresh_Tick);
            // 
            // serialPort_arduino
            // 
            this.serialPort_arduino.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_arduino_DataReceived);
            // 
            // button_moving
            // 
            this.button_moving.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_moving.Location = new System.Drawing.Point(421, 95);
            this.button_moving.Name = "button_moving";
            this.button_moving.Size = new System.Drawing.Size(130, 37);
            this.button_moving.TabIndex = 15;
            this.button_moving.Text = "Moving";
            this.button_moving.UseVisualStyleBackColor = true;
            this.button_moving.Click += new System.EventHandler(this.button_moving_Click);
            // 
            // label_messageToSpeak2
            // 
            this.label_messageToSpeak2.AutoSize = true;
            this.label_messageToSpeak2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_messageToSpeak2.Location = new System.Drawing.Point(14, 267);
            this.label_messageToSpeak2.Name = "label_messageToSpeak2";
            this.label_messageToSpeak2.Size = new System.Drawing.Size(97, 25);
            this.label_messageToSpeak2.TabIndex = 16;
            this.label_messageToSpeak2.Text = "Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.label_messageToSpeak2);
            this.Controls.Add(this.button_moving);
            this.Controls.Add(this.label_messageToSpeak);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_listPort);
            this.Controls.Add(this.button_connectPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_statusColour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_distance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_insertDistance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_distance);
            this.Name = "Form1";
            this.Text = "Ardiuno Text To Speech";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_distance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_insertDistance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_distance;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_statusColour;
        private System.Windows.Forms.Button button_connectPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_listPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_messageToSpeak;
        private System.Windows.Forms.Timer timer_refresh;
        private System.IO.Ports.SerialPort serialPort_arduino;
        private System.Windows.Forms.Button button_moving;
        private System.Windows.Forms.Label label_messageToSpeak2;
    }
}

