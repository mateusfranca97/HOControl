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
        public Equipamento Monitor { get; set; }
        public Equipamento Desktop { get; set; }

        public override string ToString()
        {
            return
                $"\nMatricula: {Matricula}" +
                $"\nNome: {Name}" +
                $"\nTelefone: {Telefone}" +
                $"\nCEP: {Cep}" +
                $"\nOperação: {Operacao}" +
                $"\nCargo: {Cargo}" +
                $"\n---------------------" +
                $"\nDesktop: {Desktop}" +
                $"\nMonitor: {Monitor}";
        }

        public Usuario(
            string matricula, 
            string name, 
            string cep, 
            string telefone, 
            string operacao, 
            string cargo, 
            Equipamento monitor, 
            Equipamento desktop)
        {
            Matricula = matricula;
            Name = name;
            Cep = cep;
            Telefone = telefone;
            Operacao = operacao;
            Cargo = cargo;
            Monitor = new Equipamento(monitor.Ativo, monitor.TipoDoEquipamento, monitor.Modelo, monitor.Marca);
            Desktop = new Equipamento(desktop.Ativo, desktop.TipoDoEquipamento, desktop.Modelo, desktop.Marca);
        }

        public Usuario(string matricula, string name, string cep, string telefone, string operacao, string cargo)
        {
            Matricula = matricula;
            Name = name;
            Cep = cep;
            Telefone = telefone;
            Operacao = operacao;
            Cargo = cargo;
        }
    }
}
