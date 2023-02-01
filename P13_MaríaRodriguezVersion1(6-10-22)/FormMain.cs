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
        //global variables

        int type; //type 1 = W  type 2 = M  type 3 = Kid
        int count = 0;
        int Iva;

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

        private void calculate()
        {

            double price = 0;
            

            //type
            if (RadioButtonWomen.Checked) type = 1;
            else if (RadioButtonMen.Checked) type = 2;
            else if (RadioButtonKids.Checked) type = 3;

            //services

            if (type == 1)
            {
                if (CheckBoxWash.Checked)price += 8;
                if (CheckBoxCutAndHairstyle.Checked) price += 22;
                if (CheckBoxHairstyle.Checked) price += 10;
                if (CheckBoxDye.Checked) price += 35;
                if (CheckBoxPermanent.Checked) price += 45;
                CheckBoxPermanent.Visible = true;
                TextBoxService.Text = Convert.ToDouble(count++).ToString();
            }
            else if (type == 2)
            {
                if (CheckBoxWash.Checked) price += 6;
                if (CheckBoxCutAndHairstyle.Checked) price += 14;
                if (CheckBoxHairstyle.Checked) price += 5;
                if (CheckBoxDye.Checked) price += 30;
                if (CheckBoxPermanent.Checked) price += 40;
                CheckBoxPermanent.Visible = true;
                TextBoxService.Text = Convert.ToDouble(count++).ToString();
            }
            else if (type == 3)
            {
                if (CheckBoxWash.Checked) price += 6;
                if (CheckBoxCutAndHairstyle.Checked) price += 12;
                if (CheckBoxHairstyle.Checked) price += 5;
                if (CheckBoxDye.Checked) price += 20;
                CheckBoxPermanent.Visible=false;
                TextBoxService.Text = Convert.ToDouble(count++).ToString();
            }
            TextBoxPrice.Text = price.ToString();
        }


        private void dateclock()
        {
            string date = DateTime.Now.ToString("MM/dd/yyyy");
            LabelDate.Text = date;
            string clock = DateTime.Now.ToString("HH:mm");
            LabelTime.Text = clock;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            dateclock();
        }

        private void Gender(object sender, EventArgs e)
        {
            calculate();
        }

        private void Services(object sender, EventArgs e)
        {
            calculate();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //Iva = (comboBoxIVA * calculate / 100);
        }
    }
}
