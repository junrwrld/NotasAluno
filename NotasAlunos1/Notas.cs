using System;
using System.Globalization;

namespace NotasAlunos1
{
    public class Notas
    {
        public string Nome;
        public double nota1;
        public double nota2;
        public double nota3;

        public double CalculoNotas()
        {
            double n = (nota1 + nota2 + nota3);
            return n;
        }

        public bool Aprovado()
        {

            if (CalculoNotas() >= 60.00)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.00 - CalculoNotas();
            }

        }


    }
}
