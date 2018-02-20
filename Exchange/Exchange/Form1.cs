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

        public static double diff = 0;
        

        private void list_from_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void button_Result_Click(object sender, EventArgs e)
        {
            double inner = Double.Parse(text_Insert.Text);
            string sel1 = combo_From.SelectedItem.ToString();
            string sel2 = combo_To.SelectedItem.ToString();
            switch (sel1)
            {
                case "UAH": diff = 1;
                    break;
                case "USD": diff = 27;
                    break;
                case "EUR": diff = 35;
                    break;
                case "RUB": diff = 0.42;
                    break;
                case "HUF": diff = 0.1;
                    break;
            }
            double res = inner * diff;
            switch (sel2)
            {
                case "UAH":
                    diff = 1;
                    break;
                case "USD":
                    diff = 27;
                    break;
                case "EUR":
                    diff = 35;
                    break;
                case "RUB":
                    diff = 0.42;
                    break;
                case "HUF":
                    diff = 0.1;
                    break;
            }
            double result = res / diff;
            text_Result.Text = result.ToString();
        }
        

        public void button_Clear_Click(object sender, EventArgs e)
        {
            text_Insert.Text = "";
            text_Result.Text = "";
        }

        public void button_Add_Click(object sender, EventArgs e)
        {
            Form2 FormAdd = new Form2();
            FormAdd.ShowDialog();
            string s = FormAdd.textCurrency.Text;
            combo_From.Items.Add(s);
            combo_To.Items.Add(s);
            diff = Double.Parse(FormAdd.textDiff.Text);
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            var sel1 = combo_From.SelectedItem;
            var sel2 = combo_To.SelectedItem;
            combo_From.Items.Remove(sel1);
            combo_To.Items.Remove(sel2);
        }
    }
}
