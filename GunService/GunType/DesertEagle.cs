namespace GunService.GunType
{
    public class DesertEagle : IGunsStats
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

        public string Type(GunsStats gunsStats)
        {
            return gunsStats.Type;
        }
    }
}