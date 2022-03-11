using System;

namespace GestaoEquipamentosComClasses.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int telaSelecionada;
            int menuSelecionado;
            do
            {
                telaSelecionada = Menu.ApresentaMenuPrincipal();

                if(telaSelecionada != ((int)Telas.Sair))
                {
                    switch (telaSelecionada)
                    {
                        case (int)Telas.Chamado:
                            //menuSelecionado = Menu.ApresentaMenuCrud("Chamados");
                            break;
                        case (int)Telas.Equipamentos:
                            //menuSelecionado = Menu.ApresentaMenuCrud("Equipamentos");
                            break;
                        case (int)Telas.Funcionario:
                            Funcionario.ChamaMetodo();
                            break;
                        //default:
                            //Apresenta tela erro
                    }

                }
                else
                    break;             
            } while (true);
        }
    }
}
