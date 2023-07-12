using ProjetoAula02a.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ProjetoAula02a.Inputs
{
    /// <summary>
    /// Classe para leitura de dados de funcionário
    /// </summary>
    public class FuncionarioInput
    {
        /// <summary>
        /// Método para ler o valor do nome do funcionário
        /// </summary>
        /// <returns>Texto</returns>
        public static string LerNome()
        {
            Console.Write("Informe o nome do funcionário.......: ");
            return Console.ReadLine();
        }
        /// <summary>
        /// Método para ler o valor do cpf do funcionário
        /// </summary>
        /// <returns>Texto</returns>
        public static string LerCpf()
        {
            Console.Write("Informe o cpf do funcionário........: ");
            return Console.ReadLine();
        }
        /// <summary>
        /// Método para ler o valor da matrícula do funcionário
        /// </summary>
        /// <returns>Texto</returns>
        public static string LerMatricula()
        {
            Console.Write("Informe a matrícula do funcionário..: ");
            return Console.ReadLine();
        }
        /// <summary>
        /// Método para ler o valor da data de admissão do funcionário
        /// </summary>
        /// <returns>Data</returns>
        public static DateTime LerDataAdmissao()
        {
            Console.Write("Informe a data de admissão..........: ");
            return DateTime.Parse(Console.ReadLine());
        }
        /// <summary>
        /// Método para ler o tipo de contratação do funcionário
        /// </summary>
        /// <returns>Enum</returns>
        public static TipoDeContratacao LerTipoDeContratacao()
        {
            Console.Write("(1) ESTÁGIO\n");
            Console.Write("(2) CLT\n");
            Console.Write("(3) TERCEIRIZADO\n");
            Console.Write("Informe o tipo de contratação......: ");
            var opcao = int.Parse(Console.ReadLine());

            switch(opcao)
            {
                case 1:
                    return TipoDeContratacao.Estagio;
                case 2:
                    return TipoDeContratacao.CLT;
                case 3:
                    return TipoDeContratacao.Terceirizado;
                default:
                    //nenhum dos anteriores
                    throw new Exception("Tipo de contratação inválido.");
            }
        }
    }
}
