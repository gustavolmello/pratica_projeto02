using PraticaProjeto02.Entities;
using PraticaProjeto02.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticaProjeto02.Controllers
{
    public class FuncionarioController
    {
        //método para fazer com que o usuario do prompt (DOS)
        //entre com os dados do funcionario..
        public void CadastrarFuncionario()
        {
            Console.WriteLine("\n --- CADASTRO DE FUNCIONARIO --- \n");

            //criando um objeto da classe Funcionario (instância)
            var funcionario = new Funcionario();

            //instanciando os relacionamentos contidos em funcionario
            funcionario.Setor = new Setor(); //inicializando!
            funcionario.Dependentes = new List<Dependente>(); //inicializando!

            //gerando um ID para o funcionário..
            funcionario.IdFuncionario = Guid.NewGuid();

            Console.Write("Nome do funcionário............: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("CPF do funcionário.............: ");
            funcionario.Cpf = Console.ReadLine();

            Console.Write("Matrícula do funcionário.......: ");
            funcionario.Matricula = Console.ReadLine();

            Console.Write("Data de Admissão do funcionário:");
            funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

            //gerando um ID para o setor do funcionario..
            funcionario.Setor.IdSetor = Guid.NewGuid();

            Console.Write("Nome do Setor..................: ");
            funcionario.Setor.Nome = Console.ReadLine();

            Console.Write("Descrição do Setor.............: ");
            funcionario.Setor.Descricao = Console.ReadLine();

            //solicitar que o usuario informe o numero de dependentes desejado..
            Console.Write("Número de dependentes..........: ");
            var numDependentes = int.Parse(Console.ReadLine());


            //percorrer o numero de dependentes informado
            for (int i = 0; i < numDependentes; i++)
            {
                //criando um objeto do tipo Dependente..
                var dependente = new Dependente();

                //gerando o id do dependente..
                dependente.IdDependente = Guid.NewGuid();

                Console.Write($"\nENTRE COM O {i + 1}º DEPENDENTE:\n");

                Console.Write("Nome do dependente.............: ");
                dependente.Nome = Console.ReadLine();

                Console.Write("Data de Nascimento.............: ");
                dependente.DataNascimento = DateTime.Parse(Console.ReadLine());

                //adicionar o dependente dentro da lista..
                funcionario.Dependentes.Add(dependente);
            }

            //gravar os dados do funcionario em um arquivo 
            //de extensão JSON.
            var funcionarioRepository = new FuncionarioRepository();
            funcionarioRepository.ExportarJSON(funcionario);

            Console.WriteLine("\nARQUIVO JSON GERADO COM SUCESSO!");
        }
    }
}
