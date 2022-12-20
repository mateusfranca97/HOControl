using HOCrud;
using System.Xml;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {

        List<Operador> operadors= new List<Operador>();
        Operador operador1 = new Operador("123456", "Maria Vitoria", "12345678", "8191234-9876", "Treinamento");
        operadors.Add(operador1);
        int choose = null;
        while (choose != 0)
        {
            Console.WriteLine("");
            Console.WriteLine("0 - Sair do programa.");
            Console.WriteLine("1 - Listar de Cadastro");
            Console.WriteLine("2 - Adicionar");
            Console.WriteLine("3 - Remover");
            Console.Write("Selecione uma Opção: ");
            choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 0:
                    Console.WriteLine("Sair do programa.");
                    choose = 0;
                    break;
                case 1:
                    Console.WriteLine("Listar de Cadastro");
                    if (operadors.Capacity == 0 )
                    {
                        Console.WriteLine("Lista está VAZIA.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        foreach (var item in operadors)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    
                    break;
                case 2:
                    Operador operador = new Operador();
                    Console.WriteLine("Cadastrar");
                    Console.Write("Matricula: ");
                    operador.Matricula = Console.ReadLine();
                    Console.Write("Nome: ");
                    operador.Name = Console.ReadLine();
                    Console.Write("CEP: ");
                    operador.Cep = Console.ReadLine();
                    Console.Write("Telefone: ");
                    operador.Telefone = Console.ReadLine();
                    Console.Write("Operação: ");
                    operador.Operacao = Console.ReadLine();
                    operadors.Add(operador);
                    Console.WriteLine("Usuario Cadastrado");
                    break;
                case 3:
                    Console.WriteLine("Remover");
                    break;
            }

        }
    }
}