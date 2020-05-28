using System;
//facilitar na escrita
using static System.Console;
namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("-Hello,How are you today?");

            Smartphone smartphone = new Smartphone();

            WriteLine("\nDiga o modelo do seu smartphone: ");
            smartphone.modelo = ReadLine();
            
            WriteLine("Qual a cor do smartphone: ");
            smartphone.cor = ReadLine();

            WriteLine("\nDigite o tamanho do smartphone (Escala de 1 a 10): ");
            smartphone.tamanho = float.Parse(Console.ReadLine());

            WriteLine("\nDeseja ligar o smartphone? Sim/Não ");
            smartphone.ligado = smartphone.Ligar(Console.ReadLine());

            WriteLine("O que queres fazer agora: (c)Call,(m)Mensagem,(d)Desligar");
            string resposta = ReadLine();

            switch(resposta){
                case "d":
                    WriteLine("Telefone foi desligado com sucesso");
                break;
                case "c":
                    if(smartphone.ligado == true){
                        WriteLine("Ligando...");
                    }else{
                        WriteLine("Por favor ligue seu telefone");
                    }
                break;
                case "m":
                    if(smartphone.ligado == true){
                        WriteLine("Enviando mensagem");
                    }else{
                        WriteLine("Por favor ligue seu telefone");
                    }
                break;
                default:
                    WriteLine("Opção digitada não foi encontrada");
                break;
            }
        }
    }
}
