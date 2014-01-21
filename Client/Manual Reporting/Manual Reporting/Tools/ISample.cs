namespace Manual_Reporting.Tools
{
    public interface ISample
    {
        string Name { get; }
        string Description { get; }
        void Execute();
    }
}