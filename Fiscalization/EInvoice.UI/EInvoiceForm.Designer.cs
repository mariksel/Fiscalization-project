
namespace EInvoice.UI
{
    partial class EInvoiceForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.CreateEInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.GetTaxPayers = new System.Windows.Forms.ToolStripMenuItem();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RegisterInvoiceButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BuyerNuisTextBox = new System.Windows.Forms.TextBox();
            this.BuyerNuisLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SellerTownValue = new System.Windows.Forms.Label();
            this.SellerNuisValue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SellerNameValue = new System.Windows.Forms.Label();
            this.SelectCertificateButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.CountryCodeBox = new System.Windows.Forms.ComboBox();
            this.SellerTown = new System.Windows.Forms.Label();
            this.SellerNuisLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InvoiceGroupBox = new System.Windows.Forms.GroupBox();
            this.OperatorCodeBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.OrderNumBox = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ExchangeRateBox = new System.Windows.Forms.NumericUpDown();
            this.BusinUnitCode = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PaymentMethodCombo = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.RegisterEInvoiceBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Menu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.InvoiceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderNumBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExchangeRateBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 614);
            this.panel1.TabIndex = 0;
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateEInvoice,
            this.GetTaxPayers});
            this.Menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(220, 44);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Create EInvoice";
            // 
            // CreateEInvoice
            // 
            this.CreateEInvoice.Name = "CreateEInvoice";
            this.CreateEInvoice.Size = new System.Drawing.Size(213, 19);
            this.CreateEInvoice.Text = "Create EInvoice";
            // 
            // GetTaxPayers
            // 
            this.GetTaxPayers.Name = "GetTaxPayers";
            this.GetTaxPayers.Size = new System.Drawing.Size(213, 19);
            this.GetTaxPayers.Text = "Get Tax Payers";
            // 
            // Output
            // 
            this.Output.Dock = System.Windows.Forms.DockStyle.Right;
            this.Output.Location = new System.Drawing.Point(715, 0);
            this.Output.Name = "Output";
            this.Output.ShowSelectionMargin = true;
            this.Output.Size = new System.Drawing.Size(623, 614);
            this.Output.TabIndex = 2;
            this.Output.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RegisterEInvoiceBtn);
            this.panel2.Controls.Add(this.RegisterInvoiceButton);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.InvoiceGroupBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(220, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1118, 614);
            this.panel2.TabIndex = 1;
            // 
            // RegisterInvoiceButton
            // 
            this.RegisterInvoiceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RegisterInvoiceButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.RegisterInvoiceButton.Location = new System.Drawing.Point(132, 557);
            this.RegisterInvoiceButton.Name = "RegisterInvoiceButton";
            this.RegisterInvoiceButton.Size = new System.Drawing.Size(149, 30);
            this.RegisterInvoiceButton.TabIndex = 14;
            this.RegisterInvoiceButton.Text = "Register Invoice";
            this.RegisterInvoiceButton.UseVisualStyleBackColor = false;
            this.RegisterInvoiceButton.Click += new System.EventHandler(this.RegisterInvoiceButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(516, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Currency Code";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BuyerNuisTextBox);
            this.groupBox2.Controls.Add(this.BuyerNuisLabel);
            this.groupBox2.Location = new System.Drawing.Point(243, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 210);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buyer";
            // 
            // BuyerNuisTextBox
            // 
            this.BuyerNuisTextBox.Location = new System.Drawing.Point(78, 19);
            this.BuyerNuisTextBox.Name = "BuyerNuisTextBox";
            this.BuyerNuisTextBox.Size = new System.Drawing.Size(100, 23);
            this.BuyerNuisTextBox.TabIndex = 0;
            this.BuyerNuisTextBox.Text = "L82118024B";
            // 
            // BuyerNuisLabel
            // 
            this.BuyerNuisLabel.AutoSize = true;
            this.BuyerNuisLabel.Location = new System.Drawing.Point(6, 22);
            this.BuyerNuisLabel.Name = "BuyerNuisLabel";
            this.BuyerNuisLabel.Size = new System.Drawing.Size(66, 15);
            this.BuyerNuisLabel.TabIndex = 1;
            this.BuyerNuisLabel.Text = "Buyer NUIS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Exchange Rate";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.SellerTownValue);
            this.groupBox1.Controls.Add(this.SellerNuisValue);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.SellerNameValue);
            this.groupBox1.Controls.Add(this.SelectCertificateButton);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.CountryCodeBox);
            this.groupBox1.Controls.Add(this.SellerTown);
            this.groupBox1.Controls.Add(this.SellerNuisLabel);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 210);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seller";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "Country Code:";
            // 
            // SellerTownValue
            // 
            this.SellerTownValue.AutoSize = true;
            this.SellerTownValue.Location = new System.Drawing.Point(104, 135);
            this.SellerTownValue.Name = "SellerTownValue";
            this.SellerTownValue.Size = new System.Drawing.Size(12, 15);
            this.SellerTownValue.TabIndex = 25;
            this.SellerTownValue.Text = "-";
            // 
            // SellerNuisValue
            // 
            this.SellerNuisValue.AutoSize = true;
            this.SellerNuisValue.Location = new System.Drawing.Point(107, 49);
            this.SellerNuisValue.Name = "SellerNuisValue";
            this.SellerNuisValue.Size = new System.Drawing.Size(12, 15);
            this.SellerNuisValue.TabIndex = 24;
            this.SellerNuisValue.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Seller Name:";
            // 
            // SellerNameValue
            // 
            this.SellerNameValue.AutoSize = true;
            this.SellerNameValue.Location = new System.Drawing.Point(104, 109);
            this.SellerNameValue.Name = "SellerNameValue";
            this.SellerNameValue.Size = new System.Drawing.Size(12, 15);
            this.SellerNameValue.TabIndex = 22;
            this.SellerNameValue.Text = "-";
            // 
            // SelectCertificateButton
            // 
            this.SelectCertificateButton.Location = new System.Drawing.Point(104, 15);
            this.SelectCertificateButton.Name = "SelectCertificateButton";
            this.SelectCertificateButton.Size = new System.Drawing.Size(121, 23);
            this.SelectCertificateButton.TabIndex = 21;
            this.SelectCertificateButton.Text = "Select Certificate";
            this.SelectCertificateButton.UseVisualStyleBackColor = true;
            this.SelectCertificateButton.Click += new System.EventHandler(this.SelectCertificateButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Certificate";
            // 
            // CountryCodeBox
            // 
            this.CountryCodeBox.FormattingEnabled = true;
            this.CountryCodeBox.Items.AddRange(new object[] {
            "ABW",
            "AFG",
            "AGO",
            "AIA",
            "ALA",
            "ALB",
            "AND",
            "ARE",
            "ARG",
            "ARM",
            "ASM",
            "ATA",
            "ATF",
            "ATG",
            "AUS",
            "AUT",
            "AZE",
            "BDI",
            "BEL",
            "BEN",
            "BES",
            "BFA",
            "BGD",
            "BGR",
            "BHR",
            "BHS",
            "BIH",
            "BLM",
            "BLR",
            "BLZ",
            "BMU",
            "BOL",
            "BRA",
            "BRB",
            "BRN",
            "BTN",
            "BVT",
            "BWA",
            "CAF",
            "CAN",
            "CCK",
            "CHE",
            "CHL",
            "CHN",
            "CIV",
            "CMR",
            "COD",
            "COG",
            "COK",
            "COL",
            "COM",
            "CPV",
            "CRI",
            "CUB",
            "CUW",
            "CXR",
            "CYM",
            "CYP",
            "CZE",
            "DEU",
            "DJI",
            "DMA",
            "DNK",
            "DOM",
            "DZA",
            "ECU",
            "EGY",
            "ERI",
            "ESH",
            "ESP",
            "EST",
            "ETH",
            "FIN",
            "FJI",
            "FLK",
            "FRA",
            "FRO",
            "FSM",
            "GAB",
            "GBR",
            "GEO",
            "GGY",
            "GHA",
            "GIB",
            "GIN",
            "GLP",
            "GMB",
            "GNB",
            "GNQ",
            "GRC",
            "GRD",
            "GRL",
            "GTM",
            "GUF",
            "GUM",
            "GUY",
            "HKG",
            "HMD",
            "HND",
            "HRV",
            "HTI",
            "HUN",
            "IDN",
            "IMN",
            "IND",
            "IOT",
            "IRL",
            "IRN",
            "IRQ",
            "ISL",
            "ISR",
            "ITA",
            "JAM",
            "JEY",
            "JOR",
            "JPN",
            "KAZ",
            "KEN",
            "KGZ",
            "KHM",
            "KIR",
            "KNA",
            "KOR",
            "KWT",
            "LAO",
            "LBN",
            "LBR",
            "LBY",
            "LCA",
            "LIE",
            "LKA",
            "LSO",
            "LTU",
            "LUX",
            "LVA",
            "MAC",
            "MAF",
            "MAR",
            "MCO",
            "MDA",
            "MDG",
            "MDV",
            "MEX",
            "MHL",
            "MKD",
            "MLI",
            "MLT",
            "MMR",
            "MNE",
            "MNG",
            "MNP",
            "MOZ",
            "MRT",
            "MSR",
            "MTQ",
            "MUS",
            "MWI",
            "MYS",
            "MYT",
            "NAM",
            "NCL",
            "NER",
            "NFK",
            "NGA",
            "NIC",
            "NIU",
            "NLD",
            "NOR",
            "NPL",
            "NRU",
            "NZL",
            "OMN",
            "PAK",
            "PAN",
            "PCN",
            "PER",
            "PHL",
            "PLW",
            "PNG",
            "POL",
            "PRI",
            "PRK",
            "PRT",
            "PRY",
            "PSE",
            "PYF",
            "QAT",
            "REU",
            "ROU",
            "RUS",
            "RWA",
            "SAU",
            "SDN",
            "SEN",
            "SGP",
            "SGS",
            "SHN",
            "SJM",
            "SLB",
            "SLE",
            "SLV",
            "SMR",
            "SOM",
            "SPM",
            "SRB",
            "SSD",
            "STP",
            "SUR",
            "SVK",
            "SVN",
            "SWE",
            "SWZ",
            "SXM",
            "SYC",
            "SYR",
            "TCA",
            "TCD",
            "TGO",
            "THA",
            "TJK",
            "TKL",
            "TKM",
            "TLS",
            "TON",
            "TTO",
            "TUN",
            "TUR",
            "TUV",
            "TWN",
            "TZA",
            "UGA",
            "UKR",
            "UMI",
            "RKS",
            "URY",
            "USA",
            "UZB",
            "VAT",
            "VCT",
            "VEN",
            "VGB",
            "VIR",
            "VNM",
            "VUT",
            "WLF",
            "WSM",
            "YEM",
            "ZAF",
            "ZMB",
            "ZWE"});
            this.CountryCodeBox.Location = new System.Drawing.Point(107, 77);
            this.CountryCodeBox.Name = "CountryCodeBox";
            this.CountryCodeBox.Size = new System.Drawing.Size(121, 23);
            this.CountryCodeBox.TabIndex = 19;
            this.CountryCodeBox.Text = "ALB";
            // 
            // SellerTown
            // 
            this.SellerTown.AutoSize = true;
            this.SellerTown.Location = new System.Drawing.Point(7, 135);
            this.SellerTown.Name = "SellerTown";
            this.SellerTown.Size = new System.Drawing.Size(69, 15);
            this.SellerTown.TabIndex = 18;
            this.SellerTown.Text = "Seller Town:";
            // 
            // SellerNuisLabel
            // 
            this.SellerNuisLabel.AutoSize = true;
            this.SellerNuisLabel.Location = new System.Drawing.Point(3, 50);
            this.SellerNuisLabel.Name = "SellerNuisLabel";
            this.SellerNuisLabel.Size = new System.Drawing.Size(64, 15);
            this.SellerNuisLabel.TabIndex = 3;
            this.SellerNuisLabel.Text = "Seller NUIS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Currency Code";
            // 
            // InvoiceGroupBox
            // 
            this.InvoiceGroupBox.Controls.Add(this.OperatorCodeBox);
            this.InvoiceGroupBox.Controls.Add(this.label6);
            this.InvoiceGroupBox.Controls.Add(this.OrderNumBox);
            this.InvoiceGroupBox.Controls.Add(this.label5);
            this.InvoiceGroupBox.Controls.Add(this.comboBox2);
            this.InvoiceGroupBox.Controls.Add(this.ExchangeRateBox);
            this.InvoiceGroupBox.Controls.Add(this.BusinUnitCode);
            this.InvoiceGroupBox.Controls.Add(this.label);
            this.InvoiceGroupBox.Controls.Add(this.comboBox1);
            this.InvoiceGroupBox.Controls.Add(this.label2);
            this.InvoiceGroupBox.Controls.Add(this.label1);
            this.InvoiceGroupBox.Controls.Add(this.PaymentMethodCombo);
            this.InvoiceGroupBox.Location = new System.Drawing.Point(6, 228);
            this.InvoiceGroupBox.Name = "InvoiceGroupBox";
            this.InvoiceGroupBox.Size = new System.Drawing.Size(483, 220);
            this.InvoiceGroupBox.TabIndex = 5;
            this.InvoiceGroupBox.TabStop = false;
            this.InvoiceGroupBox.Text = "Invoice";
            // 
            // OperatorCodeBox
            // 
            this.OperatorCodeBox.Location = new System.Drawing.Point(331, 50);
            this.OperatorCodeBox.Name = "OperatorCodeBox";
            this.OperatorCodeBox.Size = new System.Drawing.Size(120, 23);
            this.OperatorCodeBox.TabIndex = 17;
            this.OperatorCodeBox.Text = "au254tb295";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Operator Code";
            // 
            // OrderNumBox
            // 
            this.OrderNumBox.Location = new System.Drawing.Point(105, 82);
            this.OrderNumBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.OrderNumBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.OrderNumBox.Name = "OrderNumBox";
            this.OrderNumBox.Size = new System.Drawing.Size(120, 23);
            this.OrderNumBox.TabIndex = 15;
            this.OrderNumBox.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Order Num";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "AED",
            "AFN",
            "AMD",
            "ANG",
            "AOA",
            "ARS",
            "AUD",
            "AWG",
            "AZN",
            "BAM",
            "BBD",
            "BDT",
            "BGN",
            "BHD",
            "BIF",
            "BMD",
            "BND",
            "BOB",
            "BRL",
            "BSD",
            "BTN",
            "BWP",
            "BYN",
            "BZD",
            "CAD",
            "CDF",
            "CHF",
            "CLP",
            "CNY",
            "COP",
            "CRC",
            "CUC",
            "CUP",
            "CVE",
            "CZK",
            "DJF",
            "DKK",
            "DOP",
            "DZD",
            "EGP",
            "ERN",
            "ETB",
            "EUR",
            "FJD",
            "FKP",
            "GBP",
            "GEL",
            "GGP",
            "GHS",
            "GIP",
            "GMD",
            "GNF",
            "GTQ",
            "GYD",
            "HKD",
            "HNL",
            "HRK",
            "HTG",
            "HUF",
            "IDR",
            "ILS",
            "IMP",
            "INR",
            "IQD",
            "IRR",
            "ISK",
            "JEP",
            "JMD",
            "JOD",
            "JPY",
            "KES",
            "KGS",
            "KHR",
            "KMF",
            "KPW",
            "KRW",
            "KWD",
            "KYD",
            "KZT",
            "LAK",
            "LBP",
            "LKR",
            "LRD",
            "LSL",
            "LYD",
            "MAD",
            "MDL",
            "MGA",
            "MKD",
            "MMK",
            "MNT",
            "MOP",
            "MRU",
            "MUR",
            "MVR",
            "MWK",
            "MXN",
            "MYR",
            "MZN",
            "NAD",
            "NGN",
            "NIO",
            "NOK",
            "NPR",
            "NZD",
            "OMR",
            "PAB",
            "PEN",
            "PGK",
            "PHP",
            "PKR",
            "PLN",
            "PYG",
            "QAR",
            "RON",
            "RSD",
            "RUB",
            "RWF",
            "SAR",
            "SBD",
            "SCR",
            "SDG",
            "SEK",
            "SGD",
            "SHP",
            "SLL",
            "SOS",
            "SPL",
            "SRD",
            "STN",
            "SVC",
            "SYP",
            "SZL",
            "THB",
            "TJS",
            "TMT",
            "TND",
            "TOP",
            "TRY",
            "TTD",
            "TVD",
            "TWD",
            "TZS",
            "UAH",
            "UGX",
            "USD",
            "UYU",
            "UZS",
            "VEF",
            "VND",
            "VUV",
            "WST",
            "XAF",
            "XCD",
            "XDR",
            "XOF",
            "XPF",
            "YER",
            "ZAR",
            "ZMW",
            "ZWD"});
            this.comboBox2.Location = new System.Drawing.Point(104, 112);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.Text = "EUR";
            // 
            // ExchangeRateBox
            // 
            this.ExchangeRateBox.DecimalPlaces = 2;
            this.ExchangeRateBox.Location = new System.Drawing.Point(331, 83);
            this.ExchangeRateBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ExchangeRateBox.Name = "ExchangeRateBox";
            this.ExchangeRateBox.Size = new System.Drawing.Size(120, 23);
            this.ExchangeRateBox.TabIndex = 13;
            this.ExchangeRateBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BusinUnitCode
            // 
            this.BusinUnitCode.Location = new System.Drawing.Point(105, 50);
            this.BusinUnitCode.Name = "BusinUnitCode";
            this.BusinUnitCode.Size = new System.Drawing.Size(121, 23);
            this.BusinUnitCode.TabIndex = 9;
            this.BusinUnitCode.Text = "wo765uk675";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(0, 53);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(92, 15);
            this.label.TabIndex = 8;
            this.label.Text = "Busin Unit Code";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CASH",
            "NONCASH"});
            this.comboBox1.Location = new System.Drawing.Point(331, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "NONCASH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Invoice Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Payment Method";
            // 
            // PaymentMethodCombo
            // 
            this.PaymentMethodCombo.FormattingEnabled = true;
            this.PaymentMethodCombo.Items.AddRange(new object[] {
            "BANKNOTE",
            "CARD",
            "CHECK",
            "SVOUCHER",
            "COMPANY",
            "ORDER",
            "ACCOUNT",
            "FACTORING",
            "COMPENSATION",
            "TRANSFER",
            "WAIVER",
            "KIND",
            "OTHER"});
            this.PaymentMethodCombo.Location = new System.Drawing.Point(105, 20);
            this.PaymentMethodCombo.Name = "PaymentMethodCombo";
            this.PaymentMethodCombo.Size = new System.Drawing.Size(121, 23);
            this.PaymentMethodCombo.TabIndex = 4;
            this.PaymentMethodCombo.Text = "TRANSFER";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "p12";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Cert|*.p12|All files|*.*";
            this.openFileDialog1.ReadOnlyChecked = true;
            // 
            // RegisterEInvoiceBtn
            // 
            this.RegisterEInvoiceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RegisterEInvoiceBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.RegisterEInvoiceBtn.Location = new System.Drawing.Point(321, 557);
            this.RegisterEInvoiceBtn.Name = "RegisterEInvoiceBtn";
            this.RegisterEInvoiceBtn.Size = new System.Drawing.Size(156, 30);
            this.RegisterEInvoiceBtn.TabIndex = 15;
            this.RegisterEInvoiceBtn.Text = "Register EInvoice";
            this.RegisterEInvoiceBtn.UseVisualStyleBackColor = false;
            this.RegisterEInvoiceBtn.Click += new System.EventHandler(this.RegisterEInvoiceBtn_Click);
            // 
            // EInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 614);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.Menu;
            this.Name = "EInvoiceForm";
            this.Text = "EInvoice";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.InvoiceGroupBox.ResumeLayout(false);
            this.InvoiceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderNumBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExchangeRateBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem CreateEInvoice;
        private System.Windows.Forms.ToolStripMenuItem GetTaxPayers;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label BuyerNuisLabel;
        private System.Windows.Forms.TextBox BuyerNuisTextBox;
        private System.Windows.Forms.Label SellerNuisLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox InvoiceGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PaymentMethodCombo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox BusinUnitCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ExchangeRateBox;
        private System.Windows.Forms.NumericUpDown OrderNumBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox OperatorCodeBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label SellerTown;
        private System.Windows.Forms.ComboBox CountryCodeBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button SelectCertificateButton;
        private System.Windows.Forms.Label SellerNameValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label SellerNuisValue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label SellerTownValue;
        private System.Windows.Forms.Button RegisterInvoiceButton;
        private System.Windows.Forms.Button RegisterEInvoiceBtn;
    }
}

