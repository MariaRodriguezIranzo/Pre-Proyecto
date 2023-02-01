using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P13_MaríaRodriguez
{
    public partial class FormMain : Form
    {
        //constructor

        public FormMain()
        {
            InitializeComponent();
            initConfig();

            
        }
        private void initConfig()
        {
            comboBoxIVA.SelectedIndex = 3;
            RadioButtonWomen.Checked = true;

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void dateclock()
        {
            string date = DateTime.Now.ToString("MM/dd/yyyy");
            LabelDate.Text = date;
            string clock = DateTime.Now.ToString("HH:mm");
            LabelTime.Text = clock;
        }

        private void PanelDate_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateclock();
        }
    }
}
