
namespace DesafioFundamentos.Models
{
    internal class Menu
    {
        public int Input { get; set; }
        readonly Parking Park = new();

   

        public void MenuChoice()
        {
            Console.WriteLine("Digite uma opção abaixo: ");
            MenuOutput();
            Input = int.Parse(Console.ReadLine()!);
            if (Input != 0)
            {

                while (true)
                {
                    switch (Input)
                    {
                        case 1:
                            Console.Clear();
                            Park.RegisterVehicle();
                            Console.WriteLine("\nTecle para continuar...");
                            Console.ReadLine();
                            Console.Clear();
                            MenuChoice();
                            break;
                        case 2:
                            Console.Clear();
                            Park.RemoveVehicle();
                            Console.WriteLine("\nTecle para continuar...");
                            Console.ReadLine();
                            Console.Clear();
                            MenuChoice();
                            break;
                        case 3:
                            Console.Clear();
                            Park.ListVehicles();
                            Console.WriteLine("\nTecle para continuar...");
                            Console.ReadLine();
                            Console.Clear();
                            MenuChoice();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Fechando o programa...");
                            return;
                        default:
                            Console.WriteLine("Não foi possível entender o seu comando.");
                            Console.WriteLine("\nTecle para continuar...");
                            Console.ReadLine();
                            MenuChoice();
                            break;
                    }
                    Console.WriteLine("Encerrando o programa.");
                }
                
            }
        }

        public static void MenuOutput()
        {
            Console.WriteLine("1 - Cadastrar Veículo");
            Console.WriteLine("2 - Remover Veículo");
            Console.WriteLine("3 - Listar Veículos");
            Console.WriteLine("4 - Encerrar");
        }




    }
}
