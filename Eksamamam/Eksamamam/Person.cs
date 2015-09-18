namespace Eksamamam
{
    class Person
    {
        #region opg2
        public int Id;
        public string Fornavn, Efternavn, Adresse;

        public Person(int id, string fornavn, string efternavn, string adresse)
        {
            Id = id;
            Fornavn = fornavn;
            Efternavn = efternavn;
            Adresse = adresse;
        }

        public override string ToString()
        {
            return "ID: " + Id +
                "\nFornavn: " + Fornavn +
                "\nEfternavn: " + Efternavn +
                "\nAdresse: " + Adresse;
        }
        #endregion
    }
}
