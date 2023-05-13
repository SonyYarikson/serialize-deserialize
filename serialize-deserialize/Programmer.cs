    namespace serialize_deserialize
{
    internal partial class Program
    {
        public class Programmer
        {
            public string FreeTime { get; set; }
            public string Name { get; set; }
            public Programmer (string name, string freetime)
            {
                FreeTime = freetime;
                Name = name;
            }
        }
    }
}
