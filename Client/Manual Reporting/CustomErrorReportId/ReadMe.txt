#Custom error report id

The error report id is a globally unique identifier which is returned to the user so that they can track their own error report on our homepage.

You can use your own generation algorithm if you would like to (to provide nicer ids).

Example:

        static void Main(string[] args)
        {
            OneTrue.Configuration.Credentials("874bda87-1489-4b11-9138-8de9d2110263",
                                              "3f5712b5-d487-40db-8750-422af3acf61e");

            ReportIdGenerator.Assign(CustomIdGenerator);

            // and the reporting here.
        }

        private static string CustomIdGenerator(Exception exception)
        {
            var guid = Guid.NewGuid().ToString();
            var buffer = Encoding.ASCII.GetBytes(guid);
            return Convert.ToBase64String(buffer);
        }