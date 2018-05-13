namespace Trade
{
    partial class MainForm
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
            this.btDelete = new System.Windows.Forms.Button();
            this.tbNameOrganization = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.lbOrganization = new System.Windows.Forms.ListBox();
            this.lbAccounting = new System.Windows.Forms.ListBox();
            this.lbItemProduct = new System.Windows.Forms.ListBox();
            this.lbGoods = new System.Windows.Forms.ListBox();
            this.tbNameItemProduct = new System.Windows.Forms.TextBox();
            this.labOrganization = new System.Windows.Forms.Label();
            this.labAccounting = new System.Windows.Forms.Label();
            this.labItemProduct = new System.Windows.Forms.Label();
            this.labСommodities = new System.Windows.Forms.Label();
            this.btTransitionDatabaze = new System.Windows.Forms.Button();
            this.tbDataCreationOrganization = new System.Windows.Forms.TextBox();
            this.tbBankAccountOrganization = new System.Windows.Forms.TextBox();
            this.tbHeadOrganization = new System.Windows.Forms.TextBox();
            this.tbNumberSold = new System.Windows.Forms.TextBox();
            this.tbNumberAcquired = new System.Windows.Forms.TextBox();
            this.tbCapitalOrganization = new System.Windows.Forms.TextBox();
            this.tbSerialNumberItemProduct = new System.Windows.Forms.TextBox();
            this.labNameOrganization = new System.Windows.Forms.Label();
            this.labDataCreation = new System.Windows.Forms.Label();
            this.labBankAccount = new System.Windows.Forms.Label();
            this.labHead = new System.Windows.Forms.Label();
            this.labNumberSold = new System.Windows.Forms.Label();
            this.labNumberAcquired = new System.Windows.Forms.Label();
            this.labLastUpdate = new System.Windows.Forms.Label();
            this.labSerialNumber = new System.Windows.Forms.Label();
            this.labNameItemProduct = new System.Windows.Forms.Label();
            this.rbAccountings = new System.Windows.Forms.RadioButton();
            this.rbOrganizations = new System.Windows.Forms.RadioButton();
            this.rbItemProduct = new System.Windows.Forms.RadioButton();
            this.btIndexerStaticMethod = new System.Windows.Forms.Button();
            this.btProducts = new System.Windows.Forms.Button();
            this.btIndustrialGoods = new System.Windows.Forms.Button();
            this.gbCommodities = new System.Windows.Forms.GroupBox();
            this.btRefresh = new System.Windows.Forms.Button();
            this.gbCommodities.SuspendLayout();
            this.SuspendLayout();
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(338, 445);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(109, 30);
            this.btDelete.TabIndex = 0;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // tbNameOrganization
            // 
            this.tbNameOrganization.Location = new System.Drawing.Point(625, 25);
            this.tbNameOrganization.Name = "tbNameOrganization";
            this.tbNameOrganization.Size = new System.Drawing.Size(109, 20);
            this.tbNameOrganization.TabIndex = 1;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(34, 445);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(109, 30);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Add ";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(179, 445);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(109, 30);
            this.btEdit.TabIndex = 3;
            this.btEdit.Text = "Edit ";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // lbOrganization
            // 
            this.lbOrganization.FormattingEnabled = true;
            this.lbOrganization.Location = new System.Drawing.Point(12, 28);
            this.lbOrganization.Name = "lbOrganization";
            this.lbOrganization.Size = new System.Drawing.Size(466, 56);
            this.lbOrganization.TabIndex = 5;
            this.lbOrganization.SelectedIndexChanged += new System.EventHandler(this.lbOrganization_SelectedIndexChanged);
            // 
            // lbAccounting
            // 
            this.lbAccounting.FormattingEnabled = true;
            this.lbAccounting.Location = new System.Drawing.Point(12, 106);
            this.lbAccounting.Name = "lbAccounting";
            this.lbAccounting.Size = new System.Drawing.Size(466, 69);
            this.lbAccounting.TabIndex = 6;
            this.lbAccounting.SelectedIndexChanged += new System.EventHandler(this.lbAccounting_SelectedIndexChanged);
            // 
            // lbItemProduct
            // 
            this.lbItemProduct.FormattingEnabled = true;
            this.lbItemProduct.Location = new System.Drawing.Point(71, 310);
            this.lbItemProduct.Name = "lbItemProduct";
            this.lbItemProduct.Size = new System.Drawing.Size(345, 82);
            this.lbItemProduct.TabIndex = 7;
            this.lbItemProduct.SelectedIndexChanged += new System.EventHandler(this.lbItemProduct_SelectedIndexChanged);
            // 
            // lbGoods
            // 
            this.lbGoods.FormattingEnabled = true;
            this.lbGoods.Location = new System.Drawing.Point(12, 203);
            this.lbGoods.Name = "lbGoods";
            this.lbGoods.Size = new System.Drawing.Size(466, 69);
            this.lbGoods.TabIndex = 8;
            // 
            // tbNameItemProduct
            // 
            this.tbNameItemProduct.Location = new System.Drawing.Point(498, 326);
            this.tbNameItemProduct.Name = "tbNameItemProduct";
            this.tbNameItemProduct.Size = new System.Drawing.Size(109, 20);
            this.tbNameItemProduct.TabIndex = 10;
            // 
            // labOrganization
            // 
            this.labOrganization.AutoSize = true;
            this.labOrganization.Location = new System.Drawing.Point(212, 9);
            this.labOrganization.Name = "labOrganization";
            this.labOrganization.Size = new System.Drawing.Size(71, 13);
            this.labOrganization.TabIndex = 21;
            this.labOrganization.Text = "Organizations";
            // 
            // labAccounting
            // 
            this.labAccounting.AutoSize = true;
            this.labAccounting.Location = new System.Drawing.Point(217, 90);
            this.labAccounting.Name = "labAccounting";
            this.labAccounting.Size = new System.Drawing.Size(66, 13);
            this.labAccounting.TabIndex = 22;
            this.labAccounting.Text = "Accountings";
            // 
            // labItemProduct
            // 
            this.labItemProduct.AutoSize = true;
            this.labItemProduct.Location = new System.Drawing.Point(217, 294);
            this.labItemProduct.Name = "labItemProduct";
            this.labItemProduct.Size = new System.Drawing.Size(71, 13);
            this.labItemProduct.TabIndex = 23;
            this.labItemProduct.Text = "Item products";
            // 
            // labСommodities
            // 
            this.labСommodities.AutoSize = true;
            this.labСommodities.Location = new System.Drawing.Point(217, 187);
            this.labСommodities.Name = "labСommodities";
            this.labСommodities.Size = new System.Drawing.Size(66, 13);
            this.labСommodities.TabIndex = 24;
            this.labСommodities.Text = "Сommodities";
            // 
            // btTransitionDatabaze
            // 
            this.btTransitionDatabaze.Location = new System.Drawing.Point(641, 435);
            this.btTransitionDatabaze.Name = "btTransitionDatabaze";
            this.btTransitionDatabaze.Size = new System.Drawing.Size(89, 38);
            this.btTransitionDatabaze.TabIndex = 25;
            this.btTransitionDatabaze.Text = "Tranzition to links";
            this.btTransitionDatabaze.UseVisualStyleBackColor = true;
            this.btTransitionDatabaze.Click += new System.EventHandler(this.btTransitionDatabaze_Click);
            // 
            // tbDataCreationOrganization
            // 
            this.tbDataCreationOrganization.Location = new System.Drawing.Point(498, 64);
            this.tbDataCreationOrganization.Name = "tbDataCreationOrganization";
            this.tbDataCreationOrganization.Size = new System.Drawing.Size(109, 20);
            this.tbDataCreationOrganization.TabIndex = 26;
            // 
            // tbBankAccountOrganization
            // 
            this.tbBankAccountOrganization.Location = new System.Drawing.Point(498, 25);
            this.tbBankAccountOrganization.Name = "tbBankAccountOrganization";
            this.tbBankAccountOrganization.Size = new System.Drawing.Size(109, 20);
            this.tbBankAccountOrganization.TabIndex = 27;
            // 
            // tbHeadOrganization
            // 
            this.tbHeadOrganization.Location = new System.Drawing.Point(625, 64);
            this.tbHeadOrganization.Name = "tbHeadOrganization";
            this.tbHeadOrganization.Size = new System.Drawing.Size(109, 20);
            this.tbHeadOrganization.TabIndex = 28;
            // 
            // tbNumberSold
            // 
            this.tbNumberSold.Location = new System.Drawing.Point(498, 119);
            this.tbNumberSold.Name = "tbNumberSold";
            this.tbNumberSold.Size = new System.Drawing.Size(109, 20);
            this.tbNumberSold.TabIndex = 30;
            // 
            // tbNumberAcquired
            // 
            this.tbNumberAcquired.Location = new System.Drawing.Point(625, 119);
            this.tbNumberAcquired.Name = "tbNumberAcquired";
            this.tbNumberAcquired.Size = new System.Drawing.Size(109, 20);
            this.tbNumberAcquired.TabIndex = 31;
            // 
            // tbCapitalOrganization
            // 
            this.tbCapitalOrganization.Location = new System.Drawing.Point(562, 155);
            this.tbCapitalOrganization.Name = "tbCapitalOrganization";
            this.tbCapitalOrganization.Size = new System.Drawing.Size(109, 20);
            this.tbCapitalOrganization.TabIndex = 32;
            // 
            // tbSerialNumberItemProduct
            // 
            this.tbSerialNumberItemProduct.Location = new System.Drawing.Point(625, 326);
            this.tbSerialNumberItemProduct.Name = "tbSerialNumberItemProduct";
            this.tbSerialNumberItemProduct.Size = new System.Drawing.Size(109, 20);
            this.tbSerialNumberItemProduct.TabIndex = 35;
            // 
            // labNameOrganization
            // 
            this.labNameOrganization.AutoSize = true;
            this.labNameOrganization.Location = new System.Drawing.Point(627, 9);
            this.labNameOrganization.Name = "labNameOrganization";
            this.labNameOrganization.Size = new System.Drawing.Size(107, 13);
            this.labNameOrganization.TabIndex = 36;
            this.labNameOrganization.Text = "Name of organization";
            // 
            // labDataCreation
            // 
            this.labDataCreation.AutoSize = true;
            this.labDataCreation.Location = new System.Drawing.Point(484, 48);
            this.labDataCreation.Name = "labDataCreation";
            this.labDataCreation.Size = new System.Drawing.Size(140, 13);
            this.labDataCreation.TabIndex = 37;
            this.labDataCreation.Text = "Year of creation(since 1980)";
            // 
            // labBankAccount
            // 
            this.labBankAccount.AutoSize = true;
            this.labBankAccount.Location = new System.Drawing.Point(509, 9);
            this.labBankAccount.Name = "labBankAccount";
            this.labBankAccount.Size = new System.Drawing.Size(86, 13);
            this.labBankAccount.TabIndex = 38;
            this.labBankAccount.Text = "Bank of account";
            // 
            // labHead
            // 
            this.labHead.AutoSize = true;
            this.labHead.Location = new System.Drawing.Point(630, 48);
            this.labHead.Name = "labHead";
            this.labHead.Size = new System.Drawing.Size(100, 13);
            this.labHead.TabIndex = 39;
            this.labHead.Text = "Organization\'s head";
            // 
            // labNumberSold
            // 
            this.labNumberSold.AutoSize = true;
            this.labNumberSold.Location = new System.Drawing.Point(509, 103);
            this.labNumberSold.Name = "labNumberSold";
            this.labNumberSold.Size = new System.Drawing.Size(78, 13);
            this.labNumberSold.TabIndex = 40;
            this.labNumberSold.Text = "Number of sold";
            // 
            // labNumberAcquired
            // 
            this.labNumberAcquired.AutoSize = true;
            this.labNumberAcquired.Location = new System.Drawing.Point(630, 103);
            this.labNumberAcquired.Name = "labNumberAcquired";
            this.labNumberAcquired.Size = new System.Drawing.Size(100, 13);
            this.labNumberAcquired.TabIndex = 41;
            this.labNumberAcquired.Text = "Number of acquired";
            // 
            // labLastUpdate
            // 
            this.labLastUpdate.AutoSize = true;
            this.labLastUpdate.Location = new System.Drawing.Point(560, 142);
            this.labLastUpdate.Name = "labLastUpdate";
            this.labLastUpdate.Size = new System.Drawing.Size(111, 13);
            this.labLastUpdate.TabIndex = 42;
            this.labLastUpdate.Text = "Capital of organization";
            // 
            // labSerialNumber
            // 
            this.labSerialNumber.AutoSize = true;
            this.labSerialNumber.Location = new System.Drawing.Point(641, 310);
            this.labSerialNumber.Name = "labSerialNumber";
            this.labSerialNumber.Size = new System.Drawing.Size(71, 13);
            this.labSerialNumber.TabIndex = 47;
            this.labSerialNumber.Text = "Serial number";
            // 
            // labNameItemProduct
            // 
            this.labNameItemProduct.AutoSize = true;
            this.labNameItemProduct.Location = new System.Drawing.Point(496, 310);
            this.labNameItemProduct.Name = "labNameItemProduct";
            this.labNameItemProduct.Size = new System.Drawing.Size(111, 13);
            this.labNameItemProduct.TabIndex = 48;
            this.labNameItemProduct.Text = "Name of item_product";
            // 
            // rbAccountings
            // 
            this.rbAccountings.AutoSize = true;
            this.rbAccountings.Location = new System.Drawing.Point(46, 422);
            this.rbAccountings.Name = "rbAccountings";
            this.rbAccountings.Size = new System.Drawing.Size(84, 17);
            this.rbAccountings.TabIndex = 79;
            this.rbAccountings.Text = "Accountings";
            this.rbAccountings.UseVisualStyleBackColor = true;
            this.rbAccountings.CheckedChanged += new System.EventHandler(this.rbAccountings_CheckedChanged);
            // 
            // rbOrganizations
            // 
            this.rbOrganizations.AutoSize = true;
            this.rbOrganizations.Checked = true;
            this.rbOrganizations.Location = new System.Drawing.Point(194, 422);
            this.rbOrganizations.Name = "rbOrganizations";
            this.rbOrganizations.Size = new System.Drawing.Size(89, 17);
            this.rbOrganizations.TabIndex = 80;
            this.rbOrganizations.TabStop = true;
            this.rbOrganizations.Text = "Organizations";
            this.rbOrganizations.UseVisualStyleBackColor = true;
            this.rbOrganizations.CheckedChanged += new System.EventHandler(this.rbOrganizations_CheckedChanged);
            // 
            // rbItemProduct
            // 
            this.rbItemProduct.AutoSize = true;
            this.rbItemProduct.Location = new System.Drawing.Point(353, 422);
            this.rbItemProduct.Name = "rbItemProduct";
            this.rbItemProduct.Size = new System.Drawing.Size(84, 17);
            this.rbItemProduct.TabIndex = 81;
            this.rbItemProduct.Text = "Item product";
            this.rbItemProduct.UseVisualStyleBackColor = true;
            this.rbItemProduct.CheckedChanged += new System.EventHandler(this.rbItemProduct_CheckedChanged);
            // 
            // btIndexerStaticMethod
            // 
            this.btIndexerStaticMethod.Location = new System.Drawing.Point(583, 389);
            this.btIndexerStaticMethod.Name = "btIndexerStaticMethod";
            this.btIndexerStaticMethod.Size = new System.Drawing.Size(88, 40);
            this.btIndexerStaticMethod.TabIndex = 111;
            this.btIndexerStaticMethod.Text = "Indexer and static method";
            this.btIndexerStaticMethod.UseVisualStyleBackColor = true;
            this.btIndexerStaticMethod.Click += new System.EventHandler(this.btIndexerStaticMethod_Click);
            // 
            // btProducts
            // 
            this.btProducts.Location = new System.Drawing.Point(14, 25);
            this.btProducts.Name = "btProducts";
            this.btProducts.Size = new System.Drawing.Size(75, 23);
            this.btProducts.TabIndex = 112;
            this.btProducts.Text = "Products";
            this.btProducts.UseVisualStyleBackColor = true;
            this.btProducts.Click += new System.EventHandler(this.btProducts_Click);
            // 
            // btIndustrialGoods
            // 
            this.btIndustrialGoods.Location = new System.Drawing.Point(116, 19);
            this.btIndustrialGoods.Name = "btIndustrialGoods";
            this.btIndustrialGoods.Size = new System.Drawing.Size(75, 35);
            this.btIndustrialGoods.TabIndex = 113;
            this.btIndustrialGoods.Text = "Industrial goods";
            this.btIndustrialGoods.UseVisualStyleBackColor = true;
            this.btIndustrialGoods.Click += new System.EventHandler(this.btIndustrialGoods_Click);
            // 
            // gbCommodities
            // 
            this.gbCommodities.Controls.Add(this.btIndustrialGoods);
            this.gbCommodities.Controls.Add(this.btProducts);
            this.gbCommodities.Location = new System.Drawing.Point(512, 203);
            this.gbCommodities.Name = "gbCommodities";
            this.gbCommodities.Size = new System.Drawing.Size(200, 62);
            this.gbCommodities.TabIndex = 114;
            this.gbCommodities.TabStop = false;
            this.gbCommodities.Text = "Commodities";
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(536, 435);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(89, 40);
            this.btRefresh.TabIndex = 116;
            this.btRefresh.Text = "Refresh form";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 483);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.gbCommodities);
            this.Controls.Add(this.btIndexerStaticMethod);
            this.Controls.Add(this.rbItemProduct);
            this.Controls.Add(this.rbOrganizations);
            this.Controls.Add(this.rbAccountings);
            this.Controls.Add(this.labNameItemProduct);
            this.Controls.Add(this.labSerialNumber);
            this.Controls.Add(this.labLastUpdate);
            this.Controls.Add(this.labNumberAcquired);
            this.Controls.Add(this.labNumberSold);
            this.Controls.Add(this.labHead);
            this.Controls.Add(this.labBankAccount);
            this.Controls.Add(this.labDataCreation);
            this.Controls.Add(this.labNameOrganization);
            this.Controls.Add(this.tbSerialNumberItemProduct);
            this.Controls.Add(this.tbCapitalOrganization);
            this.Controls.Add(this.tbNumberAcquired);
            this.Controls.Add(this.tbNumberSold);
            this.Controls.Add(this.tbHeadOrganization);
            this.Controls.Add(this.tbBankAccountOrganization);
            this.Controls.Add(this.tbDataCreationOrganization);
            this.Controls.Add(this.btTransitionDatabaze);
            this.Controls.Add(this.labСommodities);
            this.Controls.Add(this.labItemProduct);
            this.Controls.Add(this.labAccounting);
            this.Controls.Add(this.labOrganization);
            this.Controls.Add(this.tbNameItemProduct);
            this.Controls.Add(this.lbGoods);
            this.Controls.Add(this.lbItemProduct);
            this.Controls.Add(this.lbAccounting);
            this.Controls.Add(this.lbOrganization);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbNameOrganization);
            this.Controls.Add(this.btDelete);
            this.Name = "MainForm";
            this.Text = "Enter Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbCommodities.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.TextBox tbNameOrganization;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.ListBox lbOrganization;
        private System.Windows.Forms.ListBox lbAccounting;
        private System.Windows.Forms.ListBox lbItemProduct;
        private System.Windows.Forms.TextBox tbNameItemProduct;
        private System.Windows.Forms.Label labOrganization;
        private System.Windows.Forms.Label labAccounting;
        private System.Windows.Forms.Label labItemProduct;
        private System.Windows.Forms.Label labСommodities;
        private System.Windows.Forms.Button btTransitionDatabaze;
        private System.Windows.Forms.TextBox tbDataCreationOrganization;
        private System.Windows.Forms.TextBox tbBankAccountOrganization;
        private System.Windows.Forms.TextBox tbHeadOrganization;
        private System.Windows.Forms.TextBox tbNumberSold;
        private System.Windows.Forms.TextBox tbNumberAcquired;
        private System.Windows.Forms.TextBox tbCapitalOrganization;
        private System.Windows.Forms.TextBox tbSerialNumberItemProduct;
        private System.Windows.Forms.Label labNameOrganization;
        private System.Windows.Forms.Label labDataCreation;
        private System.Windows.Forms.Label labBankAccount;
        private System.Windows.Forms.Label labHead;
        private System.Windows.Forms.Label labNumberSold;
        private System.Windows.Forms.Label labNumberAcquired;
        private System.Windows.Forms.Label labLastUpdate;
        private System.Windows.Forms.Label labSerialNumber;
        private System.Windows.Forms.Label labNameItemProduct;
        private System.Windows.Forms.RadioButton rbAccountings;
        private System.Windows.Forms.RadioButton rbOrganizations;
        private System.Windows.Forms.RadioButton rbItemProduct;
        private System.Windows.Forms.Button btIndexerStaticMethod;
        private System.Windows.Forms.Button btProducts;
        private System.Windows.Forms.Button btIndustrialGoods;
        private System.Windows.Forms.GroupBox gbCommodities;
        public System.Windows.Forms.ListBox lbGoods;
        private System.Windows.Forms.Button btRefresh;
    }
}

