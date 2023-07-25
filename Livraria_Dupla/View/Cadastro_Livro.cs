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
    public partial class Cadastro_Livro : Form
    {
        public Cadastro_Livro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Livros.Livro1 = txt_livro.Text;
            Livros.Editora1 = txt_editora.Text;
            Livros.Preco1 = txt_preco.Text;

            Livro_Controller mLivro = new Livro_Controller();
            mLivro.CadastroLivro();
        }
        public void AbirCadastro()
        {
            this.ShowDialog();
        }

    }
}
