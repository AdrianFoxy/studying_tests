namespace interfaces
{
    // Part 1
    // interface is contract that defines a set of methods, properties, events, and indexers that a class or struct must implement
    // by default everything is public
    interface IDataProvide
    {
        string GetData();
    }

    interface IDataProcessor
    {
        void ProcessData(IDataProvide dataProvide);
    }

    class DbDataProvider : IDataProvide
    {
        public string GetData()
        {
            return "DB data";
        }
    }

    class FileDataProdiver : IDataProvide
    {
        public string GetData()
        {
            return "File data";
        }
    }

    class APIDataProvider : IDataProvide
    {
        public string GetData()
        {
            return "API data";
        }
    }

    class ConsoleDataProcessor : IDataProcessor
    {
        public void ProcessData(IDataProvide dataProvide)
        {
            Console.WriteLine(dataProvide.GetData());
        }
    }

    // Part 2
    interface IHasInfo
    {
        void ShowInfo();
    }

    interface IWeapon
    {
        int Damage { get; }
        void Fire();

    }
    abstract class Weapon : IHasInfo, IWeapon
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

    class Knife : Weapon
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
        public void Fire(IWeapon weapon)
        {
            weapon.Fire();
        }

        public void CheckInfo(IHasInfo hasInfo)
        {
            hasInfo.ShowInfo();
        }
    }

    class Box : IHasInfo
    {
        public void ShowInfo()
        {
            Console.WriteLine("I see the box, bruh");
        }
    }


    class Program
    {
        static void Main(string[] args) 
        {
            // Part 1
            IDataProcessor dataProcessor = new ConsoleDataProcessor();
            dataProcessor.ProcessData(new DbDataProvider());
            dataProcessor.ProcessData(new FileDataProdiver());
            dataProcessor.ProcessData(new APIDataProvider());

            // Part 2
            Player player = new Player();

            Weapon[] inventory = { new Gun(), new LaserGun(), new Knife() };
            foreach (var item in inventory)
            {
                player.CheckInfo(item);
                player.Fire(item);
                Console.WriteLine();
            }
            player.CheckInfo(new Box());

        }
    }
}