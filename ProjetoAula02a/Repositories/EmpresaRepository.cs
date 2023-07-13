using Newtonsoft.Json;
using ProjetoAula02a.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula02a.Repositories
{
    /// <summary>
    /// Classe de repositorio de dados para Empresa
    /// </summary>
    public class EmpresaRepository
    {/// <summary>
    /// Método para exportar dados de Empresa para arquivo JSON
    /// </summary>
    /// <param name="empresa">Objeto da classe de entidade Empresa</param>
        public void ExportarDados(Empresa empresa)
        {
            //Serializar os dados da empresa para o formato JSON
            var json = JsonConvert.SerializeObject(empresa, Formatting.Indented);

            //abrindo um arquivo modo de escrita....
            var streamWriter = new StreamWriter($"c:\\temp\\empresa_{empresa.Id}.json");
            streamWriter.WriteLine(json); //escrevendo os dados do arquivo (json)
            streamWriter.Flush(); //salvando
            streamWriter.Close(); //fechando
        }
    }
}
