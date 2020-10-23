using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt6windowform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
            ds.Add(4);
            ds.Add(46.8);
            ds.Add(95);
            ds.Add(2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát  ??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.Alt && e.KeyCode == Keys.H)
            {
                button5.PerformClick();
            }
            if (e.Alt && e.KeyCode == Keys.T)
            {
                button1.PerformClick();
            }
        }
        List<double> ds = new List<double>();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Hãy nhập số vào trước", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                listBox1.Items.Add(textBox1.Text);
                ds.Add(double.Parse(textBox1.Text));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            double[] mang = new double[100];
            mang =ds.ToArray();
            double max = mang[0];
            for(int i=0;i<mang.Length;i++)
            {
                if (mang[i] > max)
                    max = mang[i];
            }
            label2.Text =" Giá trị lớn nhất của dãy  "+ max.ToString();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            label2.Visible = false;
            listBox1.Items.Clear();
            listBox1.Items.Add(4);
            listBox1.Items.Add(46.8);
            listBox1.Items.Add(95);
            listBox1.Items.Add(2);
        }
    }
}
