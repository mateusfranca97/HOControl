namespace HOCrud
{
    internal class Operador
    {
        private string _matricula;
        private string _name;
        private string _cep;
        private string _telefone;
        private string _operacao;

        public override string ToString()
        {
            return $"\nMatricula: {_matricula}\nNome: {_name}\nCEP: {_cep}\nTelefone: {_telefone}\nOperação: {_operacao}";
        }

        public Operador()
        {

        }

        public Operador(string matricula, string name, string cep, string telefone, string operacao)
        {
            Matricula = matricula;
            Name = name;
            Cep = cep;
            Telefone = telefone;
            Operacao= operacao;
        }

        public string Matricula 
        { 
            get { return _matricula; }
            set
            {
                if (value.Length != 6)
                {
                    Console.WriteLine($"Matricula {value} Invalida.\nMatricula deve conter 6 digitos: Ex.: 123456");

                } else
                {
                    _matricula = value;
                    Console.WriteLine($"Usuario {value} Cadastrado.");
                }
                
            }
        }
        public string Name 
        { 
            get 
            { 
                return _name; 
            }
            set 
            {
                if (value.Length == 0)
                {
                    Console.WriteLine("Campo nome VAZIO.");
                }
                else
                {
                    _name = value;
                }
            } 
        }
        public string Cep 
        { 
            get { return _cep; }
            set 
            {
                if (value.Length != 8)
                {
                    Console.WriteLine("CEP Invalido.");
                }
                else 
                { 
                    _cep = value; 
                }
            } 
        }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public string Operacao { get => _operacao; set => _operacao = value; }
    }
}
