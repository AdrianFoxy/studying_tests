namespace events
{
    class Program
    {
        static void Main(string[] args)
        {
            var hero = new Hero()
            {
                Id = 1,
                Name = "Bob",
                Health = 100
            };

            hero.OnHealthChanged += HeroOnHealthChanged;
            hero.OnHealthChanged += HeroIsDead;

            for (int i = 0; i < 5; i++)
            {
                hero.Health -= 20;
            }
        }

        private static void HeroIsDead(object sender, int health)
        {
            var hero = (Hero)sender;
            if (hero.Health <= 0)
            {
                Console.WriteLine($"{hero.Name} is dead");
            }
        }

        private static void HeroOnHealthChanged(object sender, int health)
        {
            var hero = (Hero)sender;
            Console.WriteLine($"{hero.Name} has new health: {health}");
        }
    }
}