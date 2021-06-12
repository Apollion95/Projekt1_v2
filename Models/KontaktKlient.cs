using System;
using System.Collections.Generic;

#nullable disable

namespace Projekt1_v5.Models
{
    public partial class KontaktKlient
    {
        public KontaktKlient()
        {
            Wynajems = new HashSet<Wynajem>();
        }

        public string IdKlienta { get; set; }
        public string NumerTelefonu { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Nazwa { get; set; }

        public virtual ICollection<Wynajem> Wynajems { get; set; }
    }
}
