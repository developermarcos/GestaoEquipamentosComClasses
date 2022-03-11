using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentosComClasses.ConsoleApp
{
    internal class Menu
    {
        private static int opcaoSelecionada;
        private static bool menuValido;
        private static bool sairSistema;
        public static int ApresentaMenuPrincipal()
        {

            Mensagem.Titulo("Páginas");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.Write("       ");
            Console.Write($"{Telas.Chamado} ({Telas.Chamado.GetHashCode()})   |   ");
            Console.Write($"{Telas.Equipamentos} ({Telas.Equipamentos.GetHashCode()})   |   ");
            Console.Write($"{Telas.Funcionario} ({Telas.Funcionario.GetHashCode()})");
            Console.WriteLine("\n------------------------------------------------------------------------");
            Console.Write("\nDigite o numero de acordo com a opção selecionada:");
            string lerTela = Console.ReadLine();

            menuValido = int.TryParse(lerTela, out opcaoSelecionada);
            Console.Clear();
            if (menuValido == true)
                return opcaoSelecionada;
            else
                return 404;//Opção invalida

        }
    }
}
