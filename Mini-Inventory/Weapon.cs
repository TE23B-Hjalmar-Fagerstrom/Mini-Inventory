public class Weapon: Item
{
    public int MinDamage = Random.Shared.Next(11);
    public int MaxDamage = Random.Shared.Next(12, 32);

    public int Attack()
    {
        return Random.Shared.Next(MinDamage, MaxDamage);
    }
}
