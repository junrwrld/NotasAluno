using NotasAlunos1;
using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace alunos
{
    public class alunos1
    {
        static void Main(string[] args)
        {

            Notas notas = new Notas();

            Console.WriteLine("Digite o nome do aluno: ");
            Console.Write("Nome: ");
            notas.Nome = Console.ReadLine();
            Console.WriteLine("Digite as notas dos bimestres:");
            notas.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            notas.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            notas.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (notas.Aprovado())
            {
                Console.WriteLine("Você foi aprovado!");
                Console.WriteLine("Sua nota é: " + notas.CalculoNotas().ToString("F2", CultureInfo.InvariantCulture));
            }

            else
            {
                Console.WriteLine("Você foi reprovado!");
                Console.WriteLine("Sua nota foi: " + notas.CalculoNotas().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Faltaram " + notas.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " pontos");
            }
            
        }
    }
}