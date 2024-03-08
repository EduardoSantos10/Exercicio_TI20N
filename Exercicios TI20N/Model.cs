using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_TI20N
{



    class Model
    {

        //Construtor
        public Model()
        {




        }//Fim do Construtor 

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

        //Faça um programa que imprima os números pares de 1 a 20.
        public string ExercicioDois()
        {

            string resultado = "";
            for (int i = 0; i < 20; i++)
            {

                if ((i + 1) % 2 == 0)
                {

                    resultado += "\n" + (i + 1);


                }// fim do if

            }// Fim do For
            return resultado;

        }// Fim do Dois

        // Exercício 3: Faça uma soma que calcule a soma dos números de 1 a 100.
        public int ExercicioTres()
        {
            int resultado = 0;
            for (int i = 1; i <= 100; i++)
            {
                resultado += i;
            }// Fim do For
            return resultado;
        }// Fim do Três

        // Exercício 4: Faça um programa que imprima os múltiplos de 5 de 1 a 50.
        public string ExercicioQuatro()
        {
            string resultado = "";
            for (int i = 1; i < 50; i++)
            {

                if ((i + 1) % 5 == 0)
                {

                    resultado += "\n" + (i + 1);


                }// fim do if

            }// Fim do For
            return resultado;

        }//Fim do Quatro

        //Exercício 5: Faça um programa que peça ao usuário um número e imprima se é par ou ímpar.

        public string ExercicioCinco(int nub)
        {


            if (nub % 2 == 0)
            {
                return nub + "Par";

            }
            else
            {

                return nub + "ímpar";


            }




        }//Fim do Cinco


        //Exercício 6: Faça um programa que peça ao usuário um número e imprima se é positivo, negativo ou zero.

        public string ExercicioSeis(int nub)
        {
            if (nub > 0)
            {
                return "Positivo";

            }
            else if (nub < 0)
            {

                return "Negativo";


            }
            else
            {

                return "O número informado é Zero";


            }// Fim do IF

        }// Fim do Seis

        // Exercício 7: Faça um programa que peça ao usuário um
        // Número e imprima a tabuada desse número

        public string ExercicioSete(int num)
        {


            string resultado = "";

            resultado += "Tabuada de " + num;
            for (int i = 0; i <= 10; i++)
            {

                resultado += "\n" + num + " * " + i + " = " + (num * i);



            }//Fim do Método For
            return resultado;

        } // Fim do Sete


        //Exercício 8: Faça um programa que peça ao usuario um número e
        //imprima os numeros de 1 até esse número

        public string ExercicioOito(int num)
        {

            string resultado = "";
            for (int i = 0; i < num; i++)
            {
                resultado += "\n" + (1 + i);
            }// Fim do For
            return resultado;


        }// Fim do Oito

        //Exercício 9: Faça um programa que peça ao usuário um número e
        //Imprima a soma dos números de 1 até esse número.

        public int ExercicioNove(int num)
        {

            int resultado = 0;

            for (int i = 0; i <= num; i++)
            {
                resultado += i;
            }// Fim do For
            return resultado;
        }//Fim do Nove


        //Exercício 10: Faça um programa que imprima os números primos de 1 a 20.
        public string ExercicioDez()
        {

            string primos = "2 3 5";

            for (int i = 2; i <= 20; i++)
            {
                if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0)
                {

                    primos += " " + i;

                }


            }// Fim do For
            return primos;

        }//Fim do Dez

        //Exercício 11: Faça um programa que peça ao usuário um
        // número e verifique se é primo
        public string ExercicioOnze(int num)
        {


            if (num % 2 != 0 && num % 3 != 0 && num % 5 != 0)
            {

                return "Primo!";

            }
            else if (num == 2 || num == 3 || num == 5)
            {

                return "Primo!";


            }
            else
            {

                return "Não Primo!";

            }//Fim do IF


        }//Fim do Onze


        //Exercício 12: Faça um programa que calcule o fatorial de um número
        public int ExercícioDoze(int num)
        {

            int fatorial = 1;
            for (int i = num; i >= 1; i--)
            {

                fatorial *= i;

            }//Fim do For

            return fatorial;



        }// Fim do Doze

        //Exercício 13: Faça um programa que imprima uma sequencia de Fibonacci
        //até o décimo termo
        public string ExercícioTreze()
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


            }// Fim do For

            return resultado;

        }//Fim do Treze

        //Exercício 14: Faça um programa que peça ao usuário
        // um número e imprima se é número de Fibonacci

        public string ExercícioQuatorze(int num) 
        {

            string resultado = "0 1";

            int fib1 = 0;
            int fib2 = 1;
            int fib3 = 0;

            for (int i = 1; i <= num-2; i++)
            {


                fib3 = fib1 + fib2;
                resultado += " " + fib3;
                fib1 = fib2;
                fib2 = fib3;


            }// Fim do For

            return resultado;


        }// Fim do Quatorze


        // Exercício 15: Faça um programa que peça ao usuário um
        // número e calcule a soma dos seus dígitos.
        public int ExercícioQuinze(int num)
        {

            string resultado = "" + num; //Convertendo número para texto
            int tamanho = resultado.Length; //Retorna o tamanho do texto
            int soma = 0;

            for (int i = 0; i < tamanho; i++ ) 
            { 
            
                soma += Convert.ToInt32(resultado.Substring(i, 1));
            
            }// Fim do For
            
            return soma;
            
        }// Fim do Quinze





        // Exercício 16: Faça um programa que peça ao usuário um número
        // e imprima os números pares e impares de 1 até esse número.
        public string ExercícioDezesseis(int num)
        {

            string par = "";
            string impar = "";

            for (int i = 1; i <= num; i++ ) 
            {

                if (i % 2 == 0)
                {


                    par += "" + i;


                }
                else 
                {

                    impar += "" + i;
                
         
                }
            
            
            }

            return "pares " + par + "\nImpares: " + impar;


        }




    }//Fim da Classe




}//Fim do Projeto