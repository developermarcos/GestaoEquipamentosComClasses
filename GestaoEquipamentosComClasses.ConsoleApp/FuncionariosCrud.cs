using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentosComClasses.ConsoleApp
{
    internal class FuncionariosCrud
    {
        public static void Listar(ref Funcionario[] funcionarios)
        {
            Console.Clear();
            Mensagem.Titulo("Lista de Funcionários");
            ImprimirFuncionarios(funcionarios);
            Console.ReadKey();
            Console.Clear();
        }

        public static void Cadastrar(ref Funcionario[] funcionarios)
        {
            Console.Clear();
            string nome, email, telefone;
            int idInsercao;

            Mensagem.Titulo("Cadastrar Funcionário");
            SolicitaInputCadastro(out nome, out email, out telefone);
            if (nome == "")
            {
                Console.Clear();
                return;
            }

            idInsercao = PosicaoInsercaoArray(ref funcionarios);

            Funcionario funcionarioCadastro = new Funcionario(idInsercao, nome, email, telefone);
            funcionarios[idInsercao] = funcionarioCadastro;

            Console.Clear();
            Mensagem.Sucesso("Funcionario cadastrado com sucesso!");
        }
        
        public static void Editar(ref Funcionario[] funcionarios)
        {
            string lerTela, nome, email, telefone; ;
            int id;
            bool validaConversao;

            Console.Clear();
            Mensagem.Titulo("Editar Funcionário");
            Mensagem.Msg("\nSegue lista de funcionarios cadastrados abaixo.");
            ImprimirFuncionarios(funcionarios);

            Console.Write("\nInforme o funcionario que deseja alterar: ");
            lerTela = Console.ReadLine();
            validaConversao = int.TryParse(lerTela, out id);
            if(validaConversao == true && ExisteNoArray(funcionarios, id))
            {
                SolicitaInputCadastro(out nome, out email, out telefone);
                if (nome == "")
                {
                    Console.Clear();
                    return;
                }
                funcionarios[id].nome = nome != "" ? nome : funcionarios[id].nome;
                funcionarios[id].email = email != "" ? email : funcionarios[id].email;
                funcionarios[id].telefone = telefone != "" ? telefone : funcionarios[id].telefone;
                Console.Clear();
                Mensagem.Sucesso("Edição realizada com sucesso");
            }
            else
            {
                Mensagem.Falha("Item não encontrado.");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public static void Excluir(ref Funcionario[] funcionarios)
        {
            string lerTela, nome, email, telefone; ;
            int id;
            bool validaConversao;

            Console.Clear();
            Mensagem.Titulo("Editar Funcionário");
            Mensagem.Msg("\nSegue lista de funcionarios cadastrados abaixo.");
            ImprimirFuncionarios(funcionarios);

            Console.Write("\nInforme o funcionario que deseja excluir: ");
            lerTela = Console.ReadLine();
            validaConversao = int.TryParse(lerTela, out id);
            if (validaConversao == true && ExisteNoArray(funcionarios, id))
            {
                funcionarios[id].nome = "";
                funcionarios[id].email = "";
                funcionarios[id].telefone = "";
                Console.Clear();
                Mensagem.Sucesso("Exclusão realizada com sucesso");
            }
            else
            {
                Mensagem.Falha("Item não encontrado.");
                Console.ReadKey();
                Console.Clear();
            }
        }

        #region auxiliares
        private static void SolicitaInputCadastro(out string nome, out string email, out string telefone)
        {
            do
            {
                Console.Write("Informe o nome no mínimo 6 digitos ou enter para continuar: ");
                nome = Console.ReadLine();
            } while (nome != "" && nome.Length < 6);
            if(nome != "")
            {
                Console.Write("Informe o email: ");
                email = Console.ReadLine();
                Console.Write("Informe o telefone: ");
                telefone = Console.ReadLine();
            }
            else
            {
                email = "";
                telefone = "";
            }
        }
        private static int PosicaoInsercaoArray(ref Funcionario[] funcionarios)
        {
            int posicao = -1;//Não há posições -1

            for (int i = 0; i < funcionarios.Length; i++)
            {
                if(funcionarios[i] == null || funcionarios[i].nome == null)
                {
                    posicao = i;
                    break;
                }

            }

            return posicao;
        }
        private static void ChamadaMetodos(string lerTela, ref Funcionario[] funcionarios)
        {
            OpcoesFuncionarios opcao;
            int opcoes;

            if (int.TryParse(lerTela, out opcoes) == false)
            {
                Console.Clear();
                Error.PaginaError("Opção não encontrada ou informada de forma errada.");
            }
            else
            {
                switch (opcoes)
                {
                    case (int)OpcoesFuncionarios.Cadastrar:
                        Cadastrar(ref funcionarios);
                        break;
                    case (int)OpcoesFuncionarios.Editar:
                        Editar(ref funcionarios);
                        break;
                    case (int)OpcoesFuncionarios.Listar:
                        Listar(ref funcionarios);
                        break;
                    case (int)OpcoesFuncionarios.Excluir:
                        Excluir(ref funcionarios); 
                        break;
                    default:
                        Console.Clear();
                        Error.PaginaError("Opção não encontrada ou informada de forma errada.");
                        break;
                }
            }
        }
        public static void ImprimirFuncionarios(Funcionario[] funcionarios)
        {
            foreach (var funcionario in funcionarios)
            {
                if (funcionario != null && funcionario.nome != "")
                {
                    funcionario.ApresentaFuncionario();
                }
            }
        }
        private static bool ExisteNoArray(Funcionario[] funcionarios, int id)
        {
            bool existe = false;

            if (funcionarios[id] != null && funcionarios[id].nome != "")
                existe = true;

            return existe;
        }
        #endregion
        #region opções menu
        public static void ApresentaOpcoesCrud(ref Funcionario[] funcionarios)
        {
            string opcaoTela;
            
            opcaoTela = PrintOpcoes();

            ChamadaMetodos(opcaoTela, ref funcionarios);            
        }
        private static String PrintOpcoes()
        {
            String opcao;
            
            Mensagem.Titulo("Funcionario");
            Console.WriteLine(" -------------------------------------------------------");
            Console.Write($"| {OpcoesFuncionarios.Listar} ({OpcoesFuncionarios.Listar.GetHashCode()}) | ");
            Console.Write($"{OpcoesFuncionarios.Cadastrar} ({OpcoesFuncionarios.Cadastrar.GetHashCode()}) | ");
            Console.Write($"{OpcoesFuncionarios.Editar} ({OpcoesFuncionarios.Editar.GetHashCode()}) | ");
            Console.Write($"{OpcoesFuncionarios.Excluir} ({OpcoesFuncionarios.Excluir.GetHashCode()}) |");
            Console.WriteLine("\n -------------------------------------------------------");
            Console.Write("\nDigite o numero de acordo com a opção selecionada: ");

            opcao = Console.ReadLine();
            
            return opcao;
        }
        #endregion
    }
}
