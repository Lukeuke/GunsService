using GunService.Enums;
using GunService.GunType;

namespace GunService
{
    public class GunsFactory
    {
        public virtual IGunsStats CreateGun(EGunsType type, EGunsName name, GunsStats gunsStats)
        {
            IGunsStats iGunsStats = name switch
            {
                EGunsName.Ak47 => new Ak47(),
                EGunsName.Awp => new Awp(),
                EGunsName.Glock18 => new Glock18(),
                EGunsName.M249 => new M249(),
                EGunsName.Usp => new Usp(),
                EGunsName.DesertEagle => new DesertEagle(),
                EGunsName.DualBerettas => new DualBerettas(),
                EGunsName.FiveSeven => new FiveSeven(),
                EGunsName.Xm1014 => new Xm1014(),
                EGunsName.M4A4 => new M4A4(),
                _ => null
            };
            return iGunsStats;
        }
    }
}