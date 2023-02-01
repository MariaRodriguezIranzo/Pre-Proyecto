namespace P13_MaríaRodriguez
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LabelLogin = new System.Windows.Forms.Label();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonEye1 = new System.Windows.Forms.Button();
            this.ButtonEye2 = new System.Windows.Forms.Button();
            this.LabelError = new System.Windows.Forms.Label();
            this.LabelTextInsert = new System.Windows.Forms.Label();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.ButtonWeb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelLogin.Location = new System.Drawing.Point(194, 157);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(78, 32);
            this.LabelLogin.TabIndex = 0;
            this.LabelLogin.Text = "Login";
            this.LabelLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.BackColor = System.Drawing.Color.Aqua;
            this.TextBoxLogin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxLogin.Location = new System.Drawing.Point(278, 154);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(260, 39);
            this.TextBoxLogin.TabIndex = 0;
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelPassword.Location = new System.Drawing.Point(150, 228);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(122, 32);
            this.LabelPassword.TabIndex = 2;
            this.LabelPassword.Text = "Password";
            this.LabelPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BackColor = System.Drawing.Color.Aqua;
            this.TextBoxPassword.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxPassword.Location = new System.Drawing.Point(278, 224);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(260, 39);
            this.TextBoxPassword.TabIndex = 1;
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.ForeColor = System.Drawing.Color.Aqua;
            this.ProgressBar1.Location = new System.Drawing.Point(12, 415);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(776, 23);
            this.ProgressBar1.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ButtonStart
            // 
            this.ButtonStart.BackColor = System.Drawing.Color.Aqua;
            this.ButtonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStart.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonStart.Location = new System.Drawing.Point(452, 297);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(140, 40);
            this.ButtonStart.TabIndex = 5;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = false;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonEye1
            // 
            this.ButtonEye1.Image = ((System.Drawing.Image)(resources.GetObject("ButtonEye1.Image")));
            this.ButtonEye1.Location = new System.Drawing.Point(544, 223);
            this.ButtonEye1.Name = "ButtonEye1";
            this.ButtonEye1.Size = new System.Drawing.Size(48, 39);
            this.ButtonEye1.TabIndex = 6;
            this.ButtonEye1.UseVisualStyleBackColor = true;
            this.ButtonEye1.Click += new System.EventHandler(this.ButtonEye1_Click);
            // 
            // ButtonEye2
            // 
            this.ButtonEye2.Image = ((System.Drawing.Image)(resources.GetObject("ButtonEye2.Image")));
            this.ButtonEye2.Location = new System.Drawing.Point(544, 223);
            this.ButtonEye2.Name = "ButtonEye2";
            this.ButtonEye2.Size = new System.Drawing.Size(48, 39);
            this.ButtonEye2.TabIndex = 7;
            this.ButtonEye2.UseVisualStyleBackColor = true;
            this.ButtonEye2.Click += new System.EventHandler(this.ButtonEye2_Click);
            // 
            // LabelError
            // 
            this.LabelError.AutoSize = true;
            this.LabelError.Enabled = false;
            this.LabelError.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelError.ForeColor = System.Drawing.Color.IndianRed;
            this.LabelError.Location = new System.Drawing.Point(150, 363);
            this.LabelError.Name = "LabelError";
            this.LabelError.Size = new System.Drawing.Size(519, 30);
            this.LabelError.TabIndex = 8;
            this.LabelError.Text = "The password or login is incorrect, please try again.";
            this.LabelError.Visible = false;
            this.LabelError.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LabelTextInsert
            // 
            this.LabelTextInsert.AutoSize = true;
            this.LabelTextInsert.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelTextInsert.ForeColor = System.Drawing.Color.Aqua;
            this.LabelTextInsert.Location = new System.Drawing.Point(215, 89);
            this.LabelTextInsert.Name = "LabelTextInsert";
            this.LabelTextInsert.Size = new System.Drawing.Size(373, 32);
            this.LabelTextInsert.TabIndex = 9;
            this.LabelTextInsert.Text = "Insert your login and password";
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxLogo.Image")));
            this.PictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(147, 114);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxLogo.TabIndex = 10;
            this.PictureBoxLogo.TabStop = false;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelName.Location = new System.Drawing.Point(233, 21);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(355, 46);
            this.LabelName.TabIndex = 11;
            this.LabelName.Text = "THE KING BARBER";
            // 
            // ButtonWeb
            // 
            this.ButtonWeb.BackColor = System.Drawing.Color.Aqua;
            this.ButtonWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonWeb.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonWeb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonWeb.Location = new System.Drawing.Point(194, 297);
            this.ButtonWeb.Name = "ButtonWeb";
            this.ButtonWeb.Size = new System.Drawing.Size(140, 40);
            this.ButtonWeb.TabIndex = 12;
            this.ButtonWeb.Text = "WEB";
            this.ButtonWeb.UseVisualStyleBackColor = false;
            this.ButtonWeb.Click += new System.EventHandler(this.ButtonWeb_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonWeb);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.PictureBoxLogo);
            this.Controls.Add(this.LabelTextInsert);
            this.Controls.Add(this.LabelError);
            this.Controls.Add(this.ButtonEye1);
            this.Controls.Add(this.ButtonEye2);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.TextBoxLogin);
            this.Controls.Add(this.LabelLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The King Barber";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelLogin;
        private TextBox TextBoxLogin;
        private Label LabelPassword;
        private TextBox TextBoxPassword;
        private ProgressBar ProgressBar1;
        private System.Windows.Forms.Timer timer1;
        private Button ButtonStart;
        private Button ButtonEye1;
        private Button ButtonEye2;
        private Label LabelError;
        private Label LabelTextInsert;
        private PictureBox PictureBoxLogo;
        private Label LabelName;
        private Button ButtonWeb;
    }
}