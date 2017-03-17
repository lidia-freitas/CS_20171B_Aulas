using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
            lblDataAtual.Text = DateTime.Now.ToString();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente cadCliente = new frmCadastroCliente();
            cadCliente.MdiParent = this;
            cadCliente.Show();
        }
    }
}
