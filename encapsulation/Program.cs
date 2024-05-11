namespace encapsulation
{
    class Gun
    {
        private bool isLoaded;

        private void Reload()
        {
            Console.WriteLine("Roloading...");
            isLoaded = true;
            Console.WriteLine("Reloaded!");
        }

        public void Shoot()
        {
            if (!isLoaded) 
            {
                Console.WriteLine("Need reload!");
                Reload();

            } else 
            {
                Console.WriteLine("Shoot!");
                isLoaded = false;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun();
            gun.Shoot();
        }
    }
}