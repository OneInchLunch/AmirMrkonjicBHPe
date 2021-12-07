using System;
using System.Collections.Generic;
using System.Text;

namespace AmirMrkonjicBHPe.Models
{
    public class DodatneUsluge
    {
        public int Id { get; set; }
        public String NazivUsluge { get; set; }
        public float Cijena { get; set; }
        public bool Ugovorena { get; set; }

    }
}
