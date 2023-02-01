namespace P13_MaríaRodriguez
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.LabelDate = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.PanelDate = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RadioButtonWomen = new System.Windows.Forms.RadioButton();
            this.RadioButtonMen = new System.Windows.Forms.RadioButton();
            this.RadioButtonKids = new System.Windows.Forms.RadioButton();
            this.CheckBoxWash = new System.Windows.Forms.CheckBox();
            this.CheckBoxCutAndHairstyle = new System.Windows.Forms.CheckBox();
            this.CheckBoxHairstyle = new System.Windows.Forms.CheckBox();
            this.CheckBoxDye = new System.Windows.Forms.CheckBox();
            this.CheckBoxPermanent = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBoxIVA = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxService = new System.Windows.Forms.TextBox();
            this.TextBoxIVA = new System.Windows.Forms.TextBox();
            this.TextBoxPrice = new System.Windows.Forms.TextBox();
            this.LabelServices = new System.Windows.Forms.Label();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.LabelIVA = new System.Windows.Forms.Label();
            this.TextBoxTotal = new System.Windows.Forms.TextBox();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.PanelGen = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ButtonPrint = new System.Windows.Forms.Button();
            this.PanelDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelGen.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelDate.ForeColor = System.Drawing.Color.White;
            this.LabelDate.Location = new System.Drawing.Point(3, 13);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(41, 17);
            this.LabelDate.TabIndex = 0;
            this.LabelDate.Text = "DATE";
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelTime.ForeColor = System.Drawing.Color.White;
            this.LabelTime.Location = new System.Drawing.Point(15, 47);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(39, 17);
            this.LabelTime.TabIndex = 1;
            this.LabelTime.Text = "TIME";
            // 
            // PanelDate
            // 
            this.PanelDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelDate.BackColor = System.Drawing.Color.Aquamarine;
            this.PanelDate.Controls.Add(this.LabelTime);
            this.PanelDate.Controls.Add(this.LabelDate);
            this.PanelDate.Location = new System.Drawing.Point(1252, 12);
            this.PanelDate.Name = "PanelDate";
            this.PanelDate.Size = new System.Drawing.Size(78, 78);
            this.PanelDate.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(75, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // RadioButtonWomen
            // 
            this.RadioButtonWomen.AutoSize = true;
            this.RadioButtonWomen.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RadioButtonWomen.Location = new System.Drawing.Point(24, 159);
            this.RadioButtonWomen.Name = "RadioButtonWomen";
            this.RadioButtonWomen.Size = new System.Drawing.Size(134, 41);
            this.RadioButtonWomen.TabIndex = 3;
            this.RadioButtonWomen.TabStop = true;
            this.RadioButtonWomen.Text = "Women";
            this.RadioButtonWomen.UseVisualStyleBackColor = true;
            this.RadioButtonWomen.Click += new System.EventHandler(this.Gender);
            // 
            // RadioButtonMen
            // 
            this.RadioButtonMen.AutoSize = true;
            this.RadioButtonMen.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RadioButtonMen.Location = new System.Drawing.Point(24, 230);
            this.RadioButtonMen.Name = "RadioButtonMen";
            this.RadioButtonMen.Size = new System.Drawing.Size(92, 41);
            this.RadioButtonMen.TabIndex = 4;
            this.RadioButtonMen.TabStop = true;
            this.RadioButtonMen.Text = "Men";
            this.RadioButtonMen.UseVisualStyleBackColor = true;
            this.RadioButtonMen.Click += new System.EventHandler(this.Gender);
            // 
            // RadioButtonKids
            // 
            this.RadioButtonKids.AutoSize = true;
            this.RadioButtonKids.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RadioButtonKids.Location = new System.Drawing.Point(24, 301);
            this.RadioButtonKids.Name = "RadioButtonKids";
            this.RadioButtonKids.Size = new System.Drawing.Size(90, 41);
            this.RadioButtonKids.TabIndex = 5;
            this.RadioButtonKids.TabStop = true;
            this.RadioButtonKids.Text = "Kids";
            this.RadioButtonKids.UseVisualStyleBackColor = true;
            this.RadioButtonKids.Click += new System.EventHandler(this.Gender);
            // 
            // CheckBoxWash
            // 
            this.CheckBoxWash.AutoSize = true;
            this.CheckBoxWash.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxWash.Location = new System.Drawing.Point(35, 138);
            this.CheckBoxWash.Name = "CheckBoxWash";
            this.CheckBoxWash.Size = new System.Drawing.Size(100, 41);
            this.CheckBoxWash.TabIndex = 6;
            this.CheckBoxWash.Text = "Wash";
            this.CheckBoxWash.UseVisualStyleBackColor = true;
            this.CheckBoxWash.Click += new System.EventHandler(this.Services);
            // 
            // CheckBoxCutAndHairstyle
            // 
            this.CheckBoxCutAndHairstyle.AutoSize = true;
            this.CheckBoxCutAndHairstyle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxCutAndHairstyle.Location = new System.Drawing.Point(35, 194);
            this.CheckBoxCutAndHairstyle.Name = "CheckBoxCutAndHairstyle";
            this.CheckBoxCutAndHairstyle.Size = new System.Drawing.Size(246, 41);
            this.CheckBoxCutAndHairstyle.TabIndex = 7;
            this.CheckBoxCutAndHairstyle.Text = "Cut  and Hairstyle";
            this.CheckBoxCutAndHairstyle.UseVisualStyleBackColor = true;
            this.CheckBoxCutAndHairstyle.Click += new System.EventHandler(this.Services);
            // 
            // CheckBoxHairstyle
            // 
            this.CheckBoxHairstyle.AutoSize = true;
            this.CheckBoxHairstyle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxHairstyle.Location = new System.Drawing.Point(35, 257);
            this.CheckBoxHairstyle.Name = "CheckBoxHairstyle";
            this.CheckBoxHairstyle.Size = new System.Drawing.Size(139, 41);
            this.CheckBoxHairstyle.TabIndex = 8;
            this.CheckBoxHairstyle.Text = "Hairstyle";
            this.CheckBoxHairstyle.UseVisualStyleBackColor = true;
            this.CheckBoxHairstyle.Click += new System.EventHandler(this.Services);
            // 
            // CheckBoxDye
            // 
            this.CheckBoxDye.AutoSize = true;
            this.CheckBoxDye.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxDye.Location = new System.Drawing.Point(35, 325);
            this.CheckBoxDye.Name = "CheckBoxDye";
            this.CheckBoxDye.Size = new System.Drawing.Size(82, 41);
            this.CheckBoxDye.TabIndex = 9;
            this.CheckBoxDye.Text = "Dye";
            this.CheckBoxDye.UseVisualStyleBackColor = true;
            this.CheckBoxDye.Click += new System.EventHandler(this.Services);
            // 
            // CheckBoxPermanent
            // 
            this.CheckBoxPermanent.AutoSize = true;
            this.CheckBoxPermanent.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxPermanent.Location = new System.Drawing.Point(35, 390);
            this.CheckBoxPermanent.Name = "CheckBoxPermanent";
            this.CheckBoxPermanent.Size = new System.Drawing.Size(163, 41);
            this.CheckBoxPermanent.TabIndex = 10;
            this.CheckBoxPermanent.Text = "Permanent";
            this.CheckBoxPermanent.UseVisualStyleBackColor = true;
            this.CheckBoxPermanent.Click += new System.EventHandler(this.Services);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBoxIVA
            // 
            this.comboBoxIVA.FormattingEnabled = true;
            this.comboBoxIVA.Items.AddRange(new object[] {
            "0",
            "4",
            "10",
            "21"});
            this.comboBoxIVA.Location = new System.Drawing.Point(89, 374);
            this.comboBoxIVA.Name = "comboBoxIVA";
            this.comboBoxIVA.Size = new System.Drawing.Size(121, 23);
            this.comboBoxIVA.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonCalculate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonCalculate.ForeColor = System.Drawing.Color.MintCream;
            this.ButtonCalculate.Location = new System.Drawing.Point(41, 426);
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.Size = new System.Drawing.Size(162, 33);
            this.ButtonCalculate.TabIndex = 14;
            this.ButtonCalculate.Text = "Calculate";
            this.ButtonCalculate.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "IVA";
            // 
            // TextBoxService
            // 
            this.TextBoxService.Location = new System.Drawing.Point(110, 149);
            this.TextBoxService.Name = "TextBoxService";
            this.TextBoxService.Size = new System.Drawing.Size(100, 23);
            this.TextBoxService.TabIndex = 16;
            // 
            // TextBoxIVA
            // 
            this.TextBoxIVA.Location = new System.Drawing.Point(110, 318);
            this.TextBoxIVA.Name = "TextBoxIVA";
            this.TextBoxIVA.Size = new System.Drawing.Size(100, 23);
            this.TextBoxIVA.TabIndex = 17;
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.Location = new System.Drawing.Point(110, 227);
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.Size = new System.Drawing.Size(100, 23);
            this.TextBoxPrice.TabIndex = 18;
            // 
            // LabelServices
            // 
            this.LabelServices.AutoSize = true;
            this.LabelServices.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelServices.Location = new System.Drawing.Point(10, 149);
            this.LabelServices.Name = "LabelServices";
            this.LabelServices.Size = new System.Drawing.Size(86, 25);
            this.LabelServices.TabIndex = 19;
            this.LabelServices.Text = "SERVICE";
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelPrice.Location = new System.Drawing.Point(14, 225);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(64, 25);
            this.LabelPrice.TabIndex = 20;
            this.LabelPrice.Text = "PRICE";
            // 
            // LabelIVA
            // 
            this.LabelIVA.AutoSize = true;
            this.LabelIVA.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelIVA.Location = new System.Drawing.Point(31, 316);
            this.LabelIVA.Name = "LabelIVA";
            this.LabelIVA.Size = new System.Drawing.Size(43, 25);
            this.LabelIVA.TabIndex = 21;
            this.LabelIVA.Text = "IVA";
            // 
            // TextBoxTotal
            // 
            this.TextBoxTotal.Location = new System.Drawing.Point(110, 408);
            this.TextBoxTotal.Name = "TextBoxTotal";
            this.TextBoxTotal.Size = new System.Drawing.Size(100, 23);
            this.TextBoxTotal.TabIndex = 22;
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelTotal.Location = new System.Drawing.Point(10, 401);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(68, 25);
            this.LabelTotal.TabIndex = 23;
            this.LabelTotal.Text = "TOTAL";
            // 
            // PanelGen
            // 
            this.PanelGen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelGen.BackColor = System.Drawing.Color.Aquamarine;
            this.PanelGen.Controls.Add(this.RadioButtonWomen);
            this.PanelGen.Controls.Add(this.RadioButtonMen);
            this.PanelGen.Controls.Add(this.RadioButtonKids);
            this.PanelGen.Controls.Add(this.pictureBox1);
            this.PanelGen.Controls.Add(this.label1);
            this.PanelGen.Controls.Add(this.comboBoxIVA);
            this.PanelGen.Controls.Add(this.ButtonCalculate);
            this.PanelGen.Location = new System.Drawing.Point(60, 68);
            this.PanelGen.Name = "PanelGen";
            this.PanelGen.Size = new System.Drawing.Size(235, 475);
            this.PanelGen.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.CheckBoxWash);
            this.panel1.Controls.Add(this.CheckBoxCutAndHairstyle);
            this.panel1.Controls.Add(this.CheckBoxHairstyle);
            this.panel1.Controls.Add(this.CheckBoxDye);
            this.panel1.Controls.Add(this.CheckBoxPermanent);
            this.panel1.Location = new System.Drawing.Point(342, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 472);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Aquamarine;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.LabelServices);
            this.panel2.Controls.Add(this.TextBoxService);
            this.panel2.Controls.Add(this.LabelPrice);
            this.panel2.Controls.Add(this.LabelTotal);
            this.panel2.Controls.Add(this.TextBoxPrice);
            this.panel2.Controls.Add(this.TextBoxTotal);
            this.panel2.Controls.Add(this.LabelIVA);
            this.panel2.Controls.Add(this.TextBoxIVA);
            this.panel2.Location = new System.Drawing.Point(673, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 475);
            this.panel2.TabIndex = 26;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(58, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(110, 98);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 244);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(24, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "CHANGE";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "CASH";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(80, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(109, 99);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.Aquamarine;
            this.panel3.Controls.Add(this.ButtonPrint);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(956, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(257, 366);
            this.panel3.TabIndex = 27;
            // 
            // ButtonPrint
            // 
            this.ButtonPrint.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonPrint.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonPrint.ForeColor = System.Drawing.Color.MintCream;
            this.ButtonPrint.Location = new System.Drawing.Point(48, 317);
            this.ButtonPrint.Name = "ButtonPrint";
            this.ButtonPrint.Size = new System.Drawing.Size(162, 33);
            this.ButtonPrint.TabIndex = 28;
            this.ButtonPrint.Text = "Print";
            this.ButtonPrint.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1342, 629);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelGen);
            this.Controls.Add(this.PanelDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = resources.GetString("$this.Text");
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.PanelDate.ResumeLayout(false);
            this.PanelDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelGen.ResumeLayout(false);
            this.PanelGen.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label LabelDate;
        private Label LabelTime;
        private Panel PanelDate;
        private RadioButton RadioButtonWomen;
        private RadioButton RadioButtonMen;
        private RadioButton RadioButtonKids;
        private CheckBox CheckBoxWash;
        private CheckBox CheckBoxCutAndHairstyle;
        private CheckBox CheckBoxHairstyle;
        private CheckBox CheckBoxDye;
        private CheckBox CheckBoxPermanent;
        private System.Windows.Forms.Timer timer1;
        private ComboBox comboBoxIVA;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button ButtonCalculate;
        private Label label1;
        private TextBox TextBoxService;
        private TextBox TextBoxIVA;
        private TextBox TextBoxPrice;
        private Label LabelServices;
        private Label LabelPrice;
        private Label LabelIVA;
        private TextBox TextBoxTotal;
        private Label LabelTotal;
        private Panel PanelGen;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Panel panel3;
        private Button ButtonPrint;
    }
}