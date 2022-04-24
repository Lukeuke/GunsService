using System;
using GunService.Enums;

namespace GunService
{
    public class InitGuns
    {
        private readonly GunsProcessor _proc = new ();
        private readonly GunsStats _gunsStats = new ();
        
        public InitGuns()
        {
            Console.WriteLine("Choose a Gun: ");
            
            var choose = Convert.ToInt32(Console.ReadLine());
            
            switch (choose)
            {
                case 1:
                    _gunsStats.Ammo = 25;
                    _gunsStats.Name = EGunsName.Ak47.ToString();
                    _gunsStats.Range = 350;
                    _proc.GetStats(EGunsName.Ak47, EGunsType.Rifles, _gunsStats);
                    Console.WriteLine($"{_gunsStats.Name}: Ammo: {_gunsStats.Ammo}, Range: {_gunsStats.Range}");
                    break;
            }
        }
    }
}