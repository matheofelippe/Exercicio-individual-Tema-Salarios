using System;
using System.Globalization;
using System.Collections.Generic;

namespace Exercicio_individual_Tema_Salarios
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionarios> funcionario = new List<Funcionarios>(); //Cria lista de funcionarios
            Console.Write("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) //Pede os dados do funcionario e repete conforme a quantidade de funcionarios
            {
                Console.WriteLine("Funcionário #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------------------");
                Funcionarios s = new Funcionarios(id, nome, salario);
                funcionario.Add(s);
            }
            Console.Write("\nId do funcionário que receberá aumento: "); //Pede o funcionario que vai receber aumento
            int Id = int.Parse(Console.ReadLine());
            Funcionarios f = funcionario.Find(x => x.ID == Id);
            if (f != null) 
            {
                Console.Write("Porcentagem de aumento de salário: "); //Pede a porcentagem do aumento
                f.aumentaSalario(double.Parse(Console.ReadLine()));
            }
            else
            {
                Console.WriteLine("Este funcionário não existe!"); //Aviso caso funcionario/id não exista
            }
            Console.WriteLine("\nLista atualizada dos funcionários:"); //Mostra os funcionarios com aumentos caso ouver aumento
            foreach (Funcionarios obj in funcionario)
            {
                Console.WriteLine(obj.ID.ToString("D3") + ", " + obj.Nome + ", " + obj.Pagamento.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadKey();
        }
    }
}