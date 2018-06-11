using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Audio
    {
        public int Id { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Duration { get; set; }
        public string Genre { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public int NoOfRequests { get; set; }
        public int[] Emotions { get; set; }
        public string Path { get; set; }

    }
}
