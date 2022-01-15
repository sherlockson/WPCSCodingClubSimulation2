public class Store
{
    public List<string> items;
    public string name;
    public double price = 5.00;
    private int itemCount;
    private double budget;

    public Store(string name)
    {
        this.name = name;
        items = new List<string>();
        budget = 5.00;
        itemCount = 0;
    }

    public int GetItemCount()
    {
        return itemCount;
    }

    public void ItemBought()
    {
        itemCount--;
        budget += price;
    }

    public void AddItem(string item)
    {
        items.Add(item);
    }

    public int FillShelves()
    {
        //Items cost 1.50
        if(budget - 1.50 < 0)
        {
            Console.WriteLine("Bankrupt");
            return 0;
        }

        int count = 0;
        while (budget - 1.50 > 0)
        {
            count++;
            itemCount++;
            budget -= 1.50;
            Console.WriteLine("Yummy crab leg bought by store");
        }
        return count;
    }
}