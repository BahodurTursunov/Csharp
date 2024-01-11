namespace Абстрактные_классы_методы__свойства_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Weapon[] inventory = { new Gun(), new LaserGun(), new Bow() };

            foreach (var item in inventory)
            {
                player.CheckInfo(item);
                player.Fire(item);
                Console.WriteLine();
            }
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

    abstract class Weapon()
    {
        public abstract int Damage { get; }

        public abstract void Fire();

        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name} Damage : {Damage}");
        }

    }

    class Gun : Weapon
    {
        public override int Damage { get { return 5; } } // *тоже самое что и 

        public override void Fire()
        {
            Console.WriteLine("Gun");
        }
    }


    class LaserGun : Weapon
    {
        public override int Damage => 3; // *это

        public override void Fire()
        {
            Console.WriteLine("Laser");
        }
    }
    class Bow : Weapon
    {
        public override int Damage => 2;

        public override void Fire()
        {
            Console.WriteLine("Bow");
        }
    }
}
