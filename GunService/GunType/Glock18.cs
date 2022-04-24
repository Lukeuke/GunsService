namespace GunService.GunType
{
    public class Glock18 : IGunsStats
    {
        public string Name(GunsStats gunsStats)
        {
            return gunsStats.Name;
        }

        public int Ammo(GunsStats gunsStats)
        {
            return gunsStats.Ammo;
        }

        public float Range(GunsStats gunsStats)
        {
            return gunsStats.Range;
        }
    }
}