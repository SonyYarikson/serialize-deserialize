using System;
using System.Text.Json;

namespace serialize_deserialize
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Programmer programmer1 = new Programmer("Alex", "No free time");
            string json = JsonSerializer.Serialize(programmer1);
            Console.WriteLine(json);
            var restoredProgrammer = JsonSerializer.Deserialize<Programmer>(json);
            Console.WriteLine(restoredProgrammer.FreeTime);

        }
    }
}
