using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentosComClasses.ConsoleApp
{
    internal class Error
    {
        public static void PaginaError(string mensagem)
        {
            Mensagem.Titulo("Error");
            Mensagem.Falha(mensagem);
            Mensagem.Msg("");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
