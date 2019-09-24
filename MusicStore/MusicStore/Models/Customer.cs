using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public string  FavoriteGenre{ get; set; }
        public string FavoriteSong{ get; set; }
        public string image { get; set;}



    }
}
