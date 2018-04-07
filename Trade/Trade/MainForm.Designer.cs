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
            this.btDeleteOrganization = new System.Windows.Forms.Button();
            this.tbNameOrganization = new System.Windows.Forms.TextBox();
            this.btAddOrganization = new System.Windows.Forms.Button();
            this.btEditOrganization = new System.Windows.Forms.Button();
            this.lbOrganization = new System.Windows.Forms.ListBox();
            this.lbAccounting = new System.Windows.Forms.ListBox();
            this.lbItemProduct = new System.Windows.Forms.ListBox();
            this.lbСommodity = new System.Windows.Forms.ListBox();
            this.tbNameItemProduct = new System.Windows.Forms.TextBox();
            this.tbNameСommodity = new System.Windows.Forms.TextBox();
            this.btDeleteAccounting = new System.Windows.Forms.Button();
            this.btEditAccounting = new System.Windows.Forms.Button();
            this.btAddAccounting = new System.Windows.Forms.Button();
            this.btAddItemProduct = new System.Windows.Forms.Button();
            this.btEditItemProduct = new System.Windows.Forms.Button();
            this.btDeleteItemProduct = new System.Windows.Forms.Button();
            this.btAddСommodity = new System.Windows.Forms.Button();
            this.btEditСommodity = new System.Windows.Forms.Button();
            this.btDeleteСommodity = new System.Windows.Forms.Button();
            this.labOrganization = new System.Windows.Forms.Label();
            this.labAccounting = new System.Windows.Forms.Label();
            this.labItemProduct = new System.Windows.Forms.Label();
            this.labСommodities = new System.Windows.Forms.Label();
            this.btTransitionDatabaze = new System.Windows.Forms.Button();
            this.tbDataCreationOrganization = new System.Windows.Forms.TextBox();
            this.tbBankAccountOrganization = new System.Windows.Forms.TextBox();
            this.tbHeadOrganization = new System.Windows.Forms.TextBox();
            this.tbBrandСommodity = new System.Windows.Forms.TextBox();
            this.tbNumberSold = new System.Windows.Forms.TextBox();
            this.tbNumberAcquired = new System.Windows.Forms.TextBox();
            this.tbCapitalOrganization = new System.Windows.Forms.TextBox();
            this.tbUnitsСommodity = new System.Windows.Forms.TextBox();
            this.tbCostСommodity = new System.Windows.Forms.TextBox();
            this.tbSerialNumberItemProduct = new System.Windows.Forms.TextBox();
            this.labNameOrganization = new System.Windows.Forms.Label();
            this.labDataCreation = new System.Windows.Forms.Label();
            this.labBankAccount = new System.Windows.Forms.Label();
            this.labHead = new System.Windows.Forms.Label();
            this.labNumberSold = new System.Windows.Forms.Label();
            this.labNumberAcquired = new System.Windows.Forms.Label();
            this.labLastUpdate = new System.Windows.Forms.Label();
            this.labNameCommodities = new System.Windows.Forms.Label();
            this.labCost = new System.Windows.Forms.Label();
            this.labUnits = new System.Windows.Forms.Label();
            this.labBrand = new System.Windows.Forms.Label();
            this.labSerialNumber = new System.Windows.Forms.Label();
            this.labNameItemProduct = new System.Windows.Forms.Label();
            this.btEnterRecursion = new System.Windows.Forms.Button();
            this.tbIndexator = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btIndex = new System.Windows.Forms.Button();
            this.lbCommodityCost = new System.Windows.Forms.ListBox();
            this.labCommodityCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btDeleteOrganization
            // 
            this.btDeleteOrganization.Location = new System.Drawing.Point(630, 110);
            this.btDeleteOrganization.Name = "btDeleteOrganization";
            this.btDeleteOrganization.Size = new System.Drawing.Size(109, 30);
            this.btDeleteOrganization.TabIndex = 0;
            this.btDeleteOrganization.Text = "Delete organization";
            this.btDeleteOrganization.UseVisualStyleBackColor = true;
            this.btDeleteOrganization.Click += new System.EventHandler(this.btDeleteOrganization_Click);
            // 
            // tbNameOrganization
            // 
            this.tbNameOrganization.Location = new System.Drawing.Point(498, 25);
            this.tbNameOrganization.Name = "tbNameOrganization";
            this.tbNameOrganization.Size = new System.Drawing.Size(109, 20);
            this.tbNameOrganization.TabIndex = 1;
            // 
            // btAddOrganization
            // 
            this.btAddOrganization.Location = new System.Drawing.Point(629, 38);
            this.btAddOrganization.Name = "btAddOrganization";
            this.btAddOrganization.Size = new System.Drawing.Size(109, 30);
            this.btAddOrganization.TabIndex = 2;
            this.btAddOrganization.Text = "Add organization";
            this.btAddOrganization.UseVisualStyleBackColor = true;
            this.btAddOrganization.Click += new System.EventHandler(this.btAddOrganization_Click);
            // 
            // btEditOrganization
            // 
            this.btEditOrganization.Location = new System.Drawing.Point(629, 74);
            this.btEditOrganization.Name = "btEditOrganization";
            this.btEditOrganization.Size = new System.Drawing.Size(109, 30);
            this.btEditOrganization.TabIndex = 3;
            this.btEditOrganization.Text = "Edit organization";
            this.btEditOrganization.UseVisualStyleBackColor = true;
            this.btEditOrganization.Click += new System.EventHandler(this.btEditOrganization_Click);
            // 
            // lbOrganization
            // 
            this.lbOrganization.FormattingEnabled = true;
            this.lbOrganization.Location = new System.Drawing.Point(12, 42);
            this.lbOrganization.Name = "lbOrganization";
            this.lbOrganization.Size = new System.Drawing.Size(466, 95);
            this.lbOrganization.TabIndex = 5;
            this.lbOrganization.SelectedIndexChanged += new System.EventHandler(this.lbOrganization_SelectedIndexChanged);
            // 
            // lbAccounting
            // 
            this.lbAccounting.FormattingEnabled = true;
            this.lbAccounting.Location = new System.Drawing.Point(12, 181);
            this.lbAccounting.Name = "lbAccounting";
            this.lbAccounting.Size = new System.Drawing.Size(466, 95);
            this.lbAccounting.TabIndex = 6;
            this.lbAccounting.SelectedIndexChanged += new System.EventHandler(this.lbAccounting_SelectedIndexChanged);
            // 
            // lbItemProduct
            // 
            this.lbItemProduct.FormattingEnabled = true;
            this.lbItemProduct.Location = new System.Drawing.Point(12, 464);
            this.lbItemProduct.Name = "lbItemProduct";
            this.lbItemProduct.Size = new System.Drawing.Size(334, 95);
            this.lbItemProduct.TabIndex = 7;
            this.lbItemProduct.SelectedIndexChanged += new System.EventHandler(this.lbItemProduct_SelectedIndexChanged);
            // 
            // lbСommodity
            // 
            this.lbСommodity.FormattingEnabled = true;
            this.lbСommodity.Location = new System.Drawing.Point(12, 320);
            this.lbСommodity.Name = "lbСommodity";
            this.lbСommodity.Size = new System.Drawing.Size(466, 95);
            this.lbСommodity.TabIndex = 8;
            this.lbСommodity.SelectedIndexChanged += new System.EventHandler(this.lbСommodity_SelectedIndexChanged);
            // 
            // tbNameItemProduct
            // 
            this.tbNameItemProduct.Location = new System.Drawing.Point(355, 480);
            this.tbNameItemProduct.Name = "tbNameItemProduct";
            this.tbNameItemProduct.Size = new System.Drawing.Size(109, 20);
            this.tbNameItemProduct.TabIndex = 10;
            // 
            // tbNameСommodity
            // 
            this.tbNameСommodity.Location = new System.Drawing.Point(501, 304);
            this.tbNameСommodity.Name = "tbNameСommodity";
            this.tbNameСommodity.Size = new System.Drawing.Size(109, 20);
            this.tbNameСommodity.TabIndex = 11;
            // 
            // btDeleteAccounting
            // 
            this.btDeleteAccounting.Location = new System.Drawing.Point(630, 250);
            this.btDeleteAccounting.Name = "btDeleteAccounting";
            this.btDeleteAccounting.Size = new System.Drawing.Size(109, 30);
            this.btDeleteAccounting.TabIndex = 12;
            this.btDeleteAccounting.Text = "Delete accounting";
            this.btDeleteAccounting.UseVisualStyleBackColor = true;
            this.btDeleteAccounting.Click += new System.EventHandler(this.btDeleteAccounting_Click);
            // 
            // btEditAccounting
            // 
            this.btEditAccounting.Location = new System.Drawing.Point(630, 216);
            this.btEditAccounting.Name = "btEditAccounting";
            this.btEditAccounting.Size = new System.Drawing.Size(109, 30);
            this.btEditAccounting.TabIndex = 13;
            this.btEditAccounting.Text = "Edit accounting";
            this.btEditAccounting.UseVisualStyleBackColor = true;
            this.btEditAccounting.Click += new System.EventHandler(this.btEditAccounting_Click);
            // 
            // btAddAccounting
            // 
            this.btAddAccounting.Location = new System.Drawing.Point(630, 181);
            this.btAddAccounting.Name = "btAddAccounting";
            this.btAddAccounting.Size = new System.Drawing.Size(109, 27);
            this.btAddAccounting.TabIndex = 14;
            this.btAddAccounting.Text = "Add accounting";
            this.btAddAccounting.UseVisualStyleBackColor = true;
            this.btAddAccounting.Click += new System.EventHandler(this.btAddAccounting_Click);
            // 
            // btAddItemProduct
            // 
            this.btAddItemProduct.Location = new System.Drawing.Point(488, 460);
            this.btAddItemProduct.Name = "btAddItemProduct";
            this.btAddItemProduct.Size = new System.Drawing.Size(109, 30);
            this.btAddItemProduct.TabIndex = 15;
            this.btAddItemProduct.Text = "Add item product";
            this.btAddItemProduct.UseVisualStyleBackColor = true;
            this.btAddItemProduct.Click += new System.EventHandler(this.btAddItemProduct_Click);
            // 
            // btEditItemProduct
            // 
            this.btEditItemProduct.Location = new System.Drawing.Point(488, 496);
            this.btEditItemProduct.Name = "btEditItemProduct";
            this.btEditItemProduct.Size = new System.Drawing.Size(109, 30);
            this.btEditItemProduct.TabIndex = 16;
            this.btEditItemProduct.Text = "Edit item product";
            this.btEditItemProduct.UseVisualStyleBackColor = true;
            this.btEditItemProduct.Click += new System.EventHandler(this.btEditItemProduct_Click);
            // 
            // btDeleteItemProduct
            // 
            this.btDeleteItemProduct.Location = new System.Drawing.Point(488, 529);
            this.btDeleteItemProduct.Name = "btDeleteItemProduct";
            this.btDeleteItemProduct.Size = new System.Drawing.Size(109, 30);
            this.btDeleteItemProduct.TabIndex = 17;
            this.btDeleteItemProduct.Text = "Delete item product";
            this.btDeleteItemProduct.UseVisualStyleBackColor = true;
            this.btDeleteItemProduct.Click += new System.EventHandler(this.btDeleteItemProduct_Click);
            // 
            // btAddСommodity
            // 
            this.btAddСommodity.Location = new System.Drawing.Point(630, 320);
            this.btAddСommodity.Name = "btAddСommodity";
            this.btAddСommodity.Size = new System.Drawing.Size(109, 27);
            this.btAddСommodity.TabIndex = 18;
            this.btAddСommodity.Text = "Add commodity";
            this.btAddСommodity.UseVisualStyleBackColor = true;
            this.btAddСommodity.Click += new System.EventHandler(this.btAddСommodity_Click);
            // 
            // btEditСommodity
            // 
            this.btEditСommodity.Location = new System.Drawing.Point(629, 353);
            this.btEditСommodity.Name = "btEditСommodity";
            this.btEditСommodity.Size = new System.Drawing.Size(109, 30);
            this.btEditСommodity.TabIndex = 19;
            this.btEditСommodity.Text = "Edit commodity";
            this.btEditСommodity.UseVisualStyleBackColor = true;
            this.btEditСommodity.Click += new System.EventHandler(this.btEditСommodity_Click);
            // 
            // btDeleteСommodity
            // 
            this.btDeleteСommodity.Location = new System.Drawing.Point(629, 389);
            this.btDeleteСommodity.Name = "btDeleteСommodity";
            this.btDeleteСommodity.Size = new System.Drawing.Size(109, 30);
            this.btDeleteСommodity.TabIndex = 20;
            this.btDeleteСommodity.Text = "Delete commodity";
            this.btDeleteСommodity.UseVisualStyleBackColor = true;
            this.btDeleteСommodity.Click += new System.EventHandler(this.btDeleteСommodity_Click);
            // 
            // labOrganization
            // 
            this.labOrganization.AutoSize = true;
            this.labOrganization.Location = new System.Drawing.Point(212, 21);
            this.labOrganization.Name = "labOrganization";
            this.labOrganization.Size = new System.Drawing.Size(71, 13);
            this.labOrganization.TabIndex = 21;
            this.labOrganization.Text = "Organizations";
            // 
            // labAccounting
            // 
            this.labAccounting.AutoSize = true;
            this.labAccounting.Location = new System.Drawing.Point(217, 161);
            this.labAccounting.Name = "labAccounting";
            this.labAccounting.Size = new System.Drawing.Size(66, 13);
            this.labAccounting.TabIndex = 22;
            this.labAccounting.Text = "Accountings";
            // 
            // labItemProduct
            // 
            this.labItemProduct.AutoSize = true;
            this.labItemProduct.Location = new System.Drawing.Point(146, 448);
            this.labItemProduct.Name = "labItemProduct";
            this.labItemProduct.Size = new System.Drawing.Size(71, 13);
            this.labItemProduct.TabIndex = 23;
            this.labItemProduct.Text = "Item products";
            // 
            // labСommodities
            // 
            this.labСommodities.AutoSize = true;
            this.labСommodities.Location = new System.Drawing.Point(217, 304);
            this.labСommodities.Name = "labСommodities";
            this.labСommodities.Size = new System.Drawing.Size(66, 13);
            this.labСommodities.TabIndex = 24;
            this.labСommodities.Text = "Сommodities";
            // 
            // btTransitionDatabaze
            // 
            this.btTransitionDatabaze.Location = new System.Drawing.Point(708, 523);
            this.btTransitionDatabaze.Name = "btTransitionDatabaze";
            this.btTransitionDatabaze.Size = new System.Drawing.Size(84, 35);
            this.btTransitionDatabaze.TabIndex = 25;
            this.btTransitionDatabaze.Text = "Tranzition to database";
            this.btTransitionDatabaze.UseVisualStyleBackColor = true;
            this.btTransitionDatabaze.Click += new System.EventHandler(this.btTransitionDatabaze_Click);
            // 
            // tbDataCreationOrganization
            // 
            this.tbDataCreationOrganization.Location = new System.Drawing.Point(498, 63);
            this.tbDataCreationOrganization.Name = "tbDataCreationOrganization";
            this.tbDataCreationOrganization.Size = new System.Drawing.Size(109, 20);
            this.tbDataCreationOrganization.TabIndex = 26;
            // 
            // tbBankAccountOrganization
            // 
            this.tbBankAccountOrganization.Location = new System.Drawing.Point(498, 100);
            this.tbBankAccountOrganization.Name = "tbBankAccountOrganization";
            this.tbBankAccountOrganization.Size = new System.Drawing.Size(109, 20);
            this.tbBankAccountOrganization.TabIndex = 27;
            // 
            // tbHeadOrganization
            // 
            this.tbHeadOrganization.Location = new System.Drawing.Point(498, 138);
            this.tbHeadOrganization.Name = "tbHeadOrganization";
            this.tbHeadOrganization.Size = new System.Drawing.Size(109, 20);
            this.tbHeadOrganization.TabIndex = 28;
            // 
            // tbBrandСommodity
            // 
            this.tbBrandСommodity.Location = new System.Drawing.Point(502, 422);
            this.tbBrandСommodity.Name = "tbBrandСommodity";
            this.tbBrandСommodity.Size = new System.Drawing.Size(109, 20);
            this.tbBrandСommodity.TabIndex = 29;
            // 
            // tbNumberSold
            // 
            this.tbNumberSold.Location = new System.Drawing.Point(498, 181);
            this.tbNumberSold.Name = "tbNumberSold";
            this.tbNumberSold.Size = new System.Drawing.Size(109, 20);
            this.tbNumberSold.TabIndex = 30;
            // 
            // tbNumberAcquired
            // 
            this.tbNumberAcquired.Location = new System.Drawing.Point(498, 222);
            this.tbNumberAcquired.Name = "tbNumberAcquired";
            this.tbNumberAcquired.Size = new System.Drawing.Size(109, 20);
            this.tbNumberAcquired.TabIndex = 31;
            // 
            // tbCapitalOrganization
            // 
            this.tbCapitalOrganization.Location = new System.Drawing.Point(498, 260);
            this.tbCapitalOrganization.Name = "tbCapitalOrganization";
            this.tbCapitalOrganization.Size = new System.Drawing.Size(109, 20);
            this.tbCapitalOrganization.TabIndex = 32;
            // 
            // tbUnitsСommodity
            // 
            this.tbUnitsСommodity.Location = new System.Drawing.Point(502, 383);
            this.tbUnitsСommodity.Name = "tbUnitsСommodity";
            this.tbUnitsСommodity.Size = new System.Drawing.Size(109, 20);
            this.tbUnitsСommodity.TabIndex = 33;
            // 
            // tbCostСommodity
            // 
            this.tbCostСommodity.Location = new System.Drawing.Point(501, 344);
            this.tbCostСommodity.Name = "tbCostСommodity";
            this.tbCostСommodity.Size = new System.Drawing.Size(109, 20);
            this.tbCostСommodity.TabIndex = 34;
            // 
            // tbSerialNumberItemProduct
            // 
            this.tbSerialNumberItemProduct.Location = new System.Drawing.Point(354, 539);
            this.tbSerialNumberItemProduct.Name = "tbSerialNumberItemProduct";
            this.tbSerialNumberItemProduct.Size = new System.Drawing.Size(109, 20);
            this.tbSerialNumberItemProduct.TabIndex = 35;
            // 
            // labNameOrganization
            // 
            this.labNameOrganization.AutoSize = true;
            this.labNameOrganization.Location = new System.Drawing.Point(500, 9);
            this.labNameOrganization.Name = "labNameOrganization";
            this.labNameOrganization.Size = new System.Drawing.Size(107, 13);
            this.labNameOrganization.TabIndex = 36;
            this.labNameOrganization.Text = "Name of organization";
            // 
            // labDataCreation
            // 
            this.labDataCreation.AutoSize = true;
            this.labDataCreation.Location = new System.Drawing.Point(485, 47);
            this.labDataCreation.Name = "labDataCreation";
            this.labDataCreation.Size = new System.Drawing.Size(140, 13);
            this.labDataCreation.TabIndex = 37;
            this.labDataCreation.Text = "Year of creation(since 1980)";
            // 
            // labBankAccount
            // 
            this.labBankAccount.AutoSize = true;
            this.labBankAccount.Location = new System.Drawing.Point(510, 84);
            this.labBankAccount.Name = "labBankAccount";
            this.labBankAccount.Size = new System.Drawing.Size(86, 13);
            this.labBankAccount.TabIndex = 38;
            this.labBankAccount.Text = "Bank of account";
            // 
            // labHead
            // 
            this.labHead.AutoSize = true;
            this.labHead.Location = new System.Drawing.Point(500, 122);
            this.labHead.Name = "labHead";
            this.labHead.Size = new System.Drawing.Size(100, 13);
            this.labHead.TabIndex = 39;
            this.labHead.Text = "Organization\'s head";
            // 
            // labNumberSold
            // 
            this.labNumberSold.AutoSize = true;
            this.labNumberSold.Location = new System.Drawing.Point(509, 165);
            this.labNumberSold.Name = "labNumberSold";
            this.labNumberSold.Size = new System.Drawing.Size(78, 13);
            this.labNumberSold.TabIndex = 40;
            this.labNumberSold.Text = "Number of sold";
            // 
            // labNumberAcquired
            // 
            this.labNumberAcquired.AutoSize = true;
            this.labNumberAcquired.Location = new System.Drawing.Point(500, 206);
            this.labNumberAcquired.Name = "labNumberAcquired";
            this.labNumberAcquired.Size = new System.Drawing.Size(100, 13);
            this.labNumberAcquired.TabIndex = 41;
            this.labNumberAcquired.Text = "Number of acquired";
            // 
            // labLastUpdate
            // 
            this.labLastUpdate.AutoSize = true;
            this.labLastUpdate.Location = new System.Drawing.Point(500, 245);
            this.labLastUpdate.Name = "labLastUpdate";
            this.labLastUpdate.Size = new System.Drawing.Size(111, 13);
            this.labLastUpdate.TabIndex = 42;
            this.labLastUpdate.Text = "Capital of organization";
            // 
            // labNameCommodities
            // 
            this.labNameCommodities.AutoSize = true;
            this.labNameCommodities.Location = new System.Drawing.Point(499, 288);
            this.labNameCommodities.Name = "labNameCommodities";
            this.labNameCommodities.Size = new System.Drawing.Size(108, 13);
            this.labNameCommodities.TabIndex = 43;
            this.labNameCommodities.Text = "Name of commodities";
            // 
            // labCost
            // 
            this.labCost.AutoSize = true;
            this.labCost.Location = new System.Drawing.Point(510, 327);
            this.labCost.Name = "labCost";
            this.labCost.Size = new System.Drawing.Size(87, 13);
            this.labCost.TabIndex = 44;
            this.labCost.Text = "Cost for kg(l or g)";
            // 
            // labUnits
            // 
            this.labUnits.AutoSize = true;
            this.labUnits.Location = new System.Drawing.Point(518, 367);
            this.labUnits.Name = "labUnits";
            this.labUnits.Size = new System.Drawing.Size(69, 13);
            this.labUnits.TabIndex = 45;
            this.labUnits.Text = "Units(kg, l, g)";
            // 
            // labBrand
            // 
            this.labBrand.AutoSize = true;
            this.labBrand.Location = new System.Drawing.Point(536, 406);
            this.labBrand.Name = "labBrand";
            this.labBrand.Size = new System.Drawing.Size(35, 13);
            this.labBrand.TabIndex = 46;
            this.labBrand.Text = "Brand";
            // 
            // labSerialNumber
            // 
            this.labSerialNumber.AutoSize = true;
            this.labSerialNumber.Location = new System.Drawing.Point(371, 523);
            this.labSerialNumber.Name = "labSerialNumber";
            this.labSerialNumber.Size = new System.Drawing.Size(71, 13);
            this.labSerialNumber.TabIndex = 47;
            this.labSerialNumber.Text = "Serial number";
            // 
            // labNameItemProduct
            // 
            this.labNameItemProduct.AutoSize = true;
            this.labNameItemProduct.Location = new System.Drawing.Point(352, 464);
            this.labNameItemProduct.Name = "labNameItemProduct";
            this.labNameItemProduct.Size = new System.Drawing.Size(111, 13);
            this.labNameItemProduct.TabIndex = 48;
            this.labNameItemProduct.Text = "Name of item_product";
            // 
            // btEnterRecursion
            // 
            this.btEnterRecursion.Location = new System.Drawing.Point(618, 523);
            this.btEnterRecursion.Name = "btEnterRecursion";
            this.btEnterRecursion.Size = new System.Drawing.Size(84, 35);
            this.btEnterRecursion.TabIndex = 49;
            this.btEnterRecursion.Text = "Move to the recursion";
            this.btEnterRecursion.UseVisualStyleBackColor = true;
            this.btEnterRecursion.Click += new System.EventHandler(this.btEnterRecursion_Click);
            // 
            // tbIndexator
            // 
            this.tbIndexator.Location = new System.Drawing.Point(647, 455);
            this.tbIndexator.Name = "tbIndexator";
            this.tbIndexator.Size = new System.Drawing.Size(101, 20);
            this.tbIndexator.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(648, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Number of  goods";
            // 
            // btIndex
            // 
            this.btIndex.Location = new System.Drawing.Point(647, 481);
            this.btIndex.Name = "btIndex";
            this.btIndex.Size = new System.Drawing.Size(101, 23);
            this.btIndex.TabIndex = 52;
            this.btIndex.Text = "data for index";
            this.btIndex.UseVisualStyleBackColor = true;
            this.btIndex.Click += new System.EventHandler(this.btIndex_Click);
            // 
            // lbCommodityCost
            // 
            this.lbCommodityCost.FormattingEnabled = true;
            this.lbCommodityCost.Location = new System.Drawing.Point(750, 324);
            this.lbCommodityCost.Name = "lbCommodityCost";
            this.lbCommodityCost.Size = new System.Drawing.Size(120, 95);
            this.lbCommodityCost.TabIndex = 53;
            // 
            // labCommodityCost
            // 
            this.labCommodityCost.AutoSize = true;
            this.labCommodityCost.Location = new System.Drawing.Point(758, 304);
            this.labCommodityCost.Name = "labCommodityCost";
            this.labCommodityCost.Size = new System.Drawing.Size(92, 13);
            this.labCommodityCost.TabIndex = 54;
            this.labCommodityCost.Text = "Commodities(cost)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 571);
            this.Controls.Add(this.labCommodityCost);
            this.Controls.Add(this.lbCommodityCost);
            this.Controls.Add(this.btIndex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIndexator);
            this.Controls.Add(this.btEnterRecursion);
            this.Controls.Add(this.labNameItemProduct);
            this.Controls.Add(this.labSerialNumber);
            this.Controls.Add(this.labBrand);
            this.Controls.Add(this.labUnits);
            this.Controls.Add(this.labCost);
            this.Controls.Add(this.labNameCommodities);
            this.Controls.Add(this.labLastUpdate);
            this.Controls.Add(this.labNumberAcquired);
            this.Controls.Add(this.labNumberSold);
            this.Controls.Add(this.labHead);
            this.Controls.Add(this.labBankAccount);
            this.Controls.Add(this.labDataCreation);
            this.Controls.Add(this.labNameOrganization);
            this.Controls.Add(this.tbSerialNumberItemProduct);
            this.Controls.Add(this.tbCostСommodity);
            this.Controls.Add(this.tbUnitsСommodity);
            this.Controls.Add(this.tbCapitalOrganization);
            this.Controls.Add(this.tbNumberAcquired);
            this.Controls.Add(this.tbNumberSold);
            this.Controls.Add(this.tbBrandСommodity);
            this.Controls.Add(this.tbHeadOrganization);
            this.Controls.Add(this.tbBankAccountOrganization);
            this.Controls.Add(this.tbDataCreationOrganization);
            this.Controls.Add(this.btTransitionDatabaze);
            this.Controls.Add(this.labСommodities);
            this.Controls.Add(this.labItemProduct);
            this.Controls.Add(this.labAccounting);
            this.Controls.Add(this.labOrganization);
            this.Controls.Add(this.btDeleteСommodity);
            this.Controls.Add(this.btEditСommodity);
            this.Controls.Add(this.btAddСommodity);
            this.Controls.Add(this.btDeleteItemProduct);
            this.Controls.Add(this.btEditItemProduct);
            this.Controls.Add(this.btAddItemProduct);
            this.Controls.Add(this.btAddAccounting);
            this.Controls.Add(this.btEditAccounting);
            this.Controls.Add(this.btDeleteAccounting);
            this.Controls.Add(this.tbNameСommodity);
            this.Controls.Add(this.tbNameItemProduct);
            this.Controls.Add(this.lbСommodity);
            this.Controls.Add(this.lbItemProduct);
            this.Controls.Add(this.lbAccounting);
            this.Controls.Add(this.lbOrganization);
            this.Controls.Add(this.btEditOrganization);
            this.Controls.Add(this.btAddOrganization);
            this.Controls.Add(this.tbNameOrganization);
            this.Controls.Add(this.btDeleteOrganization);
            this.Name = "MainForm";
            this.Text = "Enter Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDeleteOrganization;
        private System.Windows.Forms.TextBox tbNameOrganization;
        private System.Windows.Forms.Button btAddOrganization;
        private System.Windows.Forms.Button btEditOrganization;
        private System.Windows.Forms.ListBox lbOrganization;
        private System.Windows.Forms.ListBox lbAccounting;
        private System.Windows.Forms.ListBox lbItemProduct;
        private System.Windows.Forms.TextBox tbNameItemProduct;
        private System.Windows.Forms.TextBox tbNameСommodity;
        private System.Windows.Forms.Button btDeleteAccounting;
        private System.Windows.Forms.Button btEditAccounting;
        private System.Windows.Forms.Button btAddAccounting;
        private System.Windows.Forms.Button btAddItemProduct;
        private System.Windows.Forms.Button btEditItemProduct;
        private System.Windows.Forms.Button btDeleteItemProduct;
        private System.Windows.Forms.Button btAddСommodity;
        private System.Windows.Forms.Button btEditСommodity;
        private System.Windows.Forms.Button btDeleteСommodity;
        private System.Windows.Forms.Label labOrganization;
        private System.Windows.Forms.Label labAccounting;
        private System.Windows.Forms.Label labItemProduct;
        private System.Windows.Forms.Label labСommodities;
        private System.Windows.Forms.Button btTransitionDatabaze;
        private System.Windows.Forms.TextBox tbDataCreationOrganization;
        private System.Windows.Forms.TextBox tbBankAccountOrganization;
        private System.Windows.Forms.TextBox tbHeadOrganization;
        private System.Windows.Forms.TextBox tbBrandСommodity;
        private System.Windows.Forms.TextBox tbNumberSold;
        private System.Windows.Forms.TextBox tbNumberAcquired;
        private System.Windows.Forms.TextBox tbCapitalOrganization;
        private System.Windows.Forms.TextBox tbUnitsСommodity;
        private System.Windows.Forms.TextBox tbCostСommodity;
        private System.Windows.Forms.TextBox tbSerialNumberItemProduct;
        private System.Windows.Forms.Label labNameOrganization;
        private System.Windows.Forms.Label labDataCreation;
        private System.Windows.Forms.Label labBankAccount;
        private System.Windows.Forms.Label labHead;
        private System.Windows.Forms.Label labNumberSold;
        private System.Windows.Forms.Label labNumberAcquired;
        private System.Windows.Forms.Label labLastUpdate;
        private System.Windows.Forms.Label labNameCommodities;
        private System.Windows.Forms.Label labCost;
        private System.Windows.Forms.Label labUnits;
        private System.Windows.Forms.Label labBrand;
        private System.Windows.Forms.Label labSerialNumber;
        private System.Windows.Forms.Label labNameItemProduct;
        private System.Windows.Forms.ListBox lbСommodity;
        private System.Windows.Forms.Button btEnterRecursion;
        private System.Windows.Forms.TextBox tbIndexator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btIndex;
        private System.Windows.Forms.ListBox lbCommodityCost;
        private System.Windows.Forms.Label labCommodityCost;
    }
}

