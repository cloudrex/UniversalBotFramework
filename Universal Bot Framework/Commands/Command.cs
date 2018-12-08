namespace UBF.Commands
{
    public abstract class Command
    {
        public abstract string Name { get; }

        public abstract void Run(Context context);
    }
}
