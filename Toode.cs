using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toode
{
    public class Toode
    {
        public int Id { get; set; }
        public string Toodenimetus { get; set; }
        public DateTime Lisatud { get; set; } = DateTime.Now;
        public int Kogus { get; set; }
        public float Hind { get; set; }
        public string? Pilt { get; set; }
        public int KategooriaId { get; set; }
        public Kategooria Kategooria { get; set; }
    }
    public class Kategooria
    {
        public int Id { get; set; }
        public string Kategooria_nimetus { get; set; }
        public string? Kirjeldus { get; set; }

        public ICollection<Toode> Tooted { get; set; }
    }
}
