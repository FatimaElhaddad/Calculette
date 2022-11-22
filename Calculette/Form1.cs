using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculette
{
    public partial class Form1 : Form
    {
        double res = 0;
        string operationPerform = "";
        bool isOperation=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_click(object sender, EventArgs e)
        {
            if ((textBox_result.Text == "0") || (isOperation)) //pour qu'il efface le nbr avent d'ajouter l'operant
                textBox_result.Clear();
            isOperation = false;  //apres chaque nbr il faut etre false
            Button btn = (Button)sender;
            if (btn.Text == ".")//pour avoir le droit d'utiliser "." une seule fois
            {
                if (!textBox_result.Text.Contains("."))
                    textBox_result.Text = textBox_result.Text + btn.Text;
            }
            else
            textBox_result.Text = textBox_result.Text + btn.Text;

        }

        private void operationClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (res != 0)
            {
                equalbtn.PerformClick();
                operationPerform = btn.Text;
                labelOperation.Text = res + " " + operationPerform;
                isOperation = true;
            }
            else { 
            operationPerform = btn.Text;
            labelOperation.Text = res + " " + operationPerform;
            res = double.Parse(textBox_result.Text);
            isOperation = true;
            }
        }

        private void Cbtn_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";

        }

        private void CEbtn_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            res = 0;
        }

        private void equalbtn_Click(object sender, EventArgs e)
        {
            switch (operationPerform)
            {
                case "+":
                    textBox_result.Text = (res + double.Parse(textBox_result.Text)).ToString();
                    break;
                case "-":
                    textBox_result.Text = (res - double.Parse(textBox_result.Text)).ToString();
                    break;
                case "*":
                    textBox_result.Text = (res * double.Parse(textBox_result.Text)).ToString();
                    break;
                case "/":
                    textBox_result.Text = (res / double.Parse(textBox_result.Text)).ToString();
                    break;
                default:
                    break;
            }
            res=double.Parse(textBox_result.Text);
            labelOperation.Text = "";
        }
    }
}
