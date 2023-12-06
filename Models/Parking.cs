using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Parking
    {
        public double InitialPrice { get; private set; }
        public double PricePerHour { get; set; }
        List<Vehicle>? RegisteredVehicles { get; set; }

        public Parking()
        {
            RegisteredVehicles = new List<Vehicle>();
            Console.Write("Digite o preço inicial: ");
            InitialPrice = double.Parse(Console.ReadLine()!);
            Console.Write("Digite o preço por hora: ");
            PricePerHour = double.Parse(Console.ReadLine()!);   
            Console.Clear();
        }

        public void RegisterVehicle()
        {
            Console.Write("Digite a placa do veículo para estacionar: ");
            string vehiclePlate = Console.ReadLine()!;
            RegisteredVehicles!.Add(new Vehicle(vehiclePlate));
            Console.WriteLine($"Veículo de placa {vehiclePlate} adicionado)");
        }

        public void RemoveVehicle()
        {
            Console.Write("Informe a placa do veículo que deseja remover: ");
            string plateToRemove = Console.ReadLine()!;

            Vehicle vehicleToRemove = RegisteredVehicles!.FirstOrDefault(v => v.VehiclePlate == plateToRemove)!;
            
            if (vehicleToRemove != null)
            {
                Console.Write("Informe o tempo que o veículo ficou estacionado: ");
                int timeParked = int.Parse(Console.ReadLine()!);
                Console.WriteLine($"O veículo {vehicleToRemove} foi removido com sucesso. " +
                    $"Total a pagar de {CalculateTime(timeParked, PricePerHour, InitialPrice)}");
                RegisteredVehicles?.Remove(vehicleToRemove);

            }
            else
            {
                Console.WriteLine("Veículo não encontrado na lista");
                
            }
                       

        }

        public void ListVehicles()
        {
            if(RegisteredVehicles!.Count() > 0)
            {
                int ranking = 1;
                foreach ( Vehicle vehicle in RegisteredVehicles!)
                {
                    
                    Console.WriteLine($"{ranking}. {vehicle}");
                    ranking++;
                }
            }
            else
            {
                Console.WriteLine("Nenhum veículo estacionado.");
            }
        }


        private static string CalculateTime(int hours, double pricePerHour, double initialPrice)
        {
            double calcule = (pricePerHour * hours) + initialPrice;
            return calcule.ToString("F2");
        }
          

    }
}
