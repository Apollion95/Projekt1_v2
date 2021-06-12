using System;
using System.Collections.Generic;

#nullable disable

namespace Projekt1_v5.Models
{
    public partial class Dostepnosc
    {
        public Dostepnosc()
        {
            Films = new HashSet<Film>();
        }

        public string IdNosnika { get; set; }
        public string IlośćDostępnychKopii { get; set; }
        public string TypNosnika { get; set; }

        public virtual ICollection<Film> Films { get; set; }
    }
}
