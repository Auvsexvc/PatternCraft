namespace Decorator
{
    public class MarineWeaponUpgrade : IMarine
        {
            private IMarine marine;

            public MarineWeaponUpgrade(IMarine marine)
            {
                Damage = marine.Damage;
                Armor = marine.Armor;
                Damage++;
            }

            public int Damage { get; set; }

            public int Armor { get; set; }
        }
    
}