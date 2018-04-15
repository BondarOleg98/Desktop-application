namespace Trade
{
    partial class ConfigSetting
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
            this.btShowSettings = new System.Windows.Forms.Button();
            this.tbSetting = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btShowSettings
            // 
            this.btShowSettings.Location = new System.Drawing.Point(84, 173);
            this.btShowSettings.Name = "btShowSettings";
            this.btShowSettings.Size = new System.Drawing.Size(106, 28);
            this.btShowSettings.TabIndex = 1;
            this.btShowSettings.Text = "Show settings";
            this.btShowSettings.UseVisualStyleBackColor = true;
            this.btShowSettings.Click += new System.EventHandler(this.btShowSettings_Click);
            // 
            // tbSetting
            // 
            this.tbSetting.Location = new System.Drawing.Point(84, 47);
            this.tbSetting.Name = "tbSetting";
            this.tbSetting.Size = new System.Drawing.Size(100, 20);
            this.tbSetting.TabIndex = 2;
            // 
            // ConfigSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tbSetting);
            this.Controls.Add(this.btShowSettings);
            this.Name = "ConfigSetting";
            this.Text = "ConfigSetting";
            this.Load += new System.EventHandler(this.ConfigSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btShowSettings;
        private System.Windows.Forms.TextBox tbSetting;
    }
}