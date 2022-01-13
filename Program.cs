using System;
using System.IO;
using System.Threading;

namespace ExercisesFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

            static void Menu(){

            Console.Clear();
            System.Console.WriteLine("Bem vindo ao conjunto de exercícios: ");
            Thread.Sleep(1000);
            System.Console.WriteLine("Selecione abaixo oque gostaria de fazer: ");
            Thread.Sleep(1000);
            System.Console.WriteLine("0 - Sair");
            System.Console.WriteLine("1 - Calculadora");
            System.Console.WriteLine("2 - Cronômetro");
            System.Console.WriteLine("3 - Editor de textos");
            var option = int.Parse(Console.ReadLine());

            switch(option){
            case 0 : System.Console.WriteLine("GoodBye!");
             Thread.Sleep(1500); 
             Environment.Exit(0);break;
            case 1 : CalculadoraMenu();break;
            case 2 : CronometroMenu();break;
            case 3 :EditorMenu();break;
            default : System.Console.WriteLine("Opção inválida");
            System.Console.WriteLine("O programa será fechado.");
            Thread.Sleep(500);
            Environment.Exit(0);
            ;break;
            }

       }
       

           static void CalculadoraMenu(){

               Console.Clear();
               System.Console.WriteLine("Entre com uma das opções abaixo:");
               Thread.Sleep(1000);
               System.Console.WriteLine("1 - Soma");
               System.Console.WriteLine("2 - Subtração");
               System.Console.WriteLine("3 - Multiplicação");
               System.Console.WriteLine("4 - Divisão");
               System.Console.WriteLine("0 - Voltar ao menu principal");
                var option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1 : Soma();break;
                    case 2 : Subtracao();break;
                    case 3 : Multiplicacao();break;
                    case 4 : Divisao();break;
                    case 0 : Menu(); break;
                    default: System.Console.WriteLine("Opção inválida!Voltando ao menu principal.");
                    Thread.Sleep(1000);
                    Menu();
                    break;
                }


           } static void Soma(){
               Console.Clear();
               System.Console.WriteLine("Entre com os valores para a soma: ");
               System.Console.WriteLine("valor 1:");
               var valor1 = double.Parse(Console.ReadLine());
               System.Console.WriteLine("Valor 2 ");
               var valor2 = double.Parse(Console.ReadLine());
               var total = valor1 + valor2;
               System.Console.WriteLine("O resultado é: " + total.ToString("F2"));
               Thread.Sleep(1000);
               CalculadoraMenu();
               
           } 
             static void Subtracao(){
                 Console.Clear();
               System.Console.WriteLine("Entre com os valores para a subtração: ");
               System.Console.WriteLine("valor 1:");
               var valor1 = double.Parse(Console.ReadLine());
               System.Console.WriteLine("Valor 2 ");
               var valor2 = double.Parse(Console.ReadLine());
               var total = valor1 - valor2;
               System.Console.WriteLine("O resultado é: " + total.ToString("F2"));
               Thread.Sleep(1000);
               CalculadoraMenu();
             }
             static void Multiplicacao(){
                 Console.Clear();
               System.Console.WriteLine("Entre com os valores para a multiplicação: ");
               System.Console.WriteLine("valor 1:");
               var valor1 = double.Parse(Console.ReadLine());
               System.Console.WriteLine("Valor 2 ");
               var valor2 = double.Parse(Console.ReadLine());
               var total = valor1 * valor2;
               System.Console.WriteLine("O resultado é: " + total.ToString("F2"));
               Thread.Sleep(1000);
               CalculadoraMenu();
             }
             static void Divisao(){

                Console.Clear();
               System.Console.WriteLine("Entre com os valores para a divisão: ");
               System.Console.WriteLine("valor 1:");
               var valor1 = double.Parse(Console.ReadLine());
               System.Console.WriteLine("Valor 2 ");
               var valor2 = double.Parse(Console.ReadLine());
               var total = valor1 / valor2;
               System.Console.WriteLine("O resultado é: " + total.ToString("F2"));
               Thread.Sleep(1000);
               CalculadoraMenu();
                 
             }


       
       static void CronometroMenu(){
           Console.Clear();
           System.Console.WriteLine("Escolha uma das opções abaixo: ");
           Thread.Sleep(1000);
           System.Console.WriteLine("1 - Cronômetro ");
           System.Console.WriteLine("2 - Contagem regressiva");
           System.Console.WriteLine("0 - Voltar ao menu principal");
           var option = char.Parse(Console.ReadLine());

           switch (option)
           {
                case '1' : Cronometro();break;
                case '2' : Regressivo();break;
                case '0': Menu();break; 
                default:System.Console.WriteLine("Opção inválida");
            System.Console.WriteLine("O programa será fechado.");
            Thread.Sleep(500);
            Environment.Exit(0);
            break;
           }

       }

       static void Cronometro(){
           Console.Clear();
           System.Console.WriteLine("Cronômetro:");
           System.Console.WriteLine("Entre com um número para o final da contagem: ");
           System.Console.WriteLine("Coloque s para segundo ou m para minutos no final do número(Ex: 2s)");
           var final = Console.ReadLine();
           var onlyNumber = final.Substring(0,final.Length-1);
           var type = final.Substring(final.Length-1,1).ToLower();
           var time = int.Parse(onlyNumber);
           System.Console.WriteLine(type);
           if(type == "m"){

              
              time = time*60;
           }
            
           for (int i = 0; i <= time; i++)
           {
               Console.Clear();
               System.Console.Write(i);
               Thread.Sleep(1000);
               
           }

            Thread.Sleep(1000);
            CronometroMenu();


       }
       static void Regressivo(){
           Console.Clear();
           System.Console.WriteLine("Contagem Regressiva:");
           System.Console.WriteLine("Entre com um número para o começo da contagem: ");
           System.Console.WriteLine("Coloque s para segundo ou m para minutos no final do número(Ex: 2s)");
           var final = Console.ReadLine();
           var onlyNumber = final.Substring(0,final.Length-1);
           var type = final.Substring(final.Length-1,1).ToLower();
           var time = int.Parse(onlyNumber);
            var i = 0;
           if(type == "m"){

              
              time = time*60;
           }
           for ( i = time; i >= 0; i--)
           {
               Console.Clear();
                System.Console.Write(i);
                Thread.Sleep(1000);
                
           }
            
            Thread.Sleep(1000);
            CronometroMenu();
       }
       static void EditorMenu(){
           Console.Clear();
           System.Console.WriteLine("Entre com uma da opções abaixo:");
           Thread.Sleep(800);
           System.Console.WriteLine(" 0 - Voltar ao menu principal");
           System.Console.WriteLine("1 - Abrir arquivo");
           System.Console.WriteLine("2 - Criar novo arquivo");
           var option = char.Parse(Console.ReadLine());
           switch (option)
           {
               case '0' : Menu();break;
               case '1' : EditorAbrir();break;
               case '2' : EditorCriar();break;
               default: System.Console.WriteLine("Opção inválida!Retornando ao menu principal.");
            Menu();break;
           }

       }
       static void EditorAbrir(){

           Console.Clear();
           System.Console.WriteLine("Abrir arquivo:");
           Thread.Sleep(800);
           System.Console.WriteLine("Entre com o caminho do arquivo:(Ex C:\\....)");
           System.Console.WriteLine("Aperte ESC para sair.");
           var path = Console.ReadLine();
           using (var file = new StreamReader(path))
           {   Console.Clear();
                System.Console.WriteLine(file);
                System.Console.WriteLine("");
           }

           
       }
       static void EditorCriar(){
                Console.Clear();
                System.Console.WriteLine("Criar arquivo");
                System.Console.WriteLine("Digite o texto abaixo e utilize ESC para sair.");
                Thread.Sleep(800);

               // while (Console.ReadKey() != ConsoleKeyInfo.ESCAPE )  Continuar daqui,criando um mapeamento de esc e a criacao e save do texto...
                {
                     
                }


       }
    }
}
