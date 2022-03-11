using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentosComClasses.ConsoleApp
{
    public enum OpcoesMenuFuncionarios{
        Listar = 1,
        Cadastrar = 2,
        Editar = 3,
        Excluir = 4
    }
    internal class Funcionario
    {
        public int funcionarioId;
        public string nome;
        public string email;

        public static void Listar()
        {
            Mensagem.Msg("listar funcionario");
        }
        public static void Cadastrar()
        {
            Mensagem.Sucesso("Cadastrar funcionario");
        }
        public static void Editar()
        {
            Mensagem.Aviso("Editar funcionario");
        }
        public static void Excluir()
        {
            Mensagem.Falha("Excluir funcionario");
        }
        public static void ChamaMetodo()
        {
            bool voltarMenuPrincipal = false;
            while (voltarMenuPrincipal == false)
            {
                bool menuValido;
                int opcaoSelecionada;
                Console.WriteLine();
                Mensagem.Msg($"- {OpcoesMenuFuncionarios.Listar} ({OpcoesMenuFuncionarios.Listar.GetHashCode()}) ");
                Mensagem.Msg($"- {OpcoesMenuFuncionarios.Cadastrar} ({OpcoesMenuFuncionarios.Cadastrar.GetHashCode()}) ");
                Mensagem.Msg($"- {OpcoesMenuFuncionarios.Editar} ({OpcoesMenuFuncionarios.Editar.GetHashCode()}) ");
                Mensagem.Msg($"- {OpcoesMenuFuncionarios.Excluir} ({OpcoesMenuFuncionarios.Excluir.GetHashCode()}) ");
                Console.Write("Digite o numero de acordo com a opção selecionada:");
                string lerTela = Console.ReadLine();

                menuValido = int.TryParse(lerTela, out opcaoSelecionada);
                Console.Clear();
                if (menuValido == true)
                    switch (opcaoSelecionada)
                    {
                        case (int)OpcoesMenuFuncionarios.Listar:
                            Listar();
                            break;
                        case (int)OpcoesMenuFuncionarios.Cadastrar:
                            Cadastrar();
                            break;
                        case (int)OpcoesMenuFuncionarios.Editar:
                            Editar();
                            break;
                        case (int)OpcoesMenuFuncionarios.Excluir:
                            Excluir();
                            break;
                        default:
                            Mensagem.Aviso("Menu não encontrado");
                            voltarMenuPrincipal = true;
                            break;
                    }
                else
                {
                    Mensagem.Aviso("Menu não encontrado");
                    voltarMenuPrincipal = true;
                }
            }
        }
    }
}
