using HOCrud.Entities;

internal class Program
{
    private static void Main(string[] args)
    {

        List<Usuario> operadors = new List<Usuario>();
        Usuario operador1 = new Usuario
        {
            Matricula = "331276",
            Name = "Mateus Gomes de França",
            Cep = "50920110",
            Telefone = "81982082488",
            Operacao = "TI",
            Cargo = "Analista de TI Jr"
        };

        operadors.Add(operador1);
        foreach (var item in operadors)
        {
            Console.WriteLine(item);
        }
    }
}