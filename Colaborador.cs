using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula53_Exercicio
{
    internal class Colaborador
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double SalarioLiquido { get; set; }

        public int TipoContrato { get; set; }

        public double ValorProjeto { get; set; }

        public Colaborador(string nome, double salarioBruto, int tipoContrato)
        {
            this.Nome = nome;
            this.SalarioBruto = salarioBruto;
            this.TipoContrato = tipoContrato;
        }

        public Colaborador(string nome, int tipoContrato, double valorProjeto)
        {
            this.Nome = nome;
            this.TipoContrato = tipoContrato;
            this.ValorProjeto = valorProjeto;
        }

        public double CalculaSalarioLiquido(Colaborador colaborador)
        {
            if (colaborador.TipoContrato == 1)
            {
                //clt
                double descontoVT = SalarioBruto * 0.06; //vt
                //aplicar o desconto do inss
                if (SalarioBruto < 1212)
                {
                    colaborador.SalarioLiquido = (SalarioBruto * 0.925) - descontoVT;

                }
                else if (SalarioBruto >= 1212.01 && SalarioBruto <= 2427.35)
                {
                    colaborador.SalarioLiquido = (SalarioBruto * 0.91) - descontoVT;


                }
                else if (SalarioBruto >= 2427.36 && SalarioBruto <= 3641.03)
                {
                    colaborador.SalarioLiquido = (SalarioBruto * 0.88) - descontoVT;


                }
                else if (SalarioBruto >= 3641.04 && SalarioBruto <= 7087.22)
                {
                    colaborador.SalarioLiquido = (SalarioBruto * 0.86) - descontoVT;

                }
                else
                {
                    colaborador.SalarioLiquido = (SalarioBruto * 0.8831) - descontoVT;

                }



            }
            else if (colaborador.TipoContrato == 2)
            {
                colaborador.SalarioLiquido = SalarioBruto * 0.94;
                //pj
            }
            else
            {
                colaborador.SalarioLiquido = ValorProjeto * 0.085;
                //freela

            }

            return colaborador.SalarioLiquido;

        }
    }
}
