using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaschetZarplaty
{ 
    public partial class rascetForm : Form
    {
        public rascetForm()
        {
            InitializeComponent();
          lBox1.SelectedIndex = 0;
            rbtn1.Select();
            rbtn4.Select();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int day = 0;
            int itog = 0;
            int save = 0;
            int output = 0;
            if (rbtn2.Checked)
                itog += 2000;
            if (rbtn3.Checked)
                itog += 2000;
            if (rbtn5.Checked)
                itog += 1000;
            if (rbtn6.Checked)
                itog += 2000;
            if (lBox1.SelectedIndex == 0)
                day = 6;
            else day = 8;
            itog += Convert.ToInt32(txtBox1.Text) * Convert.ToInt32(txtBox3.Text) * day;
            save = itog / 100 * Convert.ToInt32(txtBox2.Text);
            output = itog - save;

            resultForm frm2 = new resultForm();
            frm2.Show(this);

            rascetForm frm1 = this.Owner as rascetForm;
            frm2.label1.Text = "Итого " + itog.ToString();
            frm2.label2.Text = "Удержано " + save.ToString();
            frm2.label3.Text = "Выдано " + output.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtBox1.Text.Length != 0 && txtBox2.Text.Length != 0 && txtBox3.Text.Length != 0) 
                { btnRaschet.Enabled = true; }
            else 
                { btnRaschet.Enabled = false; };
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtBox1.Text.Length != 0 && txtBox2.Text.Length != 0 && txtBox3.Text.Length != 0)
            { btnRaschet.Enabled = true; }
            else
            { btnRaschet.Enabled = false; };
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (txtBox1.Text.Length != 0 && txtBox2.Text.Length != 0 && txtBox3.Text.Length != 0)
            { btnRaschet.Enabled = true; }
            else
            { btnRaschet.Enabled = false; };
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBox1.Text = null;
            txtBox2.Text = null;
            txtBox3.Text = null;
        }
    }
}
