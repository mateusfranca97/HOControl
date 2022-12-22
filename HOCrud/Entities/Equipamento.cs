namespace HOCrud.Entities
{
    internal class Equipamento
    {
        public string Ativo { get; set; }
        public string TipoDoEquipamento { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public Usuario usuario { get; set; }
        public Equipamento()
        {

        }

        public Equipamento(string ativo, string tipoDoEquipamento, string modelo, string marca)
        {
            Ativo = ativo;
            TipoDoEquipamento = tipoDoEquipamento;
            Modelo = modelo;
            Marca = marca;
        }
    }
}

