using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFOperacionesAritmeticas
{
    public class Operacion
    {
        public string TipoOperacion { get; set; }
        public double Valor1 { get; set; }
        public double Valor2 { get; set; }
        public double Resultado { get; set; }

        public Operacion(string ptipoOperacion,double pvalor1,double pvalor2)
        {
            TipoOperacion = ptipoOperacion;
            Valor1 = pvalor1;
            Valor2 = pvalor2;
            Resultado = 0;
        }

        public Operacion procesar(Operacion op)
        {
            switch (op.TipoOperacion)
            {
                case "sumar":
                    op.Resultado = sumar(op.Valor1, op.Valor2);
                    break;
                case "restar":
                    op.Resultado = restar(op.Valor1, op.Valor2);
                    break;
                case "multiplicar":
                    op.Resultado = multiplicar(op.Valor1, op.Valor2);
                    break;
                case "dividir":
                    op.Resultado = dividir(op.Valor1, op.Valor2);
                    break;
                default:
                    Console.WriteLine("Operación Inválida");
                    break;
            }

            return op;
        }

        public double restar(double pvalor1, double pvalor2)
        {
            double resultado = pvalor1 - pvalor2;

            return resultado;
        }

        public double sumar(double pvalor1, double pvalor2)
        {
            double resultado = pvalor1 + pvalor2;

            return resultado;
        }

        public double dividir(double pvalor1, double pvalor2)
        {
            double resultado = pvalor1 / pvalor2;

            return resultado;
        }

        public double multiplicar(double pvalor1, double pvalor2)
        {
            double resultado = pvalor1 * pvalor2;

            return resultado;
        }
    }
}