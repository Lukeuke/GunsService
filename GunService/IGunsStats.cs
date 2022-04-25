namespace GunService
{
    public interface IGunsStats
    {
        public string Name(GunsStats gunsStats);
        public int Ammo(GunsStats gunsStats);
        public float Range(GunsStats gunsStats);
        public string Type (GunsStats gunsStats);
    }
}