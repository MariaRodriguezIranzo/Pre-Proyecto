using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            Class1.initMatrix();
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

        private void CalculateService(object sender, EventArgs e)
        {
            int row = 0, col = 0, price = 0;
            CalculateRowCol(ref row, ref col, ref price);
            MessageBox.Show(" " + row + " " + col + " " + Class1.matrixPrice[col, row]+":"+price);
        }
        private void calculatePrice(int row, int col, ref int price)
        {
            price += Class1.matrixPrice[row, col];
        }
        private void CalculateRowCol(ref int row, ref int col, ref int price)
        {

            row = 0; col = 0; price = 0;
            if (RadioButtonKids.Checked) col = 2;
            else if (RadioButtonWomen.Checked) col = 0;
            else if (RadioButtonMen.Checked) col = 1;
            //-------------------------------------------------
            if (CheckBoxWash.Checked) calculatePrice(0, col, ref price);
            if (CheckBoxCutAndHairstyle.Checked) calculatePrice(1, col, ref price);
            if (CheckBoxHairstyle.Checked) calculatePrice(2, col, ref price);
            if (CheckBoxDye.Checked) calculatePrice(3, col, ref price);
            if (CheckBoxPermanent.Checked) calculatePrice(4, col, ref price);
            }
        }
    }

