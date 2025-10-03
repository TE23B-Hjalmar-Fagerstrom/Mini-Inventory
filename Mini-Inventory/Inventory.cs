public class Inventory
{
    public void Item()
    {
        Item sword = new();
        sword.Name = "woden sword";
        sword.Weight = 15;

        Item heal = new();
        heal.Name = "health potion";
        heal.Weight = 3;
    }

    public List<Item> Items;

    public void Display()
    {
        for (int i = 0; i < Items.Count; i++)
        {
            Console.WriteLine($"{i}) {Items[i]}");
        }
    }
}
