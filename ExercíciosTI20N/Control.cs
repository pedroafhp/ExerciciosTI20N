using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExercíciosTI20N
{
    class Control
    {
        Model modelo;
        public Control()
        {
            modelo = new Model();
        }//Fim do Construtor

        public void Menu()
        {
            Console.WriteLine("\n\nEscolha uma das opções abaixo: \n" +
                             "0. Sair\n" +
                             "1. Exercício 01\n" +
                             "2. Exercício 02\n" +
                             "3. Exercício 03\n" +
                             "4. Exercício 04\n" +
                             "5. Exercício 05\n" +
                             "6. Exercício 06\n" +
                             "7. Exercício 07\n" +
                             "8. Exercício 08\n" +
                             "9. Exercício 09\n" +
                             "10.Exercício 10\n" +
                             "11.Exercício 11\n" +
                             "12.Exercício 12\n" +
                             "13.Exercício 13\n" +
                             "14.Exercício 14\n" +
                             "15.Exercício 15\n" +
                             "16.Exercício 16\n" +
                             "17.Exercício 17\n" +
                             "18.Exercício 18\n" +
                             "19.Exercício 19\n" +
                             "20.Exercício 20\n" +
                             "21.Exercício 21\n" +
                             "22.Exercício 22\n" +
                             "23.Exercício 23\n" +
                             "24.Exercício 24\n" +
                             "25.Exercício 25\n" +
                             "26.Exercício 26\n" +
                             "27.Exercício 27\n" +
                             "28.Exercício 28\n" +
                             "29.Exercício 29\n" +
                             "30.Exercício 30\n" +
                             "31.Exercício 31\n" +
                             "32.Exercício 32\n" +
                             "33.Exercício 33\n" +
                             "34.Exercício 34\n" +
                             "35.Exercício 35\n" +
                             "36.Exercício 36\n" +
                             "37.Exercício 37\n" +
                             "38.Exercício 38\n" +
                             "39.Exercício 39\n" +
                             "40.Exercício 40\n" +
                             "41.Exercício 41\n" +
                             "42.Exercício 42\n" +
                             "43.Exercício 43\n" +
                             "44.Exercício 44\n" +
                             "45.Exercício 45\n" +
                             "46.Exercício 46\n" +
                             "47.Exercício 47\n" +
                             "48.Exercício 48\n" +
                             "49.Exercício 49\n" +
                             "50.Exercício 50\n" +
                             "51.Exercício 51\n" +
                             "52.Exercício 52\n" +
                             "53.Exercício 53\n" +
                             "54.Exercício 54\n" +
                             "55.Exercício 55\n");
        }
            public void Operacao()
            {
                int opcao = 0;
                do
                {
                    Menu();//Mostrando as Opções
                    opcao = Convert.ToInt32(Console.ReadLine());

                    switch (opcao)
                    {
                        case 0:
                            Console.WriteLine("Obrigado!");
                            break;
                        case 1:
                            Console.WriteLine(modelo.ExercicioUm());
                            break;
                        case 2:
                            Console.WriteLine(modelo.ExercicioDois());
                            break;
                        case 3:
                            Console.WriteLine("A soma dos números entre 1 e 100 é: " + modelo.ExercicioTres());
                            break;
                        case 4:
                            Console.WriteLine("Os múltiplos de 5 entre 1 e 50 são: " + modelo.ExercicioQuatro());
                            break;
                        case 5:
                            Console.WriteLine("Informe um número: ");
                            int num = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(modelo.ExercicioCinco(num));
                            break;
                        case 6:
                            Console.WriteLine("Informe um número: ");
                            num = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(modelo.ExercicioSeis(num));
                            break;
                        case 7:
                            Console.WriteLine("Informe um número: ");
                            num = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(modelo.ExercicioSete(num));
                            break;
                        case 8:
                            Console.WriteLine("Informe um número: ");
                            num = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(modelo.ExercicioOito(num));
                            break;
                        case 9:
                            Console.WriteLine("Informe um número: ");
                            num = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(modelo.ExercicioNove(num));
                            break;
                        case 10:
                            Console.WriteLine("Os números primos são: ");
                            Console.WriteLine(modelo.ExercicioDez());
                            break;

                        case 11:
                            Console.WriteLine("Informe um número: ");
                            num = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(modelo.ExercicioOnze(num));
                            break;

                        case 12:
                            Console.WriteLine("Informe um número para calcular o fatorial");
                            num = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(modelo.ExercicioDoze(num));
                            break;

                        case 13:
                            Console.WriteLine(modelo.ExercicioTreze());
                            break;

                        case 14:
                            Console.WriteLine("Informe um número: ");
                            num = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(modelo.ExercicioCatorze(num));
                            break;
                        case 15:
                            Console.WriteLine("Informe um número: ");
                            num = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(modelo.ExercicioQuinze(num));
                            break;

                        case 16:
                            Console.WriteLine("Informe um número: ");
                            num = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(modelo.ExercicioDezesseis(num));
                            break;

                        case 17:
                            Console.WriteLine("Informe um número: ");
                            num = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(modelo.ExercicioDezessete(num));
                            break;

                        case 18:
                            Console.WriteLine("Informe o primeiro número: ");
                            double num1 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Informe o segundo número: ");
                            double num2 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(modelo.ExercicioDezoito(num1, num2));
                            break;

                        case 19:
                            Console.WriteLine("Informe um número: ");
                            double fahrenheit = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(modelo.ExercicioDezenove(fahrenheit));
                            break;

                        case 20:
                            Console.WriteLine("Informe um número: ");
                            double area = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(modelo.ExercicioVinte(area));
                            break;

                        case 21:
                            Console.WriteLine("Informe um número: ");
                            num = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(modelo.ExercicioVinteUm(num));
                            break;

                        case 22:
                            Console.WriteLine("Informe o primeiro número: ");
                            int num3 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Informe o segundo número: ");
                            int num4 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(modelo.ExercicioVinteDois(num3, num4));
                            break;

                        case 23:
                            Console.WriteLine("Informe o primeiro número: ");
                            int num5 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Informe o segundo número: ");
                            int num6 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(modelo.ExercicioVinteTres(num5, num6));
                            break;

                         case 24:
                            Console.WriteLine("Informe um número: ");
                            num = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(modelo.ExercicioVinteQuatro(num));
                            break;

                         case 25:
                            Console.WriteLine("Informe o primeiro número: ");
                            int num7 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Informe o segundo número: ");
                            int num8 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(modelo.ExercicioVinteCinco(num7, num8));
                            break;

                         case 26:
                            Console.WriteLine("Informe a sua altura: ");
                            double altura = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Informe o seu peso: ");
                            double peso = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine(modelo.ExercicioVinteSeis(altura, peso));
                            break;

                        case 27:
                            Console.WriteLine("Informe quantos anos você tem: ");
                            int ano = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Informe quantos meses passou do seu aniversário: ");
                            int mes = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Informe quantos dias passsaram após seu aniversário: ");
                            int dia = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(modelo.ExercicioVinteSete(ano, mes, dia));
                            break;

                        case 28:
                            Console.WriteLine("Informe o valor da venda: ");
                            double vendas = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Informe o salário: ");
                            double salario = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine(modelo.ExercicioVinteOito(vendas, salario));
                            break;

                        case 29:
                            Console.WriteLine(modelo.ExercicioVinteNove());
                            break;

                        case 30:
                            Console.WriteLine(modelo.ExercicioTrinta());
                            break;

                        case 31:
                            Console.WriteLine(modelo.ExercicioTrintaUm());
                            break;

                        case 32:
                        modelo.ExercicioTrintaDois();
                        break;

                        case 33:
                            Console.WriteLine("Informe a base do retângulo: ");
                            double baze = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Informe a altura do retângulo: ");
                            altura = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine(modelo.ExercicioTrintaTres(baze, altura));
                            break;

                        case 34:
                            Console.WriteLine("Insira o número total de eleitores:");
                            int totalEleitores = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Insira o número de votos brancos:");
                            int votosBrancos = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Insira o número de votos nulos:");
                            int votosNulos = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Insira o número de votos válidos:");
                            int votosValidos = Convert.ToInt32(Console.ReadLine());

                            modelo.ExercicioTrintaQuatro(totalEleitores, votosBrancos, votosNulos, votosValidos);
                            break;

                        case 35:
                            Console.WriteLine("Insira o custo de fábrica do carro:");
                            double custoFabrica = Convert.ToDouble(Console.ReadLine());

                            modelo.ExercicioTrintaCinco(custoFabrica);
                            break;

                        case 36:
                            modelo.ExercicioTrintaSeis();
                            break;

                        case 37:
                            modelo.ExercicioTrintaSete();
                            break;

                        case 38:
                            modelo.ExercicioTrintaOito();
                            break;

                        case 39:
                            modelo.ExercicioTrintaNove();
                            break;

                        case 40:
                            modelo.ExercicioQuarenta();
                            break;

                        case 41:
                            modelo.ExercicioQuarentaUm();
                            break;

                        case 42:
                            modelo.ExercicioQuarentaDois();
                            break;

                        case 43:
                            modelo.ExercicioQuarentaTres();
                            break;

                        case 44:
                            modelo.ExercicioQuarentaQuatro();
                            break;

                        case 45:
                            modelo.ExercicioQuarentaCinco();
                            break;

                        case 46:
                            modelo.ExercicioQuarentaSeis();
                            break;

                        case 47:
                            modelo.ExercicioQuarentaSete();
                            break;

                        case 48:
                            modelo.ExercicioQuarentaOito();
                            break;

                        case 49:
                            modelo.ExercicioQuarentaNove();
                            break;

                        case 50:
                            modelo.ExercicioCinquenta();
                            break;
                        case 51:
                            modelo.ExercicioCinquentaUm();
                            break;
                        case 52:
                            Console.WriteLine("A média do vetor: " + modelo.ExercicioCinquentaDois());
                            break;
                        case 53:
                          modelo.ExercicioCinquentaTres();
                            break;
                        case 54:
                          modelo.ExercicioCinquentaQuatro();
                        break;
                        case 55:
                            modelo.ExercicioCinquentaCinco();
                        break;

                    default:
                            Console.WriteLine("Código digitado não é valido!");
                            break;

                    }//Fim da Operação
                } while (opcao != 0);
            }//Fim da Operação
        }//Fim da Classe
    }//Fim do Projeto
