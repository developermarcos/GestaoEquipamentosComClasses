using System;

namespace GestaoEquipamentosComClasses.ConsoleApp
{
    internal class Program
    {
        public static Funcionario[] funcionarios = new Funcionario[100];
        public static Equipamento[] Equipamentos = new Equipamento[100];
        public static Chamado[] chamados = new Chamado[100];
        static void Main(string[] args)
        {
            Telas telaSelecionada;
            int menuSelecionado;
            do
            {
                telaSelecionada = Menu.ApresentaMenuPrincipal();

                if((int)telaSelecionada != ((int)Telas.Sair))
                {
                    if (telaSelecionada == Telas.Error)
                    {
                        Error.PaginaError("Pagina não encontrada");
                    }
                    else
                    {
                        switch (telaSelecionada)
                        {
                            case Telas.Funcionario:
                                FuncionariosCrud.ApresentaOpcoesCrud(ref funcionarios);
                                break;
                        }
                    }
                }
                else
                    break;             
            } while (true);
        }
    }
}
