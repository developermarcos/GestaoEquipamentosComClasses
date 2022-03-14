using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentosComClasses.ConsoleApp
{
    public enum OpcoesFuncionarios
    {
        Listar = 1,
        Cadastrar = 2,
        Editar = 3,
        Excluir = 4,
        Error
    }
    internal class Funcionario
    {
        public int funcionarioId;
        public string nome;
        public string email;
        public string telefone;
        public Funcionario(int id, string nome, string email, string telefone)
        {
            this.funcionarioId = id;
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
        }
        public void ApresentaFuncionario()
        {
            Console.WriteLine($"ID: {funcionarioId} | Funcionario: {nome} | Email: {email} | Telefone: {telefone}");
        }
    }
}
