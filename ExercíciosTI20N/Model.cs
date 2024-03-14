using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExercíciosTI20N
{
    class Model
    {
 
        //Contrutor
        public Model()
        {

        }//Fim do Método Construtor

        //Exercício 01: Faça um programa que imprima os números de 1 a 10.
        public string ExercicioUm()
        {
            string resultado = "";

            for (int i = 0; i < 10; i++)
            {
                resultado += "\n" + (i + 1);
            }

            return resultado;
        }//Fim do Método

        //Exercício 02: Faça um programa que imprima os números pares de 1 a 20.
        public string ExercicioDois()
        {
            string resultado = "";

            for (int i = 0; i < 20; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    resultado += "\n" + (i + 1);
                }//Fim do If
            }//Fim do For

            return resultado;
        }//Fim do Exercício Dois

        //Exercicio 03: Faça um programa que calcule a soma dos números de 1 a 100.
        public int ExercicioTres()
        {
            int resultado = 0;
            for (int i = 1; i <= 100; i++)
            {
                resultado += i;
            }//Fim da For

            return resultado;
        }//Fim do Exercício Três

        //Exercício 04: Faça um programa que imprima os múltiplos  de 5 de 1 a 50.
        public string ExercicioQuatro()
        {
            string resultado = "";
            for (int i = 1; i <= 50; i++)
            {
                if ((i + 1) % 5 == 0)
                {
                    resultado += "\n" + (i + 1);
                }//Fim do If
            }//Fim da For

            return resultado;
        }//Fim do Exercício Quatro

        //Exercício 05: Faça um programa que peça ao usuário um número e imprima se é par ou impar.
        public string ExercicioCinco(int num)
        {
            if (num % 2 == 0)
            {
                return "O número informado é par";
            }
            else
            {
                return "O número informado é ímpar";
            }
        }//Fim do Exercício Cinco

        //Exercício 06: Faça um programa que peça ao usuário um número e imprima se é positivo, negativo ou zero.
        public string ExercicioSeis(int num)
        {
            if (num > 0)
            {
                return "O número informado é positivo!";
            }
            else if (num < 0)
            {
                return "O número informado é negativo!";
            }
            else
            {
                return "O número informado é zero!";
            }//Fim do If
        }//Fim do Exercício Seis

        //Exercício 07: Faça um programa que peça ao usuário um número e imprima a tabauada desse número.
        public string ExercicioSete(int num)
        {
            string resultado = "";
            resultado += " Tabuada de " + num;
            for (int i = 0; i <= 10; i++)
            {
                resultado += "\n " + num + " * " + i + " = " + (num * i);
            }//Fim do For
            return resultado;
        }//Fim do Exercício 07

        //Exercício 08: Faça um programa que peça ao usuário um número e imprima os números de 1 até esse número.
        public string ExercicioOito(int num)
        {
            string resultado = "";
            for (int i = 0; i < num; i++)
            {
                resultado += "\n" + (i + 1);
            }
            return resultado;
        }//Fim do Exercício Oito

        //Exercício 09: Faça um programa que peça ao usuário um número e imprima a soma dos números de 1 até esse número.
        public int ExercicioNove(int num)
        {
            int resultado = 0;
            for (int i = 1; i <= num; i++)
            {
                resultado += i;
            }
            return resultado;
        }//Fim do Exercício Nove

        //Exercício 10: Faça um programa que imprima os números primos de 1 a 20.
        public string ExercicioDez()
        {
            string primos = "";
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0)
                {
                    primos += "" + i;
                }//Fim do If
            }//Fim do For
            return primos;
        }//Fim do Exercício Dez

        //Exercício 11: Faça um programa que peça ao usuário um número e verifique se é primo.
        public bool ExercicioOnze(int num)
        {
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }//Fim do If
            }//Fim do For
            return true;
        }//Fim do Exercício Onze

        //Exercicio 12: Faça um programa que calcula o fatorial de um número:
        public string ExercicioDoze(int num)
        {
            int fatorial = 1;
            for (int i = num; i >= 1; i--)
            {
                fatorial *= i;
            }
            return "O resultado é:" + fatorial;

        }//Fim do Exercicio Doze

        //Exercicio 13: Faça um programa que imprima e sequência de Fibonacci até o décimo termo.
        public string ExercicioTreze()
        {
            string resultado = "0 1";
            int fib1 = 0;
            int fib2 = 1;
            int fib3 = 0;
            for (int i = 1; i <= 8; i++)
            {
                fib3 = fib1 + fib2;
                resultado += " " + fib3;
                fib1 = fib2;
                fib2 = fib3;
            }//Fim do For

            return resultado;
        }//Fim do Exercicio Treze

        //Exercicio 14: Faça um programa que peça ao usuário um número e imprima se é um número de Fibonacci.
        public string ExercicioCatorze(int num)
        {
            string resultado = "0 1";
            int fib1 = 0;
            int fib2 = 1;
            int fib3 = 0;
            for (int i = 1; i <= num - 2; i++)
            {
                fib3 = fib1 + fib2;
                resultado += " " + fib3;
                fib1 = fib2;
                fib2 = fib3;
            }//Fim do For

            return resultado;
        }//Fim do Exercicio Catorze

        //Exercício 15: Faça um programa que peça ao usuário um número e calcule a soma dos seus dígitos.
        public int ExercicioQuinze(int num)
        {
            int soma = 0;
            while (num != 0)
            {
                soma += num % 10;
                num /= 10;
            }
            return soma;
        }//Fim do Exercício Quinze

        //Exercício 16: Faça um programa que peça ao usuário um número e imprima os números pares e ímpares de 1 até esse número.
        public string ExercicioDezesseis(int num)
        {
            string par = "";
            string impar = "";

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    par += " " + i;
                }//Fim do If
                else
                {
                    impar += " " + i;
                }//Fim do Else
            }//Fim do For

            return "Pares: " + par + "\nÍmpares: " + impar;

        }//Fim do Exercício Dezesseis

        //Exercício 17: Faça um programa que peça ao usuário um número e imprima o dobro desse número.
        public int ExercicioDezessete(int num)
        {
            int resultado = 0;
            resultado = num * 2;
            return resultado;

        }//Fim do Exercício Dezessete

        //Exercício 18: Faça um programa que peça ao usuário dois números e imprima a média deles.
        public string ExercicioDezoito(double num1, double num2)
        {
            double media = 0;
            media = (num1 + num2) / 2;
            return "A média dos números somados é: " + media;
        }//Fim do Exercício Dezoito

        //Exercício 19: Faça um programa que converta a temperatura de Celsius para Fahrenheit. A fórmula é F = C * 9/5 + 32.
        public string ExercicioDezenove(double celsius)
        {
            double fahrenheit = 0;
            fahrenheit = celsius * 9 / 5 + 32;
            return "A conversão de graus Celsius para Fahrenheit é: " + fahrenheit;
        }//Fim do Exercício Dezenove

        //Exercício 20: Faça um programa que peça o raio de círculo e imprima a área. A fórmula é A = raio * raio^2.
        public string ExercicioVinte(double raio)
        {
            double area = 0;
            area = Math.PI * (raio * raio);
            return "A área do número informado é de: " + area;
        }//Fim do Exercício Vinte

        //Exercício 21: Faça um programa que peça um número e imprima o seu quadrado.
        public string ExercicioVinteUm(int num)
        {
            int resultado = 0;
            resultado = num * num;
            return "O quadrado do número informado é: " + resultado;
        }//Fim do Exercício Vinte Um

        //Exercício 22: Faça um programa que peça dois números e imprima o maior deles.
        public int ExercicioVinteDois(int num3, int num4)
        {
            if (num3 > num4)
            {
                return num3;
            }//Fim do If
            else
            {
                return num4;
            }//Fim do Else
        }//Fim do Exercício Vinte Dois

        //Exercício 23: Faça um programa que peça dois números e imprima "São Iguais" se os números forem iguais ou imprima "São Diferentes" se forem diferentes.
        public string ExercicioVinteTres(int num5, int num6)
        {
            if (num5 == num6)
            {
                return "Os números são iguais";
            }//Fim do If
            else
            {
                return "Os números são diferentes";
            }//Fim do Else
        }//Fim do Exercício Vinte Tres

        //Exercício 24: Faça um programa que peça idade do usuário e imprima se ele é maior de idade ou menor de idade.
        public string ExercicioVinteQuatro(int num)
        {
            if (num >= 18)
            {
                return "O usuário é maior de idade";
            }//Fim do If
            else
            {
                return "VOCÊ É MENOR DE IDADE SOME DAQUI, VOU CONTAR PROS SEUS PAIS";
            }//Fim do Else
        }//Fim do Exercício Vinte Quatro

        //Exercício 25: Faça um programa que peça dois números e imprima o menor deles.
        public string ExercicioVinteCinco(int num7, int num8)
        {
            if (num7 < num8)
            {
                return "O menor número informado é: " + num7;
            }//Fim do If
            else
            {
                return "O menor número informado é: " + num8;
            }//Fim do Else
        }//Fim do Exercício Vinte Cinco

        //Exercício 26: Faça um programa que peça a altura e o peso de uma pessoa e calcule o IMC. A fórmula é IMC = peso / altura^2.
        public string ExercicioVinteSeis(double altura, double peso)
        {
            double IMC = 0;
            IMC = altura / (Math.Pow(peso, 2));
            return "O IMC é: " + IMC;
        }//Fim do Exercício Vinte Seis

        //Exercício 27: Faça um algorítimo que leia a idade de uma pessoa expressa em anos, meses e dias e escreva a idade apenas em dias. Considerar ano com 365 dias e mês com 30 dias.
        public string ExercicioVinteSete(int ano, int mes, int dia)
        {
            int idade = 0;
            idade = (ano * 365) + (mes * 30) + dia;
            return "A idade em dias é: " + idade;
        }//Fim do Exercício Vinte Sete

        //Exercício 28: Ler o salário fixo e o valor das vendas efetuadas pelo vendedor de uma empresa. Sabendo-se que ele recebe uma comissão 3% sobre o total das vendas até R$ 1.500,00 mais 5% sobre o que ultrapassar este valor, calcular e escrever o seu salário total
        public string ExercicioVinteOito(double vendas, double salario)
        {
            double total = 0;
            if (vendas <= 1500)
            {
                total = salario + (0.03 * vendas);
            }//Fim do If
            else if (vendas > 1500)
            {
                total = salario + (1500 * 0.03) + (1500 - vendas) * 0.05;
            }//Fim do Else

            return "O salário final é: " + total;
        }//Fim do Exercício Vinte Oito

        //Exercício 29: Ler 10 valores e escrever quantos desses valores lidos são negativos.
        public string ExercicioVinteNove()
        {
            int num = 0;
            int cont = 0;

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Informe um número: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num < 0)
                {
                    cont++;
                }//Fim do If
            }//Fim da For

            return "A quantidade de números negativos são: " + cont;
        }//Fim do Exercício Vinte Nove

        //Exercício 30: Escreva um algoritmo para ler 10 números. Todos os números lidos com valor inferior a 40 devem ser somados. Escreva o valor final da soma efetuada.
        public string ExercicioTrinta()
        {
            int num = 0;
            int soma = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Informe um número: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num < 40)
                {
                    soma += num;
                }//Fim do If
            }//Fim da For

            return "A soma dos números é: " + soma;
        }//Fim do Exercício Trinta

        //Exercicio 31:Escreva um algoritmo que permita a leitura das notas de uma turma de 20 alunos.Calcular a média da turma.Escrever a média da turma.
        public string ExercicioTrintaUm()
        {
            int soma = 0;
            int media = 0;
            int nota = 0;

            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine("Informe um número: ");
                nota = Convert.ToInt32(Console.ReadLine());

                soma += nota;

            }//Fim do For

            media = soma / 20;

            return "A média da turma é: " + media;

        }//Fim do Exercicio Trinta e Um

    }//Fim da Classe
}//Fim do Projeto
