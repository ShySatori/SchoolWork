namespace TCP.Server
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TurnOffButton = new System.Windows.Forms.Button();
            this.TurnOnButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.NowConnectedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TurnOffButton
            // 
            this.TurnOffButton.Location = new System.Drawing.Point(335, 340);
            this.TurnOffButton.Name = "TurnOffButton";
            this.TurnOffButton.Size = new System.Drawing.Size(112, 23);
            this.TurnOffButton.TabIndex = 0;
            this.TurnOffButton.Text = "Выключить серв";
            this.TurnOffButton.UseVisualStyleBackColor = true;
            this.TurnOffButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TurnOnButton
            // 
            this.TurnOnButton.Location = new System.Drawing.Point(212, 340);
            this.TurnOnButton.Name = "TurnOnButton";
            this.TurnOnButton.Size = new System.Drawing.Size(117, 23);
            this.TurnOnButton.TabIndex = 1;
            this.TurnOnButton.Text = "Включить сервер";
            this.TurnOnButton.UseVisualStyleBackColor = true;
            this.TurnOnButton.Click += new System.EventHandler(this.TurnOnButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // NowConnectedLabel
            // 
            this.NowConnectedLabel.AutoSize = true;
            this.NowConnectedLabel.Location = new System.Drawing.Point(209, 324);
            this.NowConnectedLabel.Name = "NowConnectedLabel";
            this.NowConnectedLabel.Size = new System.Drawing.Size(73, 13);
            this.NowConnectedLabel.TabIndex = 2;
            this.NowConnectedLabel.Text = "Подключено:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 375);
            this.Controls.Add(this.NowConnectedLabel);
            this.Controls.Add(this.TurnOnButton);
            this.Controls.Add(this.TurnOffButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TurnOffButton;
        private System.Windows.Forms.Button TurnOnButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label NowConnectedLabel;
    }
}

