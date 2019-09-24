﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    public class Song
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        [Display(Name ="Album Cover")]
        public string ImagePath { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public bool IsFeatured { get; set; }
    }
}
