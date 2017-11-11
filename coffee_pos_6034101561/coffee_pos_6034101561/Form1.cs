using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_pos_6034101561
{
    public partial class Form1 : Form
    {
        string k_s = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public Form1()
        {
            InitializeComponent();
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        public void kung(String menu,String bath)
        {
            string[] k = { menu, bath };
            var list = new ListViewItem(k);
            listView1.Items.Add(list);
            mi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kung("Esspresso(Hot)", "35");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kung("Esspresso(Ice)", "45");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kung("Esspresso(Frappe)", "50");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kung("Americano(Hot)", "35");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kung("Americano(Ice)", "45");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            kung("Latte(Hot)", "35");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            kung("Latte(Ice)", "45");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            kung("Latte(Frappe)", "50");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            kung("Mocha(Hot)", "35");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            kung("Mocha(Ice)", "45");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            kung("Mocha(Frappe)", "50");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            kung("Cappuccino(Hot)", "35");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            kung("Cappuccino(Ice)", "45");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            kung("Cappuccino(Frappe)", "50");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            kung("GreenTea(Hot)", "20");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            kung("GreenTea(Ice)", "25");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            kung("GreenTea(Frappe)", "30");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            kung("ThaiTea(Hot)", "20");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            kung("ThaiTea(Ice)", "25");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            kung("ThaiTea(Frappe)", "30");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            kung("CoCoa(Hot)", "20");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            kung("CoCoa(Ice)", "25");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kung("CoCoa(Frappe)", "30");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            kung("Milk(Hot)", "20");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            kung("Milk(Ice)", "25");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            kung("Milk(Frappe)", "30");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            kung("MilkTea(Ice)", "25");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            kung("MilkTea(Frappe)", "30");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            kung("LemonTea(Ice)", "25");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            kung("LemonTea(Frappe)", "30");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            kung("Milo(Hot)", "20");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            kung("Milo(Ice)", "25");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            kung("Milo(Frappe)", "30");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            kung("Nescafa(Hot)", "20");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            kung("Nescafa(Ice)", "25");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            kung("Nescafa(Frappe)", "30");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            kung("Nestcatea(Hot)", "20");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            kung("Nestcatea(Ice)", "25");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            kung("Nestcatea(Frappe)", "30");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            kung("Italian Soda", "25");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            kung("Red lime Soda", "25");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            kung("Honey lime Soda", "25");
        }


        double price;
        public string[] mi()
        {
            price = 0;
            string[] Ar = new string[listView1.Items.Count];
            int item = listView1.Items.Count;
            for(int i = 0; i < item ; i++)
            {
                price += double.Parse(listView1.Items[i].SubItems[1].Text);
                Ar[i] = listView1.Items[i].SubItems[0].Text.ToString();
            }
            label26.Text = price.ToString();
            return Ar;
        }

        public string[] mil()
        {
            string[] Ar = new string[listView1.Items.Count];
            int item = listView1.Items.Count;
            for (int i = 0; i < item; i++)
            {
                Ar[i] = listView1.Items[i].SubItems[1].Text.ToString();
            }
            return Ar;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Controls.Remove(Payment);
        }

        public void fa()
        {
            string[] ku = mi();
            string[] ng = mil();
            string pim = "kung_coffee" + DateTime.Now.ToString("hhmmss_dd_mm_yyyy");
            string bill = "kung_coffee";
            bill += "\r\n" + DateTime.Now.ToString("hh:mm:ss") + "\r\n" + DateTime.Now.ToString("dd/mm/yyyy") + "\r\n" + "\r\n";
            bill += "Menu" + "\r\n";
            for (int i = 0; i < listView1.Items.Count;i++)
            {
                bill += ku[i] + new String(' ', 20) + ng[i] +  "Bath" + "\r\n";
            }
            bill += "\r\n";
            bill += "Total Price : " + label26.Text;
            System.IO.File.WriteAllText(k_s + @"\" + pim + ".txt", bill);
            lb1.Text += bill + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "Save File at" + k_s + @"\" + pim + ".txt";
        }

        bool ok=false;
        private void button43_Click(object sender, EventArgs e)
        {
            if (ok == false)
            {
                tabControl1.TabPages.Insert(1, Payment);
                ok = true;
                tabControl1.SelectedTab = Payment;
            }
            else tabControl1.SelectedTab = Payment;

            if (listView1.Items.Count > 0)
                fa();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ok = false;
            tabControl1.Controls.Remove(Payment);
            label26.Text = "";
        }
    }
}
