namespace Trade
{
    partial class Indexer_StaticMethod
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
            this.labCommodityCost = new System.Windows.Forms.Label();
            this.lbCommodityCost = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIndexator = new System.Windows.Forms.TextBox();
            this.btIndex = new System.Windows.Forms.Button();
            this.btCommoditiesCost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labCommodityCost
            // 
            this.labCommodityCost.AutoSize = true;
            this.labCommodityCost.Location = new System.Drawing.Point(93, 9);
            this.labCommodityCost.Name = "labCommodityCost";
            this.labCommodityCost.Size = new System.Drawing.Size(92, 13);
            this.labCommodityCost.TabIndex = 55;
            this.labCommodityCost.Text = "Commodities(cost)";
            // 
            // lbCommodityCost
            // 
            this.lbCommodityCost.FormattingEnabled = true;
            this.lbCommodityCost.Location = new System.Drawing.Point(12, 25);
            this.lbCommodityCost.Name = "lbCommodityCost";
            this.lbCommodityCost.Size = new System.Drawing.Size(260, 69);
            this.lbCommodityCost.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Number of  goods";
            // 
            // tbIndexator
            // 
            this.tbIndexator.Location = new System.Drawing.Point(78, 187);
            this.tbIndexator.Name = "tbIndexator";
            this.tbIndexator.Size = new System.Drawing.Size(120, 20);
            this.tbIndexator.TabIndex = 59;
            // 
            // btIndex
            // 
            this.btIndex.Location = new System.Drawing.Point(78, 213);
            this.btIndex.Name = "btIndex";
            this.btIndex.Size = new System.Drawing.Size(120, 23);
            this.btIndex.TabIndex = 60;
            this.btIndex.Text = "Data for index";
            this.btIndex.UseVisualStyleBackColor = true;
            this.btIndex.Click += new System.EventHandler(this.btIndex_Click);
            // 
            // btCommoditiesCost
            // 
            this.btCommoditiesCost.Location = new System.Drawing.Point(96, 100);
            this.btCommoditiesCost.Name = "btCommoditiesCost";
            this.btCommoditiesCost.Size = new System.Drawing.Size(89, 52);
            this.btCommoditiesCost.TabIndex = 61;
            this.btCommoditiesCost.Text = "Show commodities  for cost";
            this.btCommoditiesCost.UseVisualStyleBackColor = true;
            this.btCommoditiesCost.Click += new System.EventHandler(this.btCommoditiesCost_Click);
            // 
            // Indexer_StaticMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btCommoditiesCost);
            this.Controls.Add(this.btIndex);
            this.Controls.Add(this.tbIndexator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCommodityCost);
            this.Controls.Add(this.labCommodityCost);
            this.Name = "Indexer_StaticMethod";
            this.Text = "Indexer_StaticMethod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCommodityCost;
        private System.Windows.Forms.ListBox lbCommodityCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIndexator;
        private System.Windows.Forms.Button btIndex;
        private System.Windows.Forms.Button btCommoditiesCost;
    }
}