using System.Collections.Generic;

namespace Cursusinschrijving
{
    public class Cursus
    {
        public string CursusNaam { get; set; }
    }

    public class Student
    {
        public string Naam { get; set; }
        public List<Cursus> Cursussen = new List<Cursus>();

        public void SchrijfIn(Cursus cursus)
        {
            // TODO: implement
        }
    }
}
