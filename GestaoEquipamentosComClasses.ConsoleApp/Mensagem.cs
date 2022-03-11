using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentosComClasses.ConsoleApp
{
    internal class Mensagem
    {
        public static void Titulo(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("-------------------------------------------------------"+mensagem+"-------------------------------------------------------");
            Console.ResetColor();
        }
        public static void Sucesso(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }
        public static void Aviso(string mensagem)
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }
        public static void Falha(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }
        public static void Msg(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }
    }
}
