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
                                    "16. Exercício 16\n");
                                           
                                                 
                                        
        
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

                    default:
                        Console.WriteLine("Código digitado não é válido!");
                        break;

                }// Fim do Método

            } while (opcao != 0);
        }// Fim do Operação



    }//Fim da Classe
}//Fim do Projeto
