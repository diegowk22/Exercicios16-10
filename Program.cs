using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {

            int selecionarExercicio;

            Console.WriteLine("Escolha o exercício: ");
            Console.WriteLine("Calcular IMC");
            Console.WriteLine("Calcular Salário");
            Console.WriteLine("Calcular Volume de Esfera");
            Console.WriteLine("Calcular Média de Aluno");

            selecionarExercicio = int.Parse(Console.ReadLine());


            switch (selecionarExercicio)
            {
                case 01:
                    CalcularImc();
                    break;
                case 02:
                    CalcularSalario();
                    break;
                case 03:
                    CalcularVolumeEsfera();
                    break;
                case 04:
                    CalcularMediaAluno();
                    break;
                default:
                    Console.WriteLine("Escolha uma opção.");
                    break;
            }
            Console.ReadLine();
        }

        static void CalcularImc()
        {
            double peso, altura, calculoIMC;

            Console.WriteLine("Calculadora de IMC");

            Console.WriteLine("Por favor digite o seu peso em Kg");
            peso = Convert.ToDouble((Console.ReadLine()));

            Console.WriteLine("Por favor digite a sua altura");
            altura = Math.Pow(Convert.ToDouble(Console.ReadLine()), 2);

            calculoIMC = Math.Round(peso / altura);

            Console.WriteLine("O seu IMC é igual a {0}", calculoIMC);

            if (calculoIMC < 20)
            {
                Console.WriteLine("Você está abaixo do peso,cuide-se!");
            }
            else if (calculoIMC >= 20 && calculoIMC < 25)
            {
                Console.WriteLine("Parabéns! Você está no peso ideal.");
            }
            else
            {
                Console.WriteLine("Você está acima do peso, cuide-se!");
            }
        }
        static void CalcularSalario()
        {
            double salarioMinimo, seuSalario, salariosMinimos;

            Console.WriteLine("Calculadora de Salário - Descubra quantos salários mínimos você recebe.");

            Console.WriteLine("Digite o valor do salário mínimo em R$");
            salarioMinimo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite aqui o seu salário atual em R$");
            seuSalario = Convert.ToDouble(Console.ReadLine());


            salariosMinimos = Math.Round(seuSalario / salarioMinimo, 2);

            Console.WriteLine("Você recebe {0} salários minimos.", salariosMinimos);

        }

        static void CalcularVolumeEsfera()
        {
            double raio, volume;

            Console.WriteLine("Descubra o volume de esferas");
            Console.WriteLine("Digite o Raio da esfera");
            raio = Math.Pow(Convert.ToDouble(Console.ReadLine()), 3);

            volume = Math.Round((4.0 / 3.0) * Math.PI * raio, 2);

            Console.WriteLine("O volume da sua esfera é igual a {0}", volume);
        }

        static void CalcularMediaAluno()
        {
            double primeiraNota, segundaNota, terceiraNota, media, exame;

            Console.WriteLine("Aplique aqui a média de nota do aluno");

            Console.WriteLine("Digite o valor da 1ª Nota");
            primeiraNota = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor da 2ª Nota");
            segundaNota = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor da 3ª Nota");
            terceiraNota = Convert.ToDouble(Console.ReadLine());

            media = Math.Round(((primeiraNota + segundaNota + terceiraNota) / 3), 2);

            Console.Write("A média do aluno foi {0}", media);

            if (media >= 7)
            {
                Console.WriteLine("Este aluno está aprovado!");
            }
            else
            {
                Console.WriteLine("Digite a nota de exame do aluno");
                exame = Convert.ToDouble(Console.ReadLine());
                media = ((media + exame) / 2);
                Console.Write("A nova média do aluno é de: {0} pontos.", media);
                if (media >= 5)
                {
                    Console.WriteLine("O aluno foi aprovado, mas com exame.");
                }
                else
                {
                    Console.WriteLine("Este aluno foi REPROVADO, precisa estudar mais.");
                }
            }

        }

    }
}