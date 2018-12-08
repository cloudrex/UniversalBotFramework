namespace UBF.Ports
{
    public abstract class Port
    {
        public abstract string Name { get; }

        public UniversalBot Bot { get; set; }

        public abstract void Setup();
    }
}
