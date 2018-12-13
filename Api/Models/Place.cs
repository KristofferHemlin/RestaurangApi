using System.Collections.Generic;

namespace Api.Models
{
    public class Place
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public ICollection<Restaurant> Restaurants { get; set; }
    }
}
