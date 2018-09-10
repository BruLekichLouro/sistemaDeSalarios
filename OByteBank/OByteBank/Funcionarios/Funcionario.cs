using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OByteBank.Funcionarios
{
    public abstract class Funcionario
    { //esta classe é uma abstração que nos traz benefícios do polimorfismo
      //Não faz sentido gerar um funcionario generico se os metodos comuns a todos podem ser acessados(herança)
      // e cada um tem suas esppecificidades, métodos próprios(polimorfismo)
      //n'ao pode mais ser instanciada

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");
            TotalDeFuncionarios++;
            CPF = cpf;
            Salario = salario;
        }

        public abstract void AumentarSalario();


        public abstract double GetBonificacao();
        
    }
}
