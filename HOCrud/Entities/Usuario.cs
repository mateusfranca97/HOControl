using Microsoft.VisualBasic;
using System.Collections.ObjectModel;

namespace HOCrud.Entities
{
    internal class Usuario
    {
        public string Matricula { get; set; }
        public string Name { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public string Cargo { get; set; }
        public string Operacao { get; set; }

        public Collection<Equipamento> equipamento { get; set; }

        public override string ToString()
        {
            return
                $"\nMatricula: {Matricula}" +
                $"\nNome: {Name}" +
                $"\nCEP: {Cep}" +
                $"\nTelefone: {Telefone}" +
                $"\nOperação: {Operacao}" +
                $"\nCargo: {Cargo}";
        }

        public Usuario()
        {

        }

        public Usuario(string matricula, string name, string cep, string telefone, string operacao, string cargo)
        {
            Matricula = matricula;
            Name = name;
            Cep = cep;
            Telefone = telefone;
            Operacao = operacao;
            Cargo = cargo;
            this.equipamento = equipamento;
        }


    }
}
