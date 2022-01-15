public class Customer
{
    public double budget;
    public string name;
    public Store store;

    public Customer(double budget, string name, Store store)
    {
        this.budget = budget;
        this.name = name;
        this.store = store;
    }

    public void BuyItem()
    {
        if(budget - store.price < 0)
        {
            Console.WriteLine("Broke");
            return;
        }
        Random rand = new Random();
        while(budget - store.price > 0 && store.GetItemCount() > 0)
        {
            budget -= store.price;
            store.ItemBought();
            Console.WriteLine("We bought a yummy crab leg :)");
        }
    }
}

