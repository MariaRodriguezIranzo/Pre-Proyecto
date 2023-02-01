using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P13_MaríaRodriguez
{
    public partial class Form : System.Windows.Forms.Form
    {
        //global variables

        int type; //type 1 = W  type 2 = M  type 3 = Kid

        //constructor

        public Form()
        {
            InitializeComponent();
            initConfig();
        }
        private void initConfig()
        {
            DataClass.initMatrix();
            comboBoxIVA.SelectedIndex = 3;
            RadioButtonWomen.Checked = true;

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        /*private void calculate()
        {
            int count = 0;

            double price = 0;
            
            //type
            if (RadioButtonWomen.Checked) type = 1;
            else if (RadioButtonMen.Checked) type = 2;
            else if (RadioButtonKids.Checked) type = 3;
            
            //services

            if (type == 1)
            {
                if (CheckBoxWash.Checked)
                {
                    price += 8;
                    count++;
                }
                if (CheckBoxCutAndHairstyle.Checked)
                {
                    price += 22;
                    count++;
                }
                if (CheckBoxHairstyle.Checked)
                {
                    price += 10;
                    count++;
                }
                if (CheckBoxDye.Checked)
                {
                    price += 35;
                    count++;
                }
                if (CheckBoxPermanent.Checked)
                {
                    price += 45;
                    count++;
                }
                CheckBoxPermanent.Visible = true;
                     
            }
            else if (type == 2)
            {
                if (CheckBoxWash.Checked) {
                    price += 6;
                    count++;
                }
                if (CheckBoxCutAndHairstyle.Checked)
                {
                    price += 14;
                    count++;
                }
                if (CheckBoxHairstyle.Checked) {
                    price += 5;
                    count++;
                }
                if (CheckBoxDye.Checked)
                {
                    price += 30;
                    count++;
                }
                if (CheckBoxPermanent.Checked) {
                    price += 40;
                    count++;
                }
                CheckBoxPermanent.Visible = true;
                   
            }
            else if (type == 3)
            {
                if (CheckBoxWash.Checked)
                {
                    price += 6;
                    count++;
                }
                if (CheckBoxCutAndHairstyle.Checked) {
                    price += 12;
                    count++;
                }
                if (CheckBoxHairstyle.Checked) {
                    price += 5;
                    count++;
                }
                if (CheckBoxDye.Checked)
                {
                    price += 20;
                    count++;
                }
                CheckBoxPermanent.Visible=false;
                
            }

           TextBoxPrice.Text = price.ToString();
           TextBoxService.Text = count.ToString();
        }*/

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

       /* private void Gender(object sender, EventArgs e)
        {
            calculate();
        }

        private void Services(object sender, EventArgs e)
        {
            calculate();
        }
       */
        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            Double Iva;
            Iva = Convert.ToDouble(comboBoxIVA.Text) * Convert.ToDouble(TextBoxPrice.Text) / 100;
            TextBoxIVA.Text = Iva.ToString();
            Double Total;
            Total = Convert.ToDouble(TextBoxPrice.Text) + Convert.ToDouble(TextBoxIVA.Text);
            TextBoxTotal.Text = Total.ToString();
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            try {
                Double change;
                change = Convert.ToDouble(textBoxCash.Text) - Convert.ToDouble(TextBoxTotal.Text);
                textBoxChange.Text = change.ToString();
               
            }catch {
            }
            
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               "\tThe King Barber\n" +
               "-------------------------------------------------------------\n\n" +

              "Type of customer: " + customer_sex() + "\n" +
               "Services Checked: \n" + Checked_Services() + "\n" +
               "Total without IVA \t\t" + TextBoxPrice.Text + "\n" +
               "IVA (" + comboBoxIVA.Text + "%)\t\t\t" + TextBoxTotal.Text + "\n" +
               "Total with IVA \t\t" + TextBoxIVA.Text + "\n\n" +

              "Paid out\t\t\t" + textBoxCash.Text + "\n" +
               "Change\t\t\t" + textBoxChange.Text + "\n\n" +

              "-------------------------------------------------------------");
        }

        private String customer_sex()
        {
            String sex;
            if (RadioButtonWomen.Checked) type = 1;
            else if (RadioButtonMen.Checked) type = 2;
            else if (RadioButtonKids.Checked) type = 3;

            if (comboBoxIVA.SelectedIndex == 0) type = 0;

            if (type == 1)
            {
                sex = "\t\tWoman";
                return sex;
            }

            else if (type == 2)
            {
                sex = "\t\tMan";
                return sex;
            }

            else if (type == 3)
            {
                sex = "\t\tKid";
                return sex;
            }
            else
            {
                return "\t\tWoman";
            }

        }

        private String Checked_Services()
        {

            String Services = "";

            if (CheckBoxWash.Checked == true)
            {
                Services += "\t\t\tWash\n";
            }
            if (CheckBoxCutAndHairstyle.Checked == true)
            {
                Services += "\t\t\tCut and Hairstyle\n";
            }
            if (CheckBoxHairstyle.Checked == true)
            {
                Services += "\t\t\tHairstyle\n";
            }
            if (CheckBoxDye.Checked == true)
            {
                Services += "\t\t\tDye\n";
            }
            if (CheckBoxPermanent.Checked == true)
            {
                Services += "\t\t\tPermanent\n";
            }
            if (CheckBoxWash.Checked != true && CheckBoxCutAndHairstyle.Checked != true && CheckBoxHairstyle.Checked != true && CheckBoxDye.Checked != true && CheckBoxPermanent.Checked != true)
            {
                Services = "\t\t\tNo services Checked";
            }

            return Services;
        }

        private void CalculateService(object sender, EventArgs e)
        {
            int row = 0, col = 0, price = 0, service= 0; 
            CalculateRowCol(ref row, ref col, ref price, ref service);
            //MessageBox.Show(" " + row + " " + col + " " + DataClass.matrixPrice[col, row] + ":" + price);
            TextBoxPrice.Text=price.ToString();
            double iva = Convert.ToDouble(comboBoxIVA.SelectedItem.ToString()) / 100 + 1;
            double total = price * iva;
            TextBoxTotal.Text = (total.ToString());
            TextBoxService.Text = (service.ToString());
        }
        private void calculatePrice(int row, int col, ref int price)
        {
            price += DataClass.matrixPrice[row, col];
        }
        private void CalculateRowCol(ref int row, ref int col, ref int price, ref int service)
        {
            row = 0; col = 0; price = 0;service = 0;

            if (RadioButtonKids.Checked) col = 2;
            else if (RadioButtonWomen.Checked) col = 0;
            else if (RadioButtonMen.Checked) col = 1;
           
            if (CheckBoxWash.Checked) {
                service++;
                row = 0;
                calculatePrice(row, col, ref price);
            }
            if (CheckBoxCutAndHairstyle.Checked)
            {
                service++;
                row = 1;
                calculatePrice( row, col,ref price);
                
            }
            if (CheckBoxHairstyle.Checked)
            {
                service++;
                row = 2;
                calculatePrice(row, col, ref price);
            }
            if (CheckBoxDye.Checked)
            {
                service++;
                row = 3;
                calculatePrice(row, col, ref price);
            }
            if (CheckBoxPermanent.Checked)
            {
                service++;
                row = 4;
                calculatePrice(row, col, ref price);
            }
            if (RadioButtonKids.Checked)
            {
                CheckBoxPermanent.Visible = false;
                CheckBoxPermanent.Enabled = false;
                service--;
            }
            else
            {
                CheckBoxPermanent.Visible = true;
                CheckBoxPermanent.Enabled = true;
                
            }
        }

        private void PictureBoxCalculator_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }
    }
}
