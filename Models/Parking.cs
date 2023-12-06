using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioFundamentos.Utilitaries;

namespace DesafioFundamentos.Models
{
    public class Parking
    {
        public double InitialPrice { get; private set; }
        public double PricePerHour { get; set; }
        List<Vehicle>? RegisteredVehicles { get; set; }

        
        // creates a constructor that instantiates the Vehicle<list> class and gets values for the business rule
        public Parking()
        {
            RegisteredVehicles = new List<Vehicle>();
            Console.Write("Digite o preço inicial: ");
            InitialPrice = double.Parse(Console.ReadLine()!);
            Console.Write("Digite o preço por hora: ");
            PricePerHour = double.Parse(Console.ReadLine()!);   
            Console.Clear();
        }

        /// <summary>
        /// Register an vehicle to the Vehicle list (RegisteredVehicle) based on his Plate(input from user).
        /// </summary>
        public void RegisterVehicle()
        {
            Console.Write("Digite a placa do veículo para estacionar: ");
            string vehiclePlate = Console.ReadLine()!;
            RegisteredVehicles!.Add(new Vehicle(vehiclePlate));
            Console.WriteLine($"Veículo de placa {vehiclePlate} adicionado");
        }

        /// <summary>
        /// removes a vehicle based on the plate stored in the Vehicle list (RegisteredVehicle)
        /// </summary>
        public void RemoveVehicle()
        {
            Console.Write("Informe a placa do veículo que deseja remover: ");
            string plateToRemove = Console.ReadLine()!;

            Vehicle vehicleToRemove = RegisteredVehicles!.FirstOrDefault(v => v.VehiclePlate == plateToRemove)!;
            
            if (vehicleToRemove != null)
            {
                Console.Write("Informe o tempo que o veículo ficou estacionado: ");
                int timeParked = int.Parse(Console.ReadLine()!);
                double totalToPay = PaymentRule.CalculateTime(timeParked, PricePerHour, InitialPrice);

                Console.WriteLine($"O veículo {vehicleToRemove} foi removido com sucesso. " +
                    $"Total a pagar de {totalToPay}");

            }
            else
            {
                Console.WriteLine("Veículo não encontrado na lista");
            }
        }

        /// <summary>
        /// List all the indexes from RegisteredVehicle
        /// </summary>
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
    }
}
