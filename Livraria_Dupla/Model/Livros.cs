using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria_Dupla.Model
{
    internal class Livros
    {

        private static int ID;
        private static string Livro;
        private static string Editora;
        private static string Preco;

        public static int ID1 { get => ID; set => ID = value; }
        public static string Livro1 { get => Livro; set => Livro = value; }
        public static string Editora1 { get => Editora; set => Editora = value; }
        public static string Preco1 { get => Preco; set => Preco = value; }
    }
}
