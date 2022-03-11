using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentosComClasses.ConsoleApp
{
    internal class Equipamento
    {
        public int equipamentoId;
        public string nome;
        public string serial;
        public string fabricante;
        public DateTime dataFabricacao;
        public decimal preco;

        public void Listar()
        {
            Mensagem.Msg("listar funcionario");
        }
        public void Cadastrar()
        {
            Mensagem.Sucesso("Cadastrar funcionario");
        }
        public void Editar()
        {
            Mensagem.Aviso("Editar funcionario");
        }
        public void Excluir()
        {
            Mensagem.Falha("Excluir funcionario");
        }
    }
}
