using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace PracticaIncriptacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String password = textBoxPassword.Text;
            String passwordMD5=ClassSecurity.MD5Digest(password);
            textBoxMD5.Text = passwordMD5;
            String passwordSHA1= ClassSecurity.sha1Digest(password);
            textBoxSha1.Text = passwordSHA1;

            convertToJSON();
        }

        private void convertToJSON()
        {
            /*ClassPassword p=new ClassPassword();
            p.Password = textBoxPassword.Text;
            p.Login = textBoxLogin.Text;
            */

            var p = new ClassPassword
            {
            Login = textBoxLogin.Text,
            Password = textBoxPassword.Text,
            };

            string  jsonString= convertToJson(p);
            textBoxJSON.Text = jsonString;

        }

        private string convertToJson(Object ob)
        {
            return JsonSerializer.Serialize(ob);
        }
    }
}
