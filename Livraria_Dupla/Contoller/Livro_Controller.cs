using Livraria_Dupla.Model;
using Livraria_Dupla.View;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Livraria_Dupla.Contoller
{
    internal class Livro_Controller
    {
        public void CadastroLivro()
        {
            SqlConnection cn = new SqlConnection(conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pCadastroLivro", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("Livro", Livros.Livro1);
                cmd.Parameters.AddWithValue("Editora", Livros.Editora1);
                cmd.Parameters.AddWithValue("Preco", Livros.Preco1);

                SqlParameter nv = cmd.Parameters.Add("Idlivro", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Deseja cadastrar novamente?",
                   "Livro Cadastrado com sucesso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    Cadastro_Livro cadastro = new Cadastro_Livro();
                    cadastro.AbirCadastro();
                }
                else
                {
                    return;

                }


            }
            catch (Exception)
            {

                throw;
            }

        }

        public void BuscarLivro()
        {
            SqlConnection cn = new SqlConnection(conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pBuscarLivro", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@Idlivro", Livros.ID1);
                cn.Open();

                var registros = cmd.ExecuteReader();

                if (registros.Read())
                {
                    Livros.ID1 = Convert.ToInt32(registros["Idlivro"]);
                    Livros.Livro1 = (string)registros["Livro"];
                    Livros.Editora1 = (string)registros["Editora"];
                    Livros.Preco1 = (string)registros["Preco"];
                }

                else
                {
                    Livros.ID1 = 0;
                    Livros.Livro1 = "";
                    Livros.Editora1 = "";
                    Livros.Preco1 = "";
                    MessageBox.Show("Livro não encontrado", "Pesquisar Código");




                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeletarLivro()
        {
            SqlConnection cn = new SqlConnection(conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pDeletarLivro", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@Idlivro", Livros.ID1);
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Deseja Deletar novamente", "Livro deletado com sucesso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    Deletar_Livro del = new Deletar_Livro();
                    del.AbrirDeletar();

                }
            }

            catch (Exception)
            {
                throw;
            }
        }

    }

}

