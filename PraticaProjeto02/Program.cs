using PraticaProjeto02.Controllers;
using System;

namespace PraticaProjeto02
{
    class Program
    {
        static void Main(string[] args)
        {
            try //tentativa..
            {
                var funcionarioController = new FuncionarioController();
                funcionarioController.CadastrarFuncionario();
            }
            catch (Exception e) //captura do erro..
            {
                Console.WriteLine($"\nOcorreu um erro: {e.Message}");
            }

            //pausar o prompt do DOS..
            Console.ReadKey();
        }
    }
}

