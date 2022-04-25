using GunService.Enums;

namespace GunService
{
    public class GunsProcessor
    {
        private IGunsStats iStats = null;

        public void GetStats(EGunsName name, EGunsType type, GunsStats gunsStats) 
        {
            var factory = new GunsFactory();

            this.iStats = factory.CreateGun(type, name, gunsStats);
            this.iStats.Ammo(gunsStats);
            this.iStats.Name(gunsStats);
            this.iStats.Range(gunsStats);
            this.iStats.Type(gunsStats);
        }
    }
}