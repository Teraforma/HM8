using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TEST_OOP
{
    internal class Book
    {
        
        public int PublishingHouseId { get; private set; }
        [JsonPropertyName("Name")]
        public string Title { get; private set; } //to not serialize get should be no public 
         [JsonIgnore]
        public PublisherHouse PublisherHouse { get; private set; }
        public Book(int pubHouId, string title, PublisherHouse pbHouse)
        {
            PublisherHouse = pbHouse;
            Title = title; 
            PublishingHouseId = pubHouId;
        }

    }
            
    
}
