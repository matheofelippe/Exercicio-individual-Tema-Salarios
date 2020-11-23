using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_individual_Tema_Salarios
{
    class Funcionarios
    {
        private int id;
        private string nome;
        private double salario;

        public Funcionarios(int Id, string Nome, double Salario)
        {
            id = Id;
            nome = Nome;
            salario = Salario;
        }
        public void aumentaSalario(double porcentagem) //Aumenta o salario com base na porcentagem oferecida
        {
            salario += (salario * porcentagem / 100);
        }
        public int ID //Properties do ID
        {
            get { return id; }
        }
        public string Nome //Properties do nome
        {
            get { return nome; }
        }
        public double Pagamento //Properties do pagamento
        {
            get { return salario; }
        }
    }
}