using System.Collections.Generic;

namespace ArtsenEnPatienten
{
    public class Arts
    {
        public string Naam { get; set; }
        public List<Patient> Patienten = new List<Patient>();

        public void VoegPatientToe(Patient patient)
        {
            // TODO: implement
        }
    }

    public class Patient
    {
        public string Naam { get; set; }
        public List<Arts> Artsen = new List<Arts>();

        public void VoegArtsToe(Arts arts)
        {
            // TODO: implement
        }
    }
}
