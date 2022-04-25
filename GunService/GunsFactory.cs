using GunService.Enums;
using GunService.GunType;

namespace GunService
{
    public class GunsFactory
    {
        public virtual IGunsStats CreateGun(EGunsType type, EGunsName name, GunsStats gunsStats)
        {
            IGunsStats iGunsStats = null;
            
            switch (name)
            {
                case EGunsName.Ak47:
                    iGunsStats = new Ak47();
                    break;
                case EGunsName.Awp:
                    iGunsStats = new Awp();
                    break;
                case EGunsName.Glock18:
                    iGunsStats = new Glock18();
                    break;
                case EGunsName.M249:
                    iGunsStats = new M249();
                    break;
                case EGunsName.Usp:
                    iGunsStats = new Usp();
                    break;
                case EGunsName.DesertEagle:
                    iGunsStats = new DesertEagle();
                    break;
                case EGunsName.DualBerettas:
                    iGunsStats = new DualBerettas();
                    break;
                case EGunsName.FiveSeven:
                    iGunsStats = new FiveSeven();
                    break;
                case EGunsName.Xm1014:
                    iGunsStats = new Xm1014();
                    break;
                case EGunsName.M4A4:
                    iGunsStats = new M4A4();
                    break;
            }
            return iGunsStats;
        }
    }
}