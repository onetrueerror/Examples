using OneTrueError.Reporting;

namespace CustomMessageFactory
{
    public class AppInit
    {
        public static void AppInitialize()
        {
            OneTrue.Configuration.Credentials("874bda87-1489-4b11-9138-8de9d2110263",
                "3f5712b5-d487-40db-8750-422af3acf61e");

        
            OneTrue.Configuration.CatchWcfExceptions();
        }
    }
}