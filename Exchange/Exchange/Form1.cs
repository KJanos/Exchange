using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exchange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void list_from_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Result_Click(object sender, EventArgs e)
        {
            double temp = Double.Parse(text_Insert.Text);
            double result = 0;
            if (combo_From.SelectedItem == "UAH")
            {
                if (combo_To.SelectedItem == "UAH")
                {
                    result = temp; 
                }
                else if (combo_To.SelectedItem == "USD")
                {
                    result =temp * 26.8 ;
                }
                else if (combo_To.SelectedItem == "EUR")
                {
                    result = temp * 33.4;
                }
                else if (combo_To.SelectedItem == "RUB")
                {
                    result = temp * 0.42;
                }
                else if (combo_To.SelectedItem == "HUF")
                {
                    result = temp * 10.6;
                }
            }



            if (combo_From.SelectedItem == "USD")
            {
                if (combo_To.SelectedItem == "UAH")
                {
                    result = temp / 26.8;
                }
                else if (combo_To.SelectedItem == "USD")
                {
                    result = temp;
                }
                else if (combo_To.SelectedItem == "EUR")
                {
                    result = temp / 0.8;
                }
                else if (combo_To.SelectedItem == "RUB")
                {
                    result = temp * 56;
                }
                else if (combo_To.SelectedItem == "HUF")
                {
                    result = temp * 265;
                }
            }


            if (combo_From.SelectedItem == "EUR")
            {
                if (combo_To.SelectedItem == "UAH")
                {
                    result = temp / 33.8;
                }
                else if (combo_To.SelectedItem == "USD")
                {
                    result = temp * 0.8;
                }
                else if (combo_To.SelectedItem == "EUR")
                {
                    result = temp;
                }
                else if (combo_To.SelectedItem == "RUB")
                {
                    result = temp * 70;
                }
                else if (combo_To.SelectedItem == "HUF")
                {
                    result = temp * 300;
                }
            }


            if (combo_From.SelectedItem == "RUB")
            {
                if (combo_To.SelectedItem == "UAH")
                {
                    result = temp / 0.42;
                }
                else if (combo_To.SelectedItem == "USD")
                {
                    result = temp / 56;
                }
                else if (combo_To.SelectedItem == "EUR")
                {
                    result = temp / 42;
                }
                else if (combo_To.SelectedItem == "RUB")
                {
                    result = temp;
                }
                else if (combo_To.SelectedItem == "HUF")
                {
                    result = temp * 4.4;
                }
            }


            if (combo_From.SelectedItem == "HUF")
            {
                if (combo_To.SelectedItem == "UAH")
                {
                    result = temp / 10.6;
                }
                else if (combo_To.SelectedItem == "USD")
                {
                    result = temp / 265;
                }
                else if (combo_To.SelectedItem == "EUR")
                {
                    result = temp / 300;
                }
                else if (combo_To.SelectedItem == "RUB")
                {
                    result = temp / 4.4;
                }
                else if (combo_To.SelectedItem == "HUF")
                {
                    result = temp;
                }
            }
            text_Result.Text = Convert.ToString(result);
        }
    }
}
