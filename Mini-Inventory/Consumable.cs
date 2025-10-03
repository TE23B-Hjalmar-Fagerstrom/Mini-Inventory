public class Consumable : Item
{
    public int UsesMax = 3;
    public int UsesCurrent = 0;

    public void Use(Character target)
    {
        if (UsesCurrent < UsesMax)
        {
            target.Hp += 10;
        }
    }
}
