namespace Manual_Reporting
{
    public interface ISample
    {
        string Name { get; }
        string Description { get; }
        void Execute();
    }
}