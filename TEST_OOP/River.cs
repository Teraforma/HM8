using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TEST_OOP
{
    internal class River

    {
        public River(int id, string name)
        {
            Id = id;
            Name = name;
            Fish = new HashSet<string>();
            _fishCount = new Dictionary<string, int>();

        }
        [JsonPropertyOrder(10)]
        public HashSet<string> Fish { get; private set; }
        public int Id { get; private set; }

        public string Name { get; private set; }

        public decimal Length { get; set; }

        private Dictionary<string, int> _fishCount;

        public void AddFish(string fishName)
        {
            if (Fish.Add(fishName))
            {
                _fishCount[fishName] = 1;
                return;
            }

            _fishCount[fishName] = _fishCount[fishName] + 1; ;
        }
        public void WriteCountByFish(string fishName)
        {
            var fishCount = _fishCount.TryGetValue(fishName, out int count) ? count : 0;
            Console.WriteLine($"{fishName} = {fishCount}");
        }
    }
}
