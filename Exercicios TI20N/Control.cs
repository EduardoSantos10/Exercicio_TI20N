using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_TI20N
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




            Console.WriteLine("\n\nEscolha uma das opções abaixo:  \n" +
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
                                    "10. Exercício 10\n"+
                                    "11. Exercício 11\n"+
                                    "12. Exercício 12\n"+
                                    "13. Exercício 13\n"+
                                    "14. Exercício 14\n"+
                                    "15. Exercício 15\n"+
                                    "16. Exercício 16\n"+
                                    "17. Exercício 17\n"+
                                    "18. Exercício 18\n"+
                                    "19. Exercício 19\n"+
                                    "20. Exercício 20\n"+
                                    "21. Exercício 21\n"+
                                    "22. Exercício 22\n"+
                                    "23. Exercício 23\n"+
                                    "24. Exercício 24\n"+
                                    "25. Exercício 25\n"+
                                    "26. Exercício 26\n"+
                                    "27. Exercício 27\n"+
                                    "28. Exercício 28\n"+
                                    "29. Exercício 29\n"+
                                    "30. Exercício 30\n"+
                                    "31. Exercício 31\n"+
                                    "32. Exercício 32\n"+
                                    "33. Exercício 33\n"+
                                    "34. Exercício 34\n"+
                                    "35. Exercício 35\n"+
                                    "51. Exercício 51\n"+
                                    "52. Exercício 52\n"+
                                    "53. Exercício 53\n"+
                                    "54. Exercício 54\n"+
                                    "55. Exercício 55\n"+
                                    "56. Exercício 56\n"+
                                    "57. Exercício 57\n"+
                                    "58. Exercício 58\n"+
                                    "59. Exercício 59\n"+
                                    "60. Exercício 60\n"+
                                    "61. Exercício 61\n");
                                           
                                                 
                                        
        
        }//Fim do Menu

        public void Operacao()
        {
            int opcao = 0; 
            do
            {
                Menu(); //Mostrando as Opções
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
                        Console.WriteLine(modelo.ExercicioQuatro());
                        break;
                    case 5:
                        Console.WriteLine("Informe um número: ");
                        int num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioCinco(num));
                        break;
                    case 6:
                        Console.WriteLine("Informe um número: ");
                        int nub = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioSeis(nub));
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
                        Console.WriteLine("Informe o número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioNove(num));
                        break;
                    case 10:
                        Console.WriteLine("Informe um número primo: ");
                        Console.WriteLine(modelo.ExercicioDez());

                        break;
                    case 11:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.Write(modelo.ExercicioOnze(num));
                        break;

                    case 12:
                        Console.WriteLine("Informe um número");
                        num= Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercícioDoze(num));
                        break;

                    case 13:
                        Console.WriteLine("Informe um número");
                        num = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine(modelo.ExercícioTreze());
                        break;

                    case 14:
                        Console.Write("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercícioQuatorze(num));
                        break;
                        
                    case 15:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercícioQuinze(num));
                        break;
                    case 16:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercícioDezesseis(num));
                        break;
                    case 17:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercícioDezessete(num));
                        break;
                    case 18:
                        Console.WriteLine("Informe um número: ");
                        double num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe um número: ");
                        double num2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercícioDezoito(num1,num2));
                        break;
                    case 19:
                        Console.WriteLine("Informe um número: ");
                        double fahrenheit = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercícioDezenove(fahrenheit));
                        break;
                    case 20:
                        Console.WriteLine("Informe um número: ");
                        double raio = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercícioVinte(raio));
                        break;
                    case 21:
                        Console.WriteLine("Informe um Número: ");
                        double quadrado = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercícioVinteUm(quadrado));
                        break;
                    case 22:
                        Console.WriteLine("Informe um número: ");
                        int nun1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o Segundo Número: ");
                        int nun2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercícioVinteDois(nun1, nun2));
                        break;
                    case 23:
                        Console.WriteLine("Informe um número: ");
                        int primeiro = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o Segundo Número: ");
                        int segundo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercícioVinteTres(primeiro, segundo));
                        break;
                    case 24:
                        Console.WriteLine("Informe um número: ");
                        int maior = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercícioVinteQuatro(maior));
                        break;
                    case 25:
                        Console.WriteLine("Informe um número: ");
                        int nus1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o Segundo Número: ");
                        int nus2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercícioVinteCinco(nus1, nus2));
                        break;
                    case 26:
                        Console.WriteLine("Informe o peso: ");
                        double altura = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a altura: ");
                        double peso = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(modelo.ExercícioVinteSeis(peso, altura));
                        break;
                    case 27:
                        Console.WriteLine("Informe a Idade: ");
                        int dia = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o mes: ");
                        int mes = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o dia: ");
                        int ano = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercícioVinteSete(dia, ano, mes));
                        break;
                    case 28:
                        Console.WriteLine("Informe o salário: ");
                        double salario = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a venda: ");
                        double vendas = Convert.ToDouble(Console.ReadLine());

                   
                        Console.WriteLine(modelo.ExercícioVinteOito(salario, vendas));
                        break;

                    case 29:

                        Console.WriteLine(modelo.ExercícioVinteNove());
                        break;

                    case 30:

                        Console.WriteLine(modelo.ExercícioTrinta());
                        break;

                    case 31:

                        Console.WriteLine(modelo.ExercícioTrintaUm());
                        break;
                    case 32:
                        Console.WriteLine("Informe o Tempo: ");
                        int tempo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe a Velocidade: ");
                        int velocidade = Convert.ToInt32(Console.ReadLine());


                        Console.WriteLine(modelo.ExercícioVinteOito(tempo, velocidade));
                        break;
                    case 33:
                        Console.WriteLine("Digite a base do retangulo: ");
                        int valorBaseRetangulo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite a altura do retangulo: ");
                        int valorAlturaRetangulo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercícioTrintaTres(valorAlturaRetangulo, valorBaseRetangulo));

                        break;
                    case 34:
                        Console.WriteLine("Informe os Votos Brancos: ");
                        int votosBrancos = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe os Votos Nulos: ");
                        int votosNulos = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe os Votos Válidos:");
                        int votosValidos = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o Total de Eleitores: ");
                        int totalEleitores = Convert.ToInt32(Console.ReadLine());

                        modelo.ExercícioTrintaQuatro(votosNulos, votosValidos, votosBrancos, totalEleitores);
                        break;

                    case 35:
                        Console.WriteLine("Digite o custo de fábrica de um carro:");
                        double custoFabrica = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("O custo final ao consumidor é: ");
                        double custoConsumidor = Convert.ToDouble(Console.ReadLine());

                        modelo.ExercícioTrintaCinco();
                        break;
              
                    case 51:
                        modelo.ExercícioCinquentaUm();
                        break;
                    case 52:
                        Console.WriteLine("A média do vetor é: " + modelo.ExercícioCinquentaDois());
                        break;
                    case 53:
                        modelo.ExercícioCinquentaTres();
                        break;
                    case 54:
                        modelo.ExercícioCinquentaQuatro();
                        break;
                    case 55:
                        modelo.ExercícioCinquentaCinco();
                        break;
                    case 56:
                        Console.WriteLine("A soma do vetor é: " + modelo.ExercícioCinquentaSeis());
                        break;
                    case 57:
                        modelo.ExercícioCinquentaSete();
                        break;
                    case 58:
                        Console.WriteLine(modelo.ExercícioCinquentaOito());
                        break;
                    case 59:
                        modelo.ExercícioCinquentaNove();
                        break;
                    case 60:
                        modelo.ExercícioSessenta();
                        break;
                    case 61:
                        Console.WriteLine(modelo.ExercícioSessentaUm());
                        break;

                    default:
                        Console.WriteLine("Código digitado não é válido!");
                        break;       

                }// Fim do Método

            } while (opcao != 0);
        }// Fim do Operação



    }//Fim da Classe
}//Fim do Projeto
