using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula02a.Entities
{
    /// <summary>
    /// Classe de modelo de entidade
    /// </summary>
    public class Empresa
    {
        public Guid Id { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }

        /// <summary>
        /// Lista de funcionários pertencente a Empresa
        /// </summary>
        public List<Funcionario> Funcionarios { get; set; }
    }
}
