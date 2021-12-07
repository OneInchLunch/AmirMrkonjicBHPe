using System;
using System.Collections.Generic;
using System.Text;

namespace AmirMrkonjicBHPe.Models
{
    public class VrstaPosiljke
    {
        public int Id { get; set; }
        public String Vrsta { get; set; }
        public float FaktorCijene { get; set; }
        public bool Ugovorena { get; set; }
        public String slika { get; set; }
    }
}
