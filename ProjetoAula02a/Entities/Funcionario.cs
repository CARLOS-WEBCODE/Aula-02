using ProjetoAula02a.Entities.Enums;
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
    public class Funcionario : Pessoa
    {
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public DateTime DataAdmissao { get; set; }

        /// <summary>
        /// Tipo de contratação do funcionário
        /// </summary>
        public TipoDeContratacao TipoDeContratacao { get; set; }

    }
}
