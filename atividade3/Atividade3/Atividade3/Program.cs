using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasseFuncionario;

namespace ClasseFuncionario
{

    internal class Program
    {
        static void Main (string[] args)
        {
            funcionario f = new funcionario();
            
            //dados sao adicionados pelo metodo set
            f.setNome("Danilo");
            f.setComissao(500);
            f.setSalario(1350);

            //usando get para imprimir os valores
            Console.WriteLine("Seu nome é.: " + f.getNome());
            Console.WriteLine("Sua comissão é.: " + f.getComissao());
            Console.WriteLine("Seu salário é.: " + f.getSalario());

            
        }
    }

    

}
