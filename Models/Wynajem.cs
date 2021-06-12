using System;
using System.Collections.Generic;

#nullable disable

namespace Projekt1_v5.Models
{
    public partial class Wynajem
    {
        public string IdWypozyczenia { get; set; }
        public string IdKlienta { get; set; }
        public string IdFilmu { get; set; }
        public DateTime? DataWypozyczenia { get; set; }
        public DateTime? DataZwrotu { get; set; }

        public virtual Film IdFilmuNavigation { get; set; }
        public virtual KontaktKlient IdKlientaNavigation { get; set; }
        public virtual Pracownik IdWypozyczeniaNavigation { get; set; }
    }
}
