namespace abstraction
{
    class Program
    {
        abstract class Weapon
        {
            public abstract int Damage { get; }
            public abstract void Fire();
            public void ShowInfo()
            {
                Console.WriteLine($"Current weapon is {GetType().Name}. Damage of the weapon is {Damage}");
            }
        }
        class Gun : Weapon
        {
            public override int Damage => 3;
            public override void Fire()
            {
                Console.WriteLine("Shoot!");
            }
        }

        class Knife: Weapon
        {
            public override int Damage => 9;
            public override void Fire()
            {
                Console.WriteLine("Knife shoof, dead!");
            }
        }

        class LaserGun : Weapon
        {
            public override int Damage => 15;
            public override void Fire()
            {
                Console.WriteLine("Laser shoot!");
            }
        }
        class Player
        {
            public void Fire(Weapon weapon)
            {
                weapon.Fire();
            }

            public void CheckInfo(Weapon weapon)
            {
                weapon.ShowInfo();
            }
        }
        static void Main(string[] args)
        {
            Player player = new Player();
            /*LaserGun gun = new LaserGun();
            player.Fire(gun);*/

            Weapon[] inventory = { new Gun(), new LaserGun(), new Knife() };
            foreach (var item in inventory)
            {
                player.CheckInfo(item);
                player.Fire(item);
                Console.WriteLine();
            }
        }
    }

}
