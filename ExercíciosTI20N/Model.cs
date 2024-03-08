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
            while (num !=0)
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

    }//Fim da Classe
}//Fim do Projeto
