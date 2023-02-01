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
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dateclock();
        }

        private void dateclock()
        {
            string date = DateTime.Now.ToString("MM/dd/yyyy");
            LabelDate.Text = date;
            string clock = DateTime.Now.ToString("HH:mm");
            LabelTime.Text = clock;
        }


    }
}
