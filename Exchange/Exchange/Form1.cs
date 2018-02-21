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
        List<CurrencyInfo> Currency = new List<CurrencyInfo>() { };
        public Form1()
        {
            InitializeComponent();
            CurrencyInfo UAH = new CurrencyInfo("UAH", 1);
            CurrencyInfo EUR = new CurrencyInfo("EUR", 35);
            CurrencyInfo USD = new CurrencyInfo("USD", 27);
            CurrencyInfo RUB = new CurrencyInfo("RUB", 0.42);
            CurrencyInfo HUF = new CurrencyInfo("HUF", 0.107);
            Currency.Add(UAH);
            Currency.Add(EUR);
            Currency.Add(USD);
            Currency.Add(RUB);
            Currency.Add(HUF);
            for (int i = 0; i < Currency.Count; i++)
            {
                combo_From.Items.Add(Currency[i].Name);
                combo_To.Items.Add(Currency[i].Name);
            }
        }
        


        public static double diff = 0;
        


        private void list_from_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void button_Result_Click(object sender, EventArgs e)
        {
            try
            {
                double inner = Double.Parse(text_Insert.Text);
                int k = combo_From.SelectedIndex;
                diff = Currency[k].diff;
                double res = inner * diff;
                k = combo_To.SelectedIndex;
                diff = Currency[k].diff;
                double result = res / diff;
                text_Result.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        

        public void button_Clear_Click(object sender, EventArgs e)
        {
            text_Insert.Text = "";
            text_Result.Text = "";
        }

        public void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 FormAdd = new Form2();
                FormAdd.ShowDialog();
                string s = FormAdd.textCurrency.Text;
                diff = Double.Parse(FormAdd.textDiff.Text);
                CurrencyInfo ADD = new CurrencyInfo(s, diff);
                Currency.Add(ADD);
                int k = Currency.Count - 1;
                combo_From.Items.Add(Currency[k].Name);
                combo_To.Items.Add(Currency[k].Name);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
