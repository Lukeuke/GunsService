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

            foreach (var name in Enum.GetNames(typeof(EGunsName)))
            {
                Console.Write($"{name} \t");
            }
            
            var choose = Convert.ToInt32(Console.ReadLine());
            
            switch (choose)
            {
                case 1:
                    _gunsStats.Ammo = 10;
                    _gunsStats.Name = EGunsName.DesertEagle.ToString();
                    _gunsStats.Range = 200;
                    _gunsStats.Type = EGunsType.Pistols.ToString();
                    _proc.GetStats(EGunsName.Ak47, EGunsType.Rifles, _gunsStats);
                    Console.WriteLine($"{_gunsStats.Name}: Ammo: {_gunsStats.Ammo}, Range: {_gunsStats.Range}, Type: {_gunsStats.Type}");
                    break;
                case 2:
                    _gunsStats.Ammo = 30;
                    _gunsStats.Name = EGunsName.DualBerettas.ToString();
                    _gunsStats.Range = 200;
                    _gunsStats.Type = EGunsType.Pistols.ToString();
                    _proc.GetStats(EGunsName.DualBerettas, EGunsType.Pistols, _gunsStats);
                    Console.WriteLine($"{_gunsStats.Name}: Ammo: {_gunsStats.Ammo}, Range: {_gunsStats.Range}, Type: {_gunsStats.Type}");
                    break;
                case 3:
                    _gunsStats.Ammo = 20;
                    _gunsStats.Name = EGunsName.FiveSeven.ToString();
                    _gunsStats.Range = 15;
                    _gunsStats.Type = EGunsType.Pistols.ToString();
                    _proc.GetStats(EGunsName.FiveSeven, EGunsType.Pistols, _gunsStats);
                    Console.WriteLine($"{_gunsStats.Name}: Ammo: {_gunsStats.Ammo}, Range: {_gunsStats.Range}, Type: {_gunsStats.Type}");
                    break;
                case 4:
                    _gunsStats.Ammo = 20;
                    _gunsStats.Name = EGunsName.Glock18.ToString();
                    _gunsStats.Range = 15;
                    _gunsStats.Type = EGunsType.Pistols.ToString();
                    _proc.GetStats(EGunsName.Glock18, EGunsType.Pistols, _gunsStats);
                    Console.WriteLine($"{_gunsStats.Name}: Ammo: {_gunsStats.Ammo}, Range: {_gunsStats.Range}, Type: {_gunsStats.Type}");
                    break;
                case 5:
                    _gunsStats.Ammo = 15;
                    _gunsStats.Name = EGunsName.Usp.ToString();
                    _gunsStats.Range = 20;
                    _gunsStats.Type = EGunsType.Pistols.ToString();
                    _proc.GetStats(EGunsName.Usp, EGunsType.Pistols, _gunsStats);
                    Console.WriteLine($"{_gunsStats.Name}: Ammo: {_gunsStats.Ammo}, Range: {_gunsStats.Range}, Type: {_gunsStats.Type}");
                    break;
                case 6:
                    _gunsStats.Ammo = 15;
                    _gunsStats.Name = EGunsName.Xm1014.ToString();
                    _gunsStats.Range = 20;
                    _gunsStats.Type = EGunsType.MachineGuns.ToString();
                    _proc.GetStats(EGunsName.Xm1014, EGunsType.MachineGuns, _gunsStats);
                    Console.WriteLine($"{_gunsStats.Name}: Ammo: {_gunsStats.Ammo}, Range: {_gunsStats.Range}, Type: {_gunsStats.Type}");
                    break;
                case 7:
                    _gunsStats.Ammo = 25;
                    _gunsStats.Name = EGunsName.Ak47.ToString();
                    _gunsStats.Range = 350;
                    _gunsStats.Type = EGunsType.Rifles.ToString();
                    _proc.GetStats(EGunsName.Ak47, EGunsType.Rifles, _gunsStats);
                    Console.WriteLine($"{_gunsStats.Name}: Ammo: {_gunsStats.Ammo}, Range: {_gunsStats.Range}, Type: {_gunsStats.Type}");
                    break;
                case 8:
                    _gunsStats.Ammo = 30;
                    _gunsStats.Name = EGunsName.M4A4.ToString();
                    _gunsStats.Range = 300;
                    _gunsStats.Type = EGunsType.Rifles.ToString();
                    _proc.GetStats(EGunsName.M4A4, EGunsType.Rifles, _gunsStats);
                    Console.WriteLine($"{_gunsStats.Name}: Ammo: {_gunsStats.Ammo}, Range: {_gunsStats.Range}, Type: {_gunsStats.Type}");
                    break;
                case 9:
                    _gunsStats.Ammo = 10;
                    _gunsStats.Name = EGunsName.Awp.ToString();
                    _gunsStats.Range = 1500;
                    _gunsStats.Type = EGunsType.SniperRifles.ToString();
                    _proc.GetStats(EGunsName.Awp, EGunsType.SniperRifles, _gunsStats);
                    Console.WriteLine($"{_gunsStats.Name}: Ammo: {_gunsStats.Ammo}, Range: {_gunsStats.Range}, Type: {_gunsStats.Type}");
                    break;
                case 10:
                    _gunsStats.Ammo = 10;
                    _gunsStats.Name = EGunsName.M249.ToString();
                    _gunsStats.Range = 1500;
                    _gunsStats.Type = EGunsType.MachineGuns.ToString();
                    _proc.GetStats(EGunsName.M249, EGunsType.MachineGuns, _gunsStats);
                    Console.WriteLine($"{_gunsStats.Name}: Ammo: {_gunsStats.Ammo}, Range: {_gunsStats.Range}, Type: {_gunsStats.Type}");
                    break;
            }
        }
    }
}