namespace наследование_интерфейсов
{
    internal class Program
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

    interface IWeapon
    {
        void Fire();
    }

    interface IThrowingWeapon : IWeapon
    {
        void Throw();
    }

    class Gun : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: Пыщ");
        }
    }

    class LaserGun : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: Птю");
        }
    }

    class Knife : IThrowingWeapon
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: Хыщ");

        }

        public void Throw()
        {
            Console.WriteLine($"{GetType().Name}: Фють");
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
}
