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
            Double change;
            change = Convert.ToDouble(textBoxCash.Text) - Convert.ToDouble(TextBoxTotal.Text);
            textBoxChange.Text = change.ToString();
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               "\tThe King Barber\n" +
               "-------------------------------------------------------------\n\n" +

              "Type of customer: " + customer_sex(type) + "\n" +
               "Services Checked: \n" + Checked_Services() + "\n" +
               "Total without IVA \t\t" + TextBoxPrice.Text + "\n" +
               "IVA (" + comboBoxIVA.Text + "%)\t\t\t" + TextBoxTotal.Text + "\n" +
               "Total with IVA \t\t" + TextBoxIVA.Text + "\n\n" +

              "Paid out\t\t\t" + textBoxCash.Text + "\n" +
               "Change\t\t\t" + textBoxChange.Text + "\n\n" +

              "-------------------------------------------------------------");
        }

        private String customer_sex(int type_sex)
        {
            String sex;

            if (comboBoxIVA.SelectedIndex == 0) type_sex = 1;

            if (type_sex == 1)
            {
                sex = "\t\tWoman";
                return sex;
            }

            else if (type_sex == 2)
            {
                sex = "\t\tMan";
                return sex;
            }

            else if (type_sex == 3)
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
    }
}
