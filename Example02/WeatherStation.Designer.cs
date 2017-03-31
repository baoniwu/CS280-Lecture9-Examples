namespace Example02
{
    partial class WeatherStation
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
            this.tempLabel = new System.Windows.Forms.Label();
            this.pressureLabel = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.tempTextBox = new System.Windows.Forms.TextBox();
            this.pressureTextBox = new System.Windows.Forms.TextBox();
            this.humidyTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.dataTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tempLabel.Location = new System.Drawing.Point(54, 39);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(51, 19);
            this.tempLabel.TabIndex = 0;
            this.tempLabel.Text = "Temp";
            // 
            // pressureLabel
            // 
            this.pressureLabel.AutoSize = true;
            this.pressureLabel.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pressureLabel.Location = new System.Drawing.Point(183, 39);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(70, 19);
            this.pressureLabel.TabIndex = 0;
            this.pressureLabel.Text = "Pressure";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label.Location = new System.Drawing.Point(313, 39);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(78, 19);
            this.Label.TabIndex = 0;
            this.Label.Text = "Humidity";
            // 
            // tempTextBox
            // 
            this.tempTextBox.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tempTextBox.Location = new System.Drawing.Point(58, 89);
            this.tempTextBox.Name = "tempTextBox";
            this.tempTextBox.Size = new System.Drawing.Size(100, 30);
            this.tempTextBox.TabIndex = 1;
            // 
            // pressureTextBox
            // 
            this.pressureTextBox.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pressureTextBox.Location = new System.Drawing.Point(187, 89);
            this.pressureTextBox.Name = "pressureTextBox";
            this.pressureTextBox.Size = new System.Drawing.Size(100, 30);
            this.pressureTextBox.TabIndex = 1;
            // 
            // humidyTextBox
            // 
            this.humidyTextBox.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.humidyTextBox.Location = new System.Drawing.Point(317, 89);
            this.humidyTextBox.Name = "humidyTextBox";
            this.humidyTextBox.Size = new System.Drawing.Size(100, 30);
            this.humidyTextBox.TabIndex = 1;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.startButton.Location = new System.Drawing.Point(455, 86);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(109, 33);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.messageLabel.Location = new System.Drawing.Point(58, 155);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(506, 193);
            this.messageLabel.TabIndex = 3;
            this.messageLabel.Text = "message";
            // 
            // dataTimer
            // 
            this.dataTimer.Tick += new System.EventHandler(this.dataTimer_Tick);
            // 
            // WeatherStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 415);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.humidyTextBox);
            this.Controls.Add(this.pressureTextBox);
            this.Controls.Add(this.tempTextBox);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.pressureLabel);
            this.Controls.Add(this.tempLabel);
            this.Name = "WeatherStation";
            this.Text = "WeatherStation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label pressureLabel;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox tempTextBox;
        private System.Windows.Forms.TextBox pressureTextBox;
        private System.Windows.Forms.TextBox humidyTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label messageLabel;
        public System.Windows.Forms.Timer dataTimer;
    }
}