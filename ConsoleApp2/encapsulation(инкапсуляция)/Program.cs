namespace encapsulation_инкапсуляция_
{
    // Инкапсуляция

    class Gun
    {
        private bool isLoaded;

        private void Reload()
        {
            Console.WriteLine("Заряжаю...");
            isLoaded = true;
            Console.WriteLine("Заражено!");
        }

        public void Shoot()
        {
            if(!isLoaded)
            {
                Console.WriteLine("Оружие не заряжено!");
                Reload();
            }
            Console.WriteLine("Бам бам\n");
            isLoaded = false;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun();
            gun.Shoot();
        }
    }
}