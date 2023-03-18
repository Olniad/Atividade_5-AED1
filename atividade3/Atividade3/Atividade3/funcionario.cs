using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseFuncionario
{
    internal class funcionario
    {
        private string nome;
        private double salario;
        private double comissao;
        public funcionario() { }
        public funcionario(string nome, double salario, double comissao)
            {
                this.nome = nome;
                this.comissao = comissao;               
                this.salario = salario;
            }

            //this nome = nome;
            //return this.nome;

            public void setNome(string nome)
            {
                this.nome = nome;
            }

            public string getNome()
            {
                return this.nome;
            }

            public void setComissao(double comissao)
            {
                this.comissao = comissao;
            }

            public double getComissao()
            {
                return this.comissao;
            }

            public void setSalario(double salario)
            {
                this.salario = salario;
            }

            public double getSalario()
            {
                return this.salario;
            }

   

        

    }

    
}
