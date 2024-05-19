namespace interfaces_multiple_inheritance
{
    interface IWeapon
    {
        void Fire();
    }

    // multiple inheritance
    interface IThrowingWeapon : IWeapon
    {
        void Throw();
    }

    class Gun : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine("Shoot!");
        }
    }

    class LaserGun : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine("Shoot2!");
        }
    }

    class Knife : IThrowingWeapon
    {
        public void Fire()
        {
            Console.WriteLine("Punck with knife!");
        }

        public void Throw()
        {
            Console.WriteLine("Throw knife!");
        }
    }

    class Player
    {
        public void Fire(IWeapon weapon)
        {
            weapon.Fire();
        }

        public void Throw(IThrowingWeapon throwingWeapon)
        {
            throwingWeapon.Throw();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            IWeapon[] inventory = { new Gun(), new LaserGun(), new Knife() };
            foreach (var item in inventory)
            {
                player.Fire(item);
                Console.WriteLine();
            }
            player.Throw(new Knife());
        }
    }
}