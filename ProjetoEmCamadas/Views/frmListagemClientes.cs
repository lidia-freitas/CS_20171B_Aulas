using Controllers;
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
    public partial class frmListagemClientes : Form
    {
        public frmListagemClientes()
        {
            InitializeComponent();
        }

        private void frmListagemClientes_Load(object sender, EventArgs e)
        {
            ClientesController cliController = new ClientesController();
            dgvClientes.DataSource = cliController.Listar();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idSelecionado = Convert.ToInt32(((DataGridView)sender).Rows[e.RowIndex].Cells[3].Value);
            frmDetalhesCliente telaDetalhes = new frmDetalhesCliente(idSelecionado);
        }

        private void dgvClientes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        
    }
}
