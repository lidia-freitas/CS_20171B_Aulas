using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula0803_WF
{
    public partial class frmTelaInicial : Form
    {

        private double result;
        
        public frmTelaInicial()
        {
            InitializeComponent();
        }

        private void btnClick(object sender, EventArgs e)
        {

            var btn = sender as Button;

            if (btn.Text != "+" || btn.Text != "-" || btn.Text != "x" || btn.Text != "÷")
            {                
                txtDisplay.Text += btn.Text;
            }
            else
            {
                btnOpClick(btn.Text, btn);
            }
        }

        private void btnOpClick(string op, btn)
        {
            var operation = op;
            var btn = ;

            switch (op)
            {
                case "+":
                    result += Convert.ToInt32(btn.Text);
                    break;

                case "-":
                    result -= Convert.ToInt32(btn.Text);
                    break;

                case "÷":
                    result /= Convert.ToInt32(btn.Text);
                    break;

                case "x":
                    result *= Convert.ToInt32(btn.Text);
                    break;                
            }
        }

       
        private void calcular(object sender, EventArgs e)
        {
            int result = Eval(txtDisplay.Text);
        }
    }
}
