namespace HOCrud.Entities
{
    internal class Equipamento
    {
        public string Ativo { get; set; }
        public string TipoDoEquipamento { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public Usuario usuario { get; private set; }

        public override string ToString()
        {
            return  $"\n    Ativo: {Ativo}" +
                    $"\n    Tipo do Equipamento: {TipoDoEquipamento}" +
                    $"\n    Modelo: {Modelo}";
        }

        public Equipamento(string ativo, string tipoDoEquipamento, string modelo, string marca)
        {
            Ativo = ativo;
            TipoDoEquipamento = tipoDoEquipamento;
            Modelo = modelo;
            Marca = marca;
        }

        public Equipamento()
        {
        }
    }
}

