Console.WriteLine("Programmed by: Earl Joshua Perez for TMSPH Back-end Test");
bool tryAgain = true;

while (tryAgain)
{
    Console.Write("Please input number (seat): ");
    int seats = int.Parse(Console.ReadLine());

    // Given Car Rental prices Arrays
    int[] seatCapacities = { 5, 9, 15 }; //changed the capacities
    int[] prices = { 5000, 8000, 11000 }; //changed the prices of M and L
    string[] sizes = { "S", "Med", "L" };

    //Let the price be the max value and be replaced with the cheaper price through for loop
    //for loop repeats 3 times to accommodate the 3 categories
    int carNum = 0;
    int cheapestPrice = int.MaxValue;
    string size = "";

    for (int i = 0; i < 3; i++)
    {
        int numberOfCars = (int)Math.Floor((double)seats / seatCapacities[i]);
        int maxCapacity = numberOfCars * seatCapacities[i];
        int totalPrice = numberOfCars * prices[i];

        if (totalPrice < cheapestPrice && maxCapacity >= seats)
        {
            cheapestPrice = totalPrice;
            size = sizes[i];
            carNum = numberOfCars;
        }
    }

    // Print results
    Console.WriteLine($"{size} x {carNum}");
    Console.WriteLine("Total = PHP " + cheapestPrice);

    //Try Again
    Console.WriteLine("Try Again?(Type Y if Yes. If not, press any key to exit...)");

    var input = Console.ReadLine();

    if (input == "Y" || input == "y")
    {
        tryAgain = true;
    }
    else
    {
        tryAgain = false;
        Console.WriteLine("Thank you for using my program.");
    }
}