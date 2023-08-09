namespace DesafioFundamentos.Models
{
    public class ParkingLot
    {
        private decimal initialPrice = 0;
        private decimal hourlyPrice = 0;
        private List<string> vehicles = new List<string>();

        public ParkingLot(decimal initialPrice, decimal hourlyPrice)
        {
            this.initialPrice = initialPrice;
            this.hourlyPrice = hourlyPrice;
        }

        public void AddVehicle()
        {
            Console.WriteLine("Enter the vehicle's plate to park:");
            vehicles.Add(Console.ReadLine());
        }

        public void RemoveVehicle()
        {
            string plate = "";

            Console.WriteLine("Enter the vehicle's plate to remove:");
            plate = Console.ReadLine();

            if (vehicles.Any(x => x.ToUpper() == plate.ToUpper()))
            {
                decimal totalAmount = 0;
                int hours = 0;

                Console.WriteLine("Enter the number of hours the vehicle was parked:");
                hours = Convert.ToInt32(Console.ReadLine());

                totalAmount = ((initialPrice + hourlyPrice) * hours);

                Console.WriteLine($"The vehicle {plate} has been removed, and the total price is: R$ {totalAmount}");
            }
            else
            {
                Console.WriteLine("Sorry, this vehicle is not parked here. Please check if you entered the correct plate.");
            }
        }

        public void ListVehicles()
        {
            if (vehicles.Any())
            {
                Console.WriteLine("The parked vehicles are:");
                foreach (string item in vehicles)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("There are no parked vehicles.");
            }
        }
    }
}
