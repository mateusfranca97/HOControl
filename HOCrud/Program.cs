using HOCrud.Entities;


internal class Program
{
    private static void Main(string[] args)
    {
        List<Usuario> OperadorList = new List<Usuario>();

        Usuario operador1 = new Usuario
        {
            Matricula = "331276",
            Name = "Mateus Gomes de França",
            Cep = "50920110",
            Telefone = "81982082488",
            Operacao = "TI",
            Cargo = "Analista de TI Jr",
            Desktop = new Equipamento("A000001","DESKTOP","DELL 3080", "DELL"),
            Monitor = new Equipamento("A000002", "MONITOR", "BR25A32", "DELL")

        };

        OperadorList.Add(operador1);
        foreach (var item in OperadorList)
        {
            Console.WriteLine(item);
        }
    }
}