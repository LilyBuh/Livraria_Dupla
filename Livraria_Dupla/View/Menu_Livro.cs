using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria_Dupla.View
{
    public partial class Menu_Livro : Form
    {
        public Menu_Livro()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_Livro cadastro = new Cadastro_Livro();
            cadastro.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buscar_Livro buscar = new Buscar_Livro();
            buscar.Show();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deletar_Livro deletar = new Deletar_Livro();
            deletar.Show();
        }
    }
}
