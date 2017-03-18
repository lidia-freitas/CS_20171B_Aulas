using Models;
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
    public partial class frmDetalhesCliente : Form
    {
        public frmDetalhesCliente(Cliente cliente)
        {
            InitializeComponent();
            lblId.Text = cliente.ClienteID.ToString();
            lblNome.Text = cliente.Nome;
            lblCpf.Text = cliente.Cpf;
        }
    }
}
