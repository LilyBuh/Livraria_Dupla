using Livraria_Dupla.Contoller;
using Livraria_Dupla.Model;
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
    public partial class Deletar_Livro : Form
    {
        public Deletar_Livro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Livros.ID1 = Convert.ToInt32(txtCod.Text);

            Livro_Controller mLivros = new Livro_Controller();
            mLivros.BuscarLivro();

            txtlivro.Text = Livros.Livro1;
            txteditora.Text = Livros.Editora1;
            txtpreco.Text = Livros.Preco1;

        }

        public void AbrirDeletar()
        {
            this.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Livros.ID1 = Convert.ToInt32(txtCod.Text);

            Livro_Controller mLivro = new Livro_Controller();
            mLivro.DeletarLivro();

        }
    }
}
