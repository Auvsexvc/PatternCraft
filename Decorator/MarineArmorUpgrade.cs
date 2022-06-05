namespace Decorator
{

    public class MarineArmorUpgrade : IMarine
        {
            private IMarine marine;

            public MarineArmorUpgrade(IMarine marine)
            {
                Damage = marine.Damage;
                Armor = marine.Armor;
                Armor++;
            }

            public int Damage { get; set; }

            public int Armor { get; set; }
        }
    
}