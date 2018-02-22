using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exchange.Managers;
namespace Exchange
{
    public partial class Form1 : Form
    {
        ConvertorManager manager;
        List<CurrencyModel> items;

        public Form1()
        {
            InitializeComponent();

            manager = new ConvertorManager();
            items = manager.GetItems();
            
            for (int i = 0; i < items.Count; i++)
            {
                combo_From.Items.Add(items[i].Name);
                combo_To.Items.Add(items[i].Name);
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
                int from = combo_From.SelectedIndex;
                int to = combo_To.SelectedIndex;

                double res = manager.Convert(from, to, inner);
                text_Result.Text = res.ToString();
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
                string name = FormAdd.textCurrency.Text;
                diff = Double.Parse(FormAdd.textDiff.Text);
                CurrencyModel newCurrency = new CurrencyModel(name, diff);
                manager.AddItem(newCurrency);

                combo_From.Items.Add(name);
                combo_To.Items.Add(name);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            string indexItem = combo_From.SelectedIndex.ToString();
            manager.RemoveItem(Convert.ToInt32(indexItem));
            combo_From.Items.Remove(indexItem);
        }
    }
}
