using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentosComClasses.ConsoleApp
{
    public enum Status
    {
        Aberto,
        Fechado
    }
    internal class Chamado
    {
        public int chamadoId;
        public string titulo;
        public string descricao;
        public DateTime dateAbertura;
        public Equipamento equipamento;
        public Funcionario solicitante;
        public Status status;

        public void Listar()
        {
            Mensagem.Msg("listar chamado");
        }
        public void Cadastrar()
        {
            Mensagem.Sucesso("Cadastrar chamado");
        }
        public void Editar()
        {
            Mensagem.Aviso("Editar chamado");
        }
        public void Excluir()
        {
            Mensagem.Falha("Excluir chamado");
        }
    }
}
