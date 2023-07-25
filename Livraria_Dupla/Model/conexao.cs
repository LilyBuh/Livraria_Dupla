using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria_Dupla.Model
{
    internal class conexao
    {
        public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bruno.vscorreia\source\repos\Livraria_Dupla\Livraria_Dupla\Model\Livrobd.mdf;Integrated Security=True";

        }

    }
}
