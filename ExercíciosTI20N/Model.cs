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

        //Exercício 32: Faça um algoritmo que calcule a quantidade de litros de
        //combustível gasta em uma viagem, utilizando um automóvel
        //que faz 12Km por litro.Para obter o cálculo, o usuário deve
        //fornecer o tempo gasto na viagem e a velocidade média
        //durante ela.Desta forma, será possível obter a distância
        //percorrida com a fórmula DISTANCIA = TEMPO * VELOCIDADE.
        //Tendo o valor da distância, basta calcular a quantidade de
        //litros de combustível utilizada na viagem com a fórmula:
        //LITROS_USADOS = DISTANCIA / 12.O programa deve
        //apresentar os valores da velocidade média, tempo gasto na
        //viagem, a distância percorrida e a quantidade de litros
        //utilizada na viagem
        public void ExercicioTrintaDois()
        {
            double tempo = 0;
            double velocidadeMedia = 0;
            double distancia = 0;
            double litrosUsados = 0;

            Console.Write("Digite o tempo gasto na viagem (em horas): ");
            tempo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a velocidade média durante a viagem (em Km/h): ");
            velocidadeMedia = Convert.ToDouble(Console.ReadLine());

            distancia = tempo * velocidadeMedia;

            litrosUsados = distancia / 12.0;

            Console.WriteLine($"Velocidade média: {velocidadeMedia} km/h");
            Console.WriteLine($"Tempo gasto na viagem: {tempo} horas");
            Console.WriteLine($"Distância percorrida: {distancia} km");
            Console.WriteLine($"Quantidade de litros utilizada na viagem: {litrosUsados} litros");
        }//Fim do Exercício Trinta e Dois

        //Exercício 33: Escreva um algoritmo para ler as dimensões de um retângulo (base e altura), calcular e escrever a área do retângulo
        public string ExercicioTrintaTres(double baze, double altura)
        {
            double area = baze * altura;
            return "A área do retângulo é: " + area;
        }//Fim do Exercício Trinta e Três

        //Exercício 34: Escreva um algoritmo para ler o número total de eleitores de um município, o número de votos brancos, nulos e válidos.Calcular e escrever o percentual que cada um representa em relação ao total de eleitores
        public void ExercicioTrintaQuatro(int totalEleitores, int votosBrancos, int votosNulos, int votosValidos)
        {
            double percentualBrancos = (double)votosBrancos / totalEleitores * 100;
            double percentualNulos = (double)votosNulos / totalEleitores * 100;
            double percentualValidos = (double)votosValidos / totalEleitores * 100;

            Console.WriteLine($"Percentual de votos brancos: {percentualBrancos:F2}%");
            Console.WriteLine($"Percentual de votos nulos: {percentualNulos:F2}%");
            Console.WriteLine($"Percentual de votos válidos: {percentualValidos:F2}%");
        }//Fim do Exercício Trinta e Quatro

        //Exercício 35: O custo de um carro novo ao consumidor é a soma do custo de fábrica com a porcentagem do distribuidor e dos impostos(aplicados ao custo de fábrica). Supondo que o percentual do distribuidor seja de 28% e os impostos de 45%, escrever um algoritmo para ler o custo de fábrica de um carro, calcular e escrever o custo final ao consumidor.
        public void ExercicioTrintaCinco(double custoFabrica)
        {
            double percentualDistribuidor = 0.28; // 28%
            double percentualImpostos = 0.45; // 45%

            double valorDistribuidor = custoFabrica * percentualDistribuidor;
            double valorImpostos = custoFabrica * percentualImpostos;

            double custoFinal = custoFabrica + valorDistribuidor + valorImpostos;

            Console.WriteLine($"O custo final ao consumidor é: R${custoFinal:F2}");
        }//Fim do Exercício Trinta e Cinco

        //Exercício 36: Uma revendedora de carros usados paga a seus funcionários vendedores um salário fixo por mês, mais uma comissão também fixa para cada carro vendido e mais 5% do valor das vendas por ele efetuadas.Escrever um algoritmo que leia o número de carros por ele vendidos, o valor total de suas vendas, o salário fixo e o valor que ele recebe por carro vendido. Calcule e escreva o salário final do vendedor.
        public void ExercicioTrintaSeis()
        {
            int carrosVendidos;
            double valorVendas, salarioFixo, valorPorCarro, salarioFinal;

            // Pedindo ao usuário para inserir o número de carros vendidos
            Console.WriteLine("Insira o número de carros vendidos:");
            carrosVendidos = Convert.ToInt32(Console.ReadLine());

            // Pedindo ao usuário para inserir o valor total das vendas
            Console.WriteLine("Insira o valor total das vendas:");
            valorVendas = Convert.ToDouble(Console.ReadLine());

            // Pedindo ao usuário para inserir o salário fixo
            Console.WriteLine("Insira o salário fixo:");
            salarioFixo = Convert.ToDouble(Console.ReadLine());

            // Pedindo ao usuário para inserir o valor recebido por carro vendido
            Console.WriteLine("Insira o valor recebido por carro vendido:");
            valorPorCarro = Convert.ToDouble(Console.ReadLine());

            // Calculando o salário final do vendedor
            double comissaoFixaPorCarro = valorPorCarro * carrosVendidos;
            double comissaoPorVendas = valorVendas * 0.05; // 5% do valor das vendas

            salarioFinal = salarioFixo + comissaoFixaPorCarro + comissaoPorVendas;

            // Exibindo o salário final do vendedor
            Console.WriteLine($"O salário final do vendedor é: R${salarioFinal:F2}");
        }//Fim do Exercício Trinta e Seis

        //Exercício 37: Faça um programa que imprima os números de 1 a 100, mas substitua os múltiplos de 3 por "Fizz" e os múltiplos de 5 por "Buzz". Para números que são múltiplos de ambos (3 e 5), imprima "FizzBuzz".
        public void ExercicioTrintaSete()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }//Fim do If
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }//Fim do Else If
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }//Fim do Else If
                else
                {
                    Console.WriteLine(i);
                }//Fim do Else
            }//Fim do For
        }//Fim do Exercício Trinta e Sete

        //Exercício 38: Faça um programa que imprima os números de 100 a 1, em ordem decrescente.
        public void ExercicioTrintaOito()
        {
            for (int i = 100; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }//Fim do Exercício Trinta e Oito

        //Exercício 39: Faça um programa que peça ao usuário uma palavra e imprima cada letra dela em uma linha.
        public void ExercicioTrintaNove()
        {
            // Solicita ao usuário uma palavra
            Console.WriteLine("Digite uma palavra:");
            string palavra = Console.ReadLine();

            // Itera sobre cada letra da palavra e imprime em uma linha
            foreach (char letra in palavra)
            {
                Console.WriteLine(letra);
            }
        }//Fim do Exercício Trinta e Nove

        //Exercício 40: Faça um programa que peça ao usuário um número e imprima a soma dos números pares até esse número.
        public void ExercicioQuarenta()
        {
            // Solicita ao usuário um número
            Console.WriteLine("Digite um número:");
            int numero = Convert.ToInt32(Console.ReadLine());

            int somaPares = 0;

            // Itera de 1 até o número fornecido pelo usuário
            for (int i = 1; i <= numero; i++)
            {
                // Verifica se o número atual é par
                if (i % 2 == 0)
                {
                    somaPares += i; // Adiciona o número par à soma
                }//Fim do If
            }//Fim do For

            // Imprime a soma dos números pares
            Console.WriteLine($"A soma dos números pares até {numero} é: {somaPares}");
        }//Fim do Exercício Quarenta

        //Exercício 41: Faça um algoritmo que leia os valores de A, B, C e em seguida imprima na tela a soma entre A e B é mostre se a soma é menor que C.
        public void ExercicioQuarentaUm()
        {
            // Solicita ao usuário os valores de A, B e C
            Console.WriteLine("Digite o valor de A:");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de C:");
            int C = Convert.ToInt32(Console.ReadLine());

            // Calcula a soma de A e B
            int soma = A + B;

            // Verifica se a soma é menor que C
            if (soma < C)
            {
                Console.WriteLine($"A soma entre {A} e {B} é menor que {C}");
            }//Fim do If
            else
            {
                Console.WriteLine($"A soma entre {A} e {B} não é menor que {C}");
            }//Fim do Else
        }//Fim do Exercício Quarenta e Um

        //Exercício 42: Faça um algoritmo que leia dois valores inteiros A e B, se os valores de A e B forem iguais, deverá somar os dois valores, senão deverá multiplicar. Ao final de qualquer um dos cálculos deve-se atribuir o resultado a uma variável C e imprimir na tela.
        public void ExercicioQuarentaDois()
        {
            // Solicita ao usuário os valores de A e B
            Console.WriteLine("Digite o valor de A:");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            int B = Convert.ToInt32(Console.ReadLine());

            int C; // Variável para armazenar o resultado

            // Verifica se A e B são iguais
            if (A == B)
            {
                // Se forem iguais, soma os dois valores
                C = A + B;
            }//Fim do If
            else
            {
                // Se forem diferentes, multiplica os dois valores
                C = A * B;
            }//Fim do Else

            // Imprime o resultado
            Console.WriteLine($"O resultado é: {C}");
        }//Fim do Exercício Quarenta e Dois

        //Exercício 43: Faça um algoritmo que receba um número inteiro e imprima na tela o seu antecessor e o seu sucessor.
        public void ExercicioQuarentaTres()
        {
            // Solicita ao usuário um número inteiro
            Console.WriteLine("Digite um número inteiro:");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Calcula o antecessor e o sucessor do número
            int antecessor = numero - 1;
            int sucessor = numero + 1;

            // Imprime o antecessor e o sucessor na tela
            Console.WriteLine($"O antecessor de {numero} é: {antecessor}");
            Console.WriteLine($"O sucessor de {numero} é: {sucessor}");
        }//Fim do Exercício Quarenta e Três

        //Exercício 44: Faça um algoritmo que leia o valor do salário mínimo e o valor do salário de um usuário, calcule quantos salários mínimos esse usuário ganha e imprima na tela o resultado.
        public void ExercicioQuarentaQuatro()
        {
            // Solicita ao usuário o valor do salário mínimo
            Console.WriteLine("Digite o valor do salário mínimo:");
            double salarioMinimo = Convert.ToDouble(Console.ReadLine());

            // Solicita ao usuário o valor do seu salário
            Console.WriteLine("Digite o valor do seu salário:");
            double salarioUsuario = Convert.ToDouble(Console.ReadLine());

            // Calcula quantos salários mínimos o usuário ganha
            double salariosMinimosGanhos = salarioUsuario / salarioMinimo;

            // Imprime o resultado na tela
            Console.WriteLine($"Você ganha {salariosMinimosGanhos:F2} salários mínimos.");
        }//Fim do Exercício Quarenta e Quatro

        //Exercício 45: Faça um algoritmo que leia três valores inteiros diferentes e imprima na tela os valores em ordem decrescente.
        public void ExercicioQuarentaCinco()
        {
            // Solicita ao usuário os três valores inteiros diferentes
            Console.WriteLine("Digite o primeiro valor inteiro:");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor inteiro:");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor inteiro:");
            int valor3 = Convert.ToInt32(Console.ReadLine());

            // Armazena os valores em um array
            int[] valores = { valor1, valor2, valor3 };

            // Ordena o array em ordem decrescente
            Array.Sort(valores);
            Array.Reverse(valores);

            // Imprime os valores em ordem decrescente
            Console.WriteLine("Os valores em ordem decrescente são:");
            foreach (int valor in valores)
            {
                Console.WriteLine(valor);
            }//Fim do Foreach 
        }//Fim do Exercício Quarenta e Cinco

        //Exercício 46: Faça um algoritmo que leia quatro notas obtidas por um aluno, calcule a média das nota obtidas, imprima na tela o nome do aluno e se o aluno foi aprovado ou reprovado. Para o aluno ser considerado aprovado sua média final deve ser maior ou igual a 7.
        public void ExercicioQuarentaSeis()
        {
            //Solicita ao usuário o nome do aluno
            Console.WriteLine("Digite o nome do aluno:");
            string nomeAluno = Console.ReadLine();

            //Solicita ao usuário as quatro notas do aluno
            Console.WriteLine("Digite a primeira nota:");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota:");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota:");
            double nota4 = Convert.ToDouble(Console.ReadLine());

            //Calcula a média das notas do aluno
            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            //Verifica se o aluno foi aprovado ou reprovado
            string situacao;
            if (media >= 7)
            {
                situacao = "aprovado";
            }//Fim do If
            else
            {
                situacao = "reprovado";
            }//Fim do Else

            //Imprime na tela o nome do aluno e sua situação
            Console.WriteLine($"O aluno {nomeAluno} foi {situacao} com média {media:F2}");
        }//Fim do Exercício Quarenta e Seis

        //Exercício 47: Faça um algoritmo que receba um valor A e B, e troque o valor de A por B e o valor de B por A e imprima na tela os valores.
        public void ExercicioQuarentaSete()
        {
            //Solicita ao usuário os valores de A e B
            Console.WriteLine("Digite o valor de A:");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            int B = Convert.ToInt32(Console.ReadLine());

            //Troca os valores de A e B usando uma variável temporária
            int temp = A;
            A = B;
            B = temp;

            //Imprime os valores trocados na tela
            Console.WriteLine($"Valor de A após troca: {A}");
            Console.WriteLine($"Valor de B após troca: {B}");
        }//Fim do Exercício Quarenta e Sete

        //Exercício 48: Faça um algoritmo que leia o ano em que uma pessoa nasceu, imprima na tela quantos anos, meses e dias essa pessoa ja viveu. Leve em consideração o ano com 365 dias e o mês com 30 dias. (Ex: 5 anos, 2 meses e 15 dias de vida)
        public void ExercicioQuarentaOito()
        {
            //Solicita ao usuário o ano de nascimento
            Console.WriteLine("Digite o ano de nascimento:");
            int anoNascimento = Convert.ToInt32(Console.ReadLine());

            //Obtém a data atual
            DateTime dataAtual = DateTime.Today;

            //Calcula a diferença em anos, meses e dias
            int anos = dataAtual.Year - anoNascimento;
            int meses = dataAtual.Month - 1;
            int dias = dataAtual.Day;

            //Ajusta a diferença se ainda não tiver feito aniversário este ano
            if (dataAtual.Month < anoNascimento)
            {
                anos--;
                meses = 12 - (anoNascimento - dataAtual.Month) - 1;
            }//Fim do If

            //Ajusta a diferença se ainda não tiver completado o mês atual
            if (dataAtual.Day < anoNascimento)
            {
                dias = 30 - (anoNascimento - dataAtual.Day);
            }//Fim do If

            //Imprime na tela a idade da pessoa
            Console.WriteLine($"Você tem {anos} anos, {meses} meses e {dias} dias de vida.");
        }//Fim do Exercício Quarenta e Oito

        //Exercício 49: Faça um algoritmo que leia três valores que representam os três lados de um triângulo e verifique se são válidos, determine se o triângulo é equilátero, isósceles ou escaleno.
        public void ExercicioQuarentaNove()
        {
            //Solicita ao usuário os três lados do triângulo
            Console.WriteLine("Digite o comprimento do primeiro lado:");
            double lado1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o comprimento do segundo lado:");
            double lado2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o comprimento do terceiro lado:");
            double lado3 = Convert.ToDouble(Console.ReadLine());

            //Verifica se os três valores fornecidos formam um triângulo
            if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
            {
                // Verifica se é um triângulo equilátero
                if (lado1 == lado2 && lado1 == lado3)
                {
                    Console.WriteLine("O triângulo é equilátero.");
                }//Fim do If
                // Verifica se é um triângulo isósceles
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    Console.WriteLine("O triângulo é isósceles.");
                }//FIm do Else If
                //Caso contrário, é um triângulo escaleno
                else
                {
                    Console.WriteLine("O triângulo é escaleno.");
                }//Fim do Else
            }//Fim do If
            else
            {
                Console.WriteLine("Os valores fornecidos não formam um triângulo válido.");
            }//Fim do Else
        }//Fim do Exercício Quarenta e Nove

        //Exercício 50: Faça um algoritmo que calcule a quantidade de litros de combustível
        //gastos em uma viagem, sabendo que o carro faz 12km com um litro.
        //Deve-se fornecer ao usuário o tempo que será gasto na viagem a sua velocidade média,
        //distância percorrida e a quantidade de litros utilizados para fazer a viagem.
        //Fórmula: distância = tempo x velocidade.  litros usados = distância / 12.
        public void ExercicioCinquenta()
        {
            //Solicita ao usuário o tempo gasto na viagem (em horas)
            Console.WriteLine("Digite o tempo gasto na viagem (em horas):");
            double tempoViagem = Convert.ToDouble(Console.ReadLine());

            //Solicita ao usuário a velocidade média durante a viagem (em km/h)
            Console.WriteLine("Digite a velocidade média durante a viagem (em km/h):");
            double velocidadeMedia = Convert.ToDouble(Console.ReadLine());

            //Calcula a distância percorrida (distância = velocidade * tempo)
            double distanciaPercorrida = velocidadeMedia * tempoViagem;

            //Calcula a quantidade de litros de combustível utilizada (litros = distância / autonomia)
            double autonomia = 12; // O carro faz 12km por litro
            double litrosUtilizados = distanciaPercorrida / autonomia;

            //Exibe os resultados
            Console.WriteLine($"Tempo gasto na viagem: {tempoViagem} horas");
            Console.WriteLine($"Velocidade média: {velocidadeMedia} km/h");
            Console.WriteLine($"Distância percorrida: {distanciaPercorrida} km");
            Console.WriteLine($"Quantidade de litros utilizada na viagem: {litrosUtilizados:F2} litros");   
        }//Fim do Exercício Cinquenta

    }//Fim da Classe
}//Fim do Projeto
