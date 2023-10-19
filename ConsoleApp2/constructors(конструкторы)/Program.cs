namespace constructors_конструкторы_
{
    class Gun
    {

        public Gun(bool isLoaded)
        {
            isLoaded = _isLoaded;
        }
        private bool _isLoaded;

        private void Reload()
        {
            Console.WriteLine("Заряжаю...");
            _isLoaded = true;
            Console.WriteLine("Заражено!");
        }

        public void Shoot()
        {
            if (!_isLoaded)
            {
                Console.WriteLine("Оружие не заряжено!");
                Reload();
            }
            Console.WriteLine("Бам бам\n");
            _isLoaded = false;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun(false);
            gun.Shoot();
        }
    }
}