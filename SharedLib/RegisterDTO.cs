﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLib
{
    public class RegisterDTO
    {
        public string Nimi { get; set; }
        [Required]
        public string Kayttajatunnus { get; set; }
        [Required]
        public string Salasana { get; set; }
        [Required]
        public string Rooli { get; set; }
        [Required]
        public DateTime Luotu { get; set; }
    }
}
