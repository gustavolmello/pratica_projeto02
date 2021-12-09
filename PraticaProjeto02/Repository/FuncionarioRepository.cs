using Newtonsoft.Json;
using PraticaProjeto02.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticaProjeto02.Repository
{
    public class FuncionarioRepository
    {
        //método para receber um objeto do tipo Funcionario
        //e gravar os seus dados em um arquivo de extensão .JSON
        public void ExportarJSON(Funcionario funcionario)
        {
            //gerando o caminho do arquivo que será gravado..
            var path = $"c:\\temp\\funcionario_{funcionario.IdFuncionario}.json";

            //abrindo o arquivo para gravação..
            var streamWriter = new StreamWriter(path);

            //serializando os dados do funcionario para JSON..
            var json = JsonConvert.SerializeObject(funcionario
                );

            //escrevendo no arquivo
            streamWriter.WriteLine(json);

            //fechando o arquivo
            streamWriter.Close();
        }
    }
}

