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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ButtonCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.PanelDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.PanelDate.BackColor = System.Drawing.Color.Aquamarine;
            this.PanelDate.Controls.Add(this.LabelTime);
            this.PanelDate.Controls.Add(this.LabelDate);
            this.PanelDate.Location = new System.Drawing.Point(1503, 25);
            this.PanelDate.Name = "PanelDate";
            this.PanelDate.Size = new System.Drawing.Size(78, 78);
            this.PanelDate.TabIndex = 2;
            this.PanelDate.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDate_Paint);
            // 
            // RadioButtonWomen
            // 
            this.RadioButtonWomen.AutoSize = true;
            this.RadioButtonWomen.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RadioButtonWomen.Location = new System.Drawing.Point(24, 129);
            this.RadioButtonWomen.Name = "RadioButtonWomen";
            this.RadioButtonWomen.Size = new System.Drawing.Size(134, 41);
            this.RadioButtonWomen.TabIndex = 3;
            this.RadioButtonWomen.TabStop = true;
            this.RadioButtonWomen.Text = "Women";
            this.RadioButtonWomen.UseVisualStyleBackColor = true;
            // 
            // RadioButtonMen
            // 
            this.RadioButtonMen.AutoSize = true;
            this.RadioButtonMen.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RadioButtonMen.Location = new System.Drawing.Point(24, 193);
            this.RadioButtonMen.Name = "RadioButtonMen";
            this.RadioButtonMen.Size = new System.Drawing.Size(92, 41);
            this.RadioButtonMen.TabIndex = 4;
            this.RadioButtonMen.TabStop = true;
            this.RadioButtonMen.Text = "Men";
            this.RadioButtonMen.UseVisualStyleBackColor = true;
            // 
            // RadioButtonKids
            // 
            this.RadioButtonKids.AutoSize = true;
            this.RadioButtonKids.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RadioButtonKids.Location = new System.Drawing.Point(26, 261);
            this.RadioButtonKids.Name = "RadioButtonKids";
            this.RadioButtonKids.Size = new System.Drawing.Size(90, 41);
            this.RadioButtonKids.TabIndex = 5;
            this.RadioButtonKids.TabStop = true;
            this.RadioButtonKids.Text = "Kids";
            this.RadioButtonKids.UseVisualStyleBackColor = true;
            // 
            // CheckBoxWash
            // 
            this.CheckBoxWash.AutoSize = true;
            this.CheckBoxWash.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxWash.Location = new System.Drawing.Point(295, 129);
            this.CheckBoxWash.Name = "CheckBoxWash";
            this.CheckBoxWash.Size = new System.Drawing.Size(100, 41);
            this.CheckBoxWash.TabIndex = 6;
            this.CheckBoxWash.Text = "Wash";
            this.CheckBoxWash.UseVisualStyleBackColor = true;
            // 
            // CheckBoxCutAndHairstyle
            // 
            this.CheckBoxCutAndHairstyle.AutoSize = true;
            this.CheckBoxCutAndHairstyle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxCutAndHairstyle.Location = new System.Drawing.Point(295, 193);
            this.CheckBoxCutAndHairstyle.Name = "CheckBoxCutAndHairstyle";
            this.CheckBoxCutAndHairstyle.Size = new System.Drawing.Size(246, 41);
            this.CheckBoxCutAndHairstyle.TabIndex = 7;
            this.CheckBoxCutAndHairstyle.Text = "Cut  and Hairstyle";
            this.CheckBoxCutAndHairstyle.UseVisualStyleBackColor = true;
            // 
            // CheckBoxHairstyle
            // 
            this.CheckBoxHairstyle.AutoSize = true;
            this.CheckBoxHairstyle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxHairstyle.Location = new System.Drawing.Point(295, 261);
            this.CheckBoxHairstyle.Name = "CheckBoxHairstyle";
            this.CheckBoxHairstyle.Size = new System.Drawing.Size(139, 41);
            this.CheckBoxHairstyle.TabIndex = 8;
            this.CheckBoxHairstyle.Text = "Hairstyle";
            this.CheckBoxHairstyle.UseVisualStyleBackColor = true;
            // 
            // CheckBoxDye
            // 
            this.CheckBoxDye.AutoSize = true;
            this.CheckBoxDye.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxDye.Location = new System.Drawing.Point(295, 324);
            this.CheckBoxDye.Name = "CheckBoxDye";
            this.CheckBoxDye.Size = new System.Drawing.Size(82, 41);
            this.CheckBoxDye.TabIndex = 9;
            this.CheckBoxDye.Text = "Dye";
            this.CheckBoxDye.UseVisualStyleBackColor = true;
            // 
            // CheckBoxPermanent
            // 
            this.CheckBoxPermanent.AutoSize = true;
            this.CheckBoxPermanent.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxPermanent.Location = new System.Drawing.Point(295, 389);
            this.CheckBoxPermanent.Name = "CheckBoxPermanent";
            this.CheckBoxPermanent.Size = new System.Drawing.Size(163, 41);
            this.CheckBoxPermanent.TabIndex = 10;
            this.CheckBoxPermanent.Text = "Permanent";
            this.CheckBoxPermanent.UseVisualStyleBackColor = true;
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
            this.comboBoxIVA.Location = new System.Drawing.Point(67, 336);
            this.comboBoxIVA.Name = "comboBoxIVA";
            this.comboBoxIVA.Size = new System.Drawing.Size(121, 23);
            this.comboBoxIVA.TabIndex = 11;
            this.comboBoxIVA.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(272, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.BackColor = System.Drawing.Color.Aquamarine;
            this.ButtonCalculate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonCalculate.ForeColor = System.Drawing.Color.MintCream;
            this.ButtonCalculate.Location = new System.Drawing.Point(26, 398);
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
            this.label1.Location = new System.Drawing.Point(18, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "IVA";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(710, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(710, 245);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(710, 198);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(616, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "SERVICE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(638, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "PRICE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(659, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "IVA";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(710, 306);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(634, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "TOTAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(639, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "CASH";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(710, 375);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(568, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "CHANGE DUE";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(710, 424);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 23);
            this.textBox6.TabIndex = 27;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1593, 677);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonCalculate);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxIVA);
            this.Controls.Add(this.CheckBoxPermanent);
            this.Controls.Add(this.CheckBoxDye);
            this.Controls.Add(this.CheckBoxHairstyle);
            this.Controls.Add(this.CheckBoxCutAndHairstyle);
            this.Controls.Add(this.CheckBoxWash);
            this.Controls.Add(this.RadioButtonKids);
            this.Controls.Add(this.RadioButtonMen);
            this.Controls.Add(this.RadioButtonWomen);
            this.Controls.Add(this.PanelDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "The King Barber";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.PanelDate.ResumeLayout(false);
            this.PanelDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
    }
}