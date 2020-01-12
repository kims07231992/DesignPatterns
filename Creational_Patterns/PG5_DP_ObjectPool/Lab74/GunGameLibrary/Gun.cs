using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace GunGameLibrary
{
    public class Gun
    {
        private readonly int _defaultBulletCapacity;

        private ConcurrentBag<Bullet> _magazine;

        public Gun()
        {
            // Init default bullets
            this._defaultBulletCapacity = 10;
            this._magazine = new ConcurrentBag<Bullet>();
            for (int i = 0; i < this._defaultBulletCapacity; i++)
            {
                this._magazine.Add(new Bullet());
            }
        }

        public void Fire()
        {
            Bullet bulletToShoot;
            if (!this._magazine.TryTake(out bulletToShoot))
            {
                Console.WriteLine("Your magazine is empty! adding a new bullet.");
                bulletToShoot = new Bullet();
            }

            Action<ConcurrentBag<Bullet>, Bullet> shoot = (magazine, bullet) =>
            {
                int time = 1000 * 5; // 5 sec
   
                Console.WriteLine($"Time: {DateTime.Now.ToString()} Bullet has been triggered.");
                Thread.Sleep(time); // While bullet is running
                magazine.Add(bulletToShoot); // Return to magazine
            };

            new Task(() => shoot(this._magazine, bulletToShoot)).Start();
        }
    }
}
