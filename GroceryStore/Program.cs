public class Program
{
    public static void Main(string[] args)
    {
        //Create Random generator
        Random rand = new Random();
        
        //Create Store Object
        Store store = new Store("Joe's Crab Leg Emporium");

        //Add an item to our store
        store.AddItem("Yummy Crab Leg");

        //Create a singular customer
        Customer customer = new Customer(0, "Someone", store);


        //Counter for the simulation
        int day = 1;
        //Infinite loop to run the simulation
        while (true)
        {
            Console.WriteLine("Day " + day + " at Joe's Crab Leg Emporium!");
            //Generate a random amount of money (between 0 and 100) for the customer to spend
            customer.budget = rand.NextDouble() * 100;
            Console.WriteLine("Customer budget = " + customer.budget); 
            //Have the store buy as many items as they can
            Console.WriteLine(store.FillShelves());
            //Have the customer buy as many items as they can
            customer.BuyItem();
            //End the day
            day++;
        }
    }
}