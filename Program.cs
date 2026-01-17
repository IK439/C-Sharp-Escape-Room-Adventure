using System;

namespace EscapeRoomAdventure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Reference Type Demonstration ===");
            Console.WriteLine("Both variables will reference the same FieldAgent object.\n");

            // Create a new field agent
            FieldAgent agent1 = new FieldAgent();
            agent1.Name = "Agent Smith";
            agent1.SecretCode = 007;

            // agent2 points to the same object as agent1
            FieldAgent agent2 = agent1;
            agent2.SecretCode = 999;

            Console.WriteLine("Agent1 Secret Code:");
            Console.WriteLine(agent1.SecretCode);

            Console.WriteLine("Agent2 Secret Code:");
            Console.WriteLine(agent2.SecretCode);

            Console.WriteLine("\nBoth values are the same because they reference the same object.\n");

            Console.WriteLine("=== Object Comparison Demonstration ===");
            Console.WriteLine("Two separate File objects with identical values are compared.\n");

            // Create first file object
            File file1 = new File();
            file1.FileName = "Confidential.txt";
            file1.FileSize = 1024;

            // Create second file object with the same values
            File file2 = new File();
            file2.FileName = "Confidential.txt";
            file2.FileSize = 1024;

            bool sameFile = file1 == file2;

            Console.WriteLine("Are file1 and file2 the same object?");
            Console.WriteLine(sameFile);
            Console.WriteLine("This is false because they are different objects in memory.\n");

            Console.WriteLine("=== Interface and Polymorphism Demonstration ===");
            Console.WriteLine("Servers are treated as ISystem objects.\n");

            // Create two server objects
            Server mainServer = new Server();
            Server backupServer = new Server();

            mainServer.Status = "Active";
            backupServer.Status = "Inactive";

            // Store servers using the interface type
            ISystem[] systems = new ISystem[] { mainServer, backupServer };

            Console.WriteLine("Operating all systems:\n");

            foreach (ISystem system in systems)
            {
                system.Operate();
            }

            Console.WriteLine("\nEach server responds through the ISystem interface.");
        }
    }
}