public class Inventory : Character
{
    public List<Item> Items;

    public void Display()
    {
        for (int i = 0; i < Items.Count; i++)
        {
            Console.WriteLine($"{i}) {Items[i]}");
        }
    }
}
