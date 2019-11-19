using System;

namespace HW22._4
{
    abstract class Bullet
    {

    }
    abstract class Weapon
    {
        public int rateOfFire { get; set; }
        public double caliber { get; set; }
        public Weapon(int rate, double calib)
        {
            rateOfFire = rate;
            caliber = calib;
        }
        public abstract Bullet TypeOfBullet();

    }
    class SimpleBullet : Bullet
    {
        public SimpleBullet()
        {
            Console.WriteLine("Simple bullets");
        }
    }
    class ExplosiveBullet : Bullet
    {
        public ExplosiveBullet()
        {
            Console.WriteLine("Explosive bullets");
        }
    }
    class M4A4 : Weapon
    {
        public M4A4(int rate, double calib) : base(rate, calib)
        {
            this.rateOfFire = rate;
            this.caliber = calib;
        }
        public override Bullet TypeOfBullet()
        {
            return new SimpleBullet();
        }
    }

    class Minigun : Weapon
    {
        public Minigun(int rate, double calib) : base(rate, calib)
        {
            this.rateOfFire = rate;
            this.caliber = calib;
        }
        public override Bullet TypeOfBullet()
        {
            return new ExplosiveBullet();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Minigun A = new Minigun(5, 7.62);
            M4A4 B = new M4A4(8, 5.56);
            Bullet bulletA = A.TypeOfBullet();
            Bullet bulletB = B.TypeOfBullet();
        }
    }
}
