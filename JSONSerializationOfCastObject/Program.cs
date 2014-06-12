using System;
using Newtonsoft.Json;

namespace JSONSerializationOfCastObject
{
    class Program
    {
        static void Main(string[] args)
        {
            B InstanceB = new B(){PropA = "A",PropB = "B"};

            A InstanceA = InstanceB;

            var JSONInstanceA = JsonConvert.SerializeObject(InstanceA);

            Console.WriteLine(JSONInstanceA);

            Console.ReadLine();

        }
    }

    public class A
    {
        public string PropA { get; set; }
    }

      public class B:A
    {
        public string PropB { get; set; }
    }
}

