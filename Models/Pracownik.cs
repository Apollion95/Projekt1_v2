using System;
using System.Collections.Generic;

#nullable disable

namespace Projekt1_v5.Models
{
    public partial class Pracownik
    {
        public string IdPracownik { get; set; }
        public string NazwiskoPracownik { get; set; }
        public string ImiePracownik { get; set; }
        public string Telefon { get; set; }
        public string Wiek { get; set; }

        public virtual Wynajem Wynajem { get; set; }
    }
}
