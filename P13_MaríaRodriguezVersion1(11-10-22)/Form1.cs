using System.Diagnostics;

namespace P13_MaríaRodriguez
{
    public partial class Form1 : Form
    {
        //DECLARACIONES GLOBALES
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            //mirar que el login y password correcto
            String login;
            login= TextBoxLogin.Text;

            String password;
            password= TextBoxPassword.Text;
            
            if (login == "Monlau" && password=="2022") { 
                timer1.Enabled = true;
                LabelError.Enabled = false;
                LabelError.Visible = false;


            }
            else
            {
                LabelError.Visible = true;
                LabelError.Enabled = true;
            }
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
                Form fmain=new FormMain();
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
            Process.Start("explorer", "https://moodle.monlau.com/");
        }
    }
}