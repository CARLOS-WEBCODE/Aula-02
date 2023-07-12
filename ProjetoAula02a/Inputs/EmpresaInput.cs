using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula02a.Inputs
{
    /// <summary>
    /// Classe para leitura de dados de empresa
    /// </summary>
    public class EmpresaInput
    {
        /// <summary>
        /// Método para ler o valor do nome fantasia da empresa
        /// </summary>
        /// <returns>Texto</returns>
        public static string LerNomeFantasia()
        {
            Console.Write("Informe o nome fantasia da empresa...: ");
            return Console.ReadLine();
        }

        /// <summary>
        /// Método para ler o valor do nome da razão social da empresa
        /// </summary>
        /// <returns>Texto</returns>
        public static string LerRazaoSocial()
        {
            Console.Write("Informe a razão social da empresa...: ");
            return Console.ReadLine();
        }
        /// <summary>
        /// Método para ler o valor do cnpj da empresa
        /// </summary>
        /// <returns>Texto</returns>
        public static string LerCnpj()
        {
            Console.Write("Informe o cnpj da empresa...: ");
            return Console.ReadLine();
        }

    }
}
