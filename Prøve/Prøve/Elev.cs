using System.Runtime.InteropServices;

namespace Prøve
{
    class Elev
    {
        public string navn;
        public bool isDumpet;
        public float height;
        public int grade;
        public string subject;

        public Elev(string navn, bool isDumpet, float height, int grade, string subject)
        {
            this.navn = navn;
            this.isDumpet = isDumpet;
            this.height = height;
            this.grade = grade;
            this.subject = subject;
        }

        public override string ToString()
        {
            var dumpet = isDumpet ? "Ja." : "Nej";
            return "Navn: " + navn + " Dumpet: " + dumpet + " Højde: " + height + " Karakter: " + grade + " Emne: " + subject;
        }
    }
}
