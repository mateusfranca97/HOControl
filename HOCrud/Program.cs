using HOCrud.Entities;


internal class Program
{
    private static void Main(string[] args)
    {
        List<Usuario> OperadorList = new List<Usuario>();

        int option;
        do
        {
            Console.WriteLine("Basic CRUD");
            Console.WriteLine("1 - CADASTRAR");
            Console.WriteLine("2 - DELETAR");
            Console.WriteLine("3 - LISTAR");
            Console.Write("SELECIONE UMA OPÇÃO: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 0:
                    Console.WriteLine();
                    Console.WriteLine("SAINDO DO CRUD...");
                    break;
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("CADASTRAR SAIDA");
                    Console.Write("Matricula: ");
                    string matricula = Console.ReadLine();

                    Console.Write("Nome: ");
                    string name = Console.ReadLine();

                    Console.Write("CEP: ");
                    string cep = Console.ReadLine();

                    Console.Write("Telefone: ");
                    string telefone = Console.ReadLine();

                    Console.Write("Operação: ");
                    string operacao = Console.ReadLine();

                    Console.Write("Cargo: ");
                    string cargo = Console.ReadLine();

                    Console.WriteLine("\nMonitor:\n");
                    Equipamento monitor = new Equipamento();
                    Console.Write(" Ativo: ");
                    monitor.Ativo = Console.ReadLine();

                    Console.Write(" Tipo do Equipamento: ");
                    monitor.TipoDoEquipamento = Console.ReadLine();

                    Console.Write(" Marca: ");
                    monitor.Marca = Console.ReadLine();

                    Console.Write("Modelo: ");
                    monitor.Modelo = Console.ReadLine();

                    Console.Write("\nDesktop:\n");
                    Equipamento desktop = new Equipamento();
                    Console.Write("Ativo: ");
                    desktop.Ativo = Console.ReadLine();

                    Console.Write("Tipo do Equipamento: ");
                    desktop.TipoDoEquipamento = Console.ReadLine();

                    Console.Write("Marca: ");
                    desktop.Marca = Console.ReadLine();

                    Console.Write("Modelo: ");
                    desktop.Modelo = Console.ReadLine();

                    Usuario usuario = new Usuario(matricula,name,cep,telefone,operacao,cargo, monitor, desktop);

                    OperadorList.Add(usuario);
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("DELETAR SAIDA");
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("LISTAR SAIDAS");
                    if (OperadorList.Count != 0)
                    {
                        foreach (var item in OperadorList)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else
                    {
                        Console.WriteLine("A lista está vazia.\n\n");
                    }
                    break;
                default:
                    Console.WriteLine("OPÇÃO INVALIDA!");
                    Console.WriteLine();
                    break;
            }

        } while (option != 0);

        //Usuario operador = new Usuario
        //(
        //    matricula: "331276",
        //    name: "Mateus Gomes de França",
        //    cep: "50920110",
        //    telefone: "81982082488",
        //    operacao: "TI",
        //    cargo: "Analista de TI Jr",
        //    new Equipamento("A000001", "DESKTOP", "DELL 3080", "DELL"),
        //    new Equipamento("A000002", "MONITOR", "BR25A32", "DELL")

        //);


    }
}