using GunService.Enums;

namespace GunService
{
    public class GunsProcessor
    {
        private IGunsStats _iStats;

        public void GetStats(EGunsName name, EGunsType type, GunsStats gunsStats) 
        {
            var factory = new GunsFactory();

            this._iStats = factory.CreateGun(type, name, gunsStats);
            this._iStats.Ammo(gunsStats);
            this._iStats.Name(gunsStats);
            this._iStats.Range(gunsStats);
            this._iStats.Type(gunsStats);
        }
    }
}