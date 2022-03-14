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
        public static Telas ApresentaMenuPrincipal()
        {
            Telas telaSelecionada;

            Mensagem.Titulo("Páginas");
            Console.WriteLine(" -------------------------------------------------------------");
            Console.Write($"| {Telas.Chamado} ({Telas.Chamado.GetHashCode()}) | ");
            Console.Write($"{Telas.Equipamentos} ({Telas.Equipamentos.GetHashCode()}) | ");
            Console.Write($"{Telas.Funcionario} ({Telas.Funcionario.GetHashCode()}) | ");
            Console.Write($"{Telas.Sair} ({Telas.Sair.GetHashCode()}) |");
            Console.WriteLine("\n -------------------------------------------------------------");
            Console.Write("\nDigite o numero de acordo com a opção selecionada: ");
            string lerTela = Console.ReadLine();

            menuValido = int.TryParse(lerTela, out opcaoSelecionada);
            Console.Clear();

            if (menuValido == true)
            {
                switch (opcaoSelecionada)
                {
                    case (int)Telas.Chamado:
                        telaSelecionada = Telas.Chamado;
                        break;
                    case (int)Telas.Equipamentos:
                        telaSelecionada = Telas.Equipamentos;
                        break;
                    case (int)Telas.Funcionario:
                        telaSelecionada = Telas.Funcionario;
                        break;
                    default:
                        telaSelecionada = Telas.Error;
                        break;
                }
            }
            else
                telaSelecionada = Telas.Error;//Opção invalida

            return telaSelecionada;
        }
    }
}
