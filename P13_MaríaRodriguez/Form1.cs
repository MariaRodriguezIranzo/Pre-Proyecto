using System.Diagnostics;
using System.Text.Json;

namespace P13_MaríaRodriguez
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        //desing+date+clock(3p) = 3p
        //calculate(3p) = 3p
        //Use the array and matrix the price (3p) = 3p
        //Extra windows calculator + web (1p) = 1p

        //DECLARACIONES GLOBALES
        int count = 0;

        public Form1()
        {
            InitializeComponent();
            InitConfig();

        }
        private void InitConfig()
        {
            textBoxSHA1.Visible = false;
            labelSHA1.Visible = false;
            textBoxJSON.Visible=false;
            textBoxJSON1.Visible=false;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            //mirar que el login y password correcto
            String login;
            login= TextBoxLogin.Text;

            String password;
            password= TextBoxPassword.Text;

            //seguridad contraseña
            String passwordSHA1 = ClassSecurity.sha1Digest(password);
            textBoxSHA1.Text = passwordSHA1;
            textBoxSHA1.Visible = false;
            labelSHA1.Visible = false;

            if (login == "Monlau" && password=="2022" && passwordSHA1== "E575DCCC71140754DD85BEDA5965B6A358150309") { 
                timer1.Enabled = true;
                LabelError.Enabled = false;
                LabelError.Visible = false;
                
            }
            else
            {
                LabelError.Visible = true;
                LabelError.Enabled = true;
            }


            textBoxJSON.Text = ClassSecurity.convertToJSON(login, passwordSHA1);
            textBoxJSON1.Text = ClassSecurity.convertToJSON(login,password);
            textBoxJSON.Visible = true;
            textBoxJSON1.Visible = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count <= 100)
            {
                ProgressBar1.Value = count;
            }
            else {
                timer1.Enabled = false;
                //ir a la siguiente pantalla
                System.Windows.Forms.Form fmain=new Form();
                this.Hide();
                fmain.ShowDialog();
                this.Close();
            }
        }

        private void ButtonEye1_Click(object sender, EventArgs e)
        {
            //mostrar ojo
            TextBoxPassword.PasswordChar = '\0';
            ButtonEye2.BringToFront();
        }
        private void ButtonEye2_Click(object sender, EventArgs e)
        {
            //ocultar ojo
            TextBoxPassword.PasswordChar = '*';
            ButtonEye1.BringToFront();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer", "https://www.google.com");
        }

        

    }
}