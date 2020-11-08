using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        string oper;
        double a = 0;
        bool validate = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNumbers_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtValor.Text = txtValor.Text + bt.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            label1.Text = "";
            a = 0;
            validate = false;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (validate == true)
            {
                a = a + Convert.ToDouble(txtValor.Text);
                label1.Text = Convert.ToString(a) + "+";
                txtValor.Text = "";
                oper = "+";
            }
            else
            {
                label1.Text = txtValor.Text + btnSum.Text;
                a = Convert.ToDouble(txtValor.Text);
                txtValor.Text = "";
                oper = "+";
                validate = true;
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (validate == true)
            {
                a = a - Convert.ToInt32(txtValor.Text);
                label1.Text = Convert.ToDouble(a) + "-";
                txtValor.Text = "";
                oper = "-";
            }
            else
            {
                label1.Text = txtValor.Text + btnSub.Text;
                a = Convert.ToDouble(txtValor.Text);
                txtValor.Text = "";
                oper = "-";
                validate = true;
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (validate == true)
            {
                a = a * Convert.ToDouble(txtValor.Text);
                label1.Text = Convert.ToString(a) + "x";
                txtValor.Text = "";
                oper = "x";
            }
            else
            {
                label1.Text = txtValor.Text + btnMul.Text;
                a = Convert.ToDouble(txtValor.Text);
                txtValor.Text = "";
                oper = "x";
                validate = true;
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (validate == true)
            {
                a = a / Convert.ToDouble(txtValor.Text);
                label1.Text = Convert.ToString(a) + "/";
                txtValor.Text = "";
                oper = "/";
            }
            else
            {
                label1.Text = txtValor.Text + btnDiv.Text;
                a = Convert.ToDouble(txtValor.Text);
                txtValor.Text = "";
                oper = "/";
                validate = true;
            }
        }

        private void btnEq_Click(object sender, EventArgs e)
        {
            if (oper == "+")
            {
                label1.Text = label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(a + Convert.ToDouble(txtValor.Text));
            }
            else if (oper == "-")
            {
                label1.Text = label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(a - Convert.ToDouble(txtValor.Text));
            }
            else if (oper == "x")
            {
                label1.Text = label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(a * Convert.ToDouble(txtValor.Text));
            }
            else if(oper == "/")
            {
                label1.Text = label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(a / Convert.ToDouble(txtValor.Text));
            }
        }
    }
}
