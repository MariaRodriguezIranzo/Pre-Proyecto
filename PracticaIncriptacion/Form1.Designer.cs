namespace PracticaIncriptacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxMD5 = new System.Windows.Forms.TextBox();
            this.labelPaswordMD5 = new System.Windows.Forms.Label();
            this.textBoxSha1 = new System.Windows.Forms.TextBox();
            this.labelPaswordSHA1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxJSON = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(97, 15);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(97, 74);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pasword";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button1.Location = new System.Drawing.Point(97, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Accept";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxMD5
            // 
            this.textBoxMD5.Location = new System.Drawing.Point(120, 229);
            this.textBoxMD5.Name = "textBoxMD5";
            this.textBoxMD5.Size = new System.Drawing.Size(268, 20);
            this.textBoxMD5.TabIndex = 6;
            // 
            // labelPaswordMD5
            // 
            this.labelPaswordMD5.AutoSize = true;
            this.labelPaswordMD5.Location = new System.Drawing.Point(33, 232);
            this.labelPaswordMD5.Name = "labelPaswordMD5";
            this.labelPaswordMD5.Size = new System.Drawing.Size(74, 13);
            this.labelPaswordMD5.TabIndex = 5;
            this.labelPaswordMD5.Text = "Pasword MD5";
            // 
            // textBoxSha1
            // 
            this.textBoxSha1.Location = new System.Drawing.Point(120, 278);
            this.textBoxSha1.Name = "textBoxSha1";
            this.textBoxSha1.Size = new System.Drawing.Size(309, 20);
            this.textBoxSha1.TabIndex = 8;
            // 
            // labelPaswordSHA1
            // 
            this.labelPaswordSHA1.AutoSize = true;
            this.labelPaswordSHA1.Location = new System.Drawing.Point(33, 281);
            this.labelPaswordSHA1.Name = "labelPaswordSHA1";
            this.labelPaswordSHA1.Size = new System.Drawing.Size(79, 13);
            this.labelPaswordSHA1.TabIndex = 7;
            this.labelPaswordSHA1.Text = "Pasword SHA1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.textBoxLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(60, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 165);
            this.panel1.TabIndex = 9;
            // 
            // textBoxJSON
            // 
            this.textBoxJSON.Location = new System.Drawing.Point(435, 47);
            this.textBoxJSON.Multiline = true;
            this.textBoxJSON.Name = "textBoxJSON";
            this.textBoxJSON.Size = new System.Drawing.Size(242, 247);
            this.textBoxJSON.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(742, 355);
            this.Controls.Add(this.textBoxJSON);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxSha1);
            this.Controls.Add(this.labelPaswordSHA1);
            this.Controls.Add(this.textBoxMD5);
            this.Controls.Add(this.labelPaswordMD5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxMD5;
        private System.Windows.Forms.Label labelPaswordMD5;
        private System.Windows.Forms.TextBox textBoxSha1;
        private System.Windows.Forms.Label labelPaswordSHA1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxJSON;
    }
}

