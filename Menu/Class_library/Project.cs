namespace Class_library
{
    public class Project
    {
        public int Id { get; set; }
        public int Szid { get; set; }
        public int Allapot { get; set; }
        public int Koltseg { get; set; }
        public string Kivido { get; set; }
        public string Projektnev { get; set; }
        public string Helyszin { get; set; }
        public string Leiras { get; set; }
        public string Elerhetoseg { get; set; }

        public Project(int szid, string nev, string h, string leir, string eler)
        {
            Szid = szid;
            Projektnev = nev;
            Helyszin = h;
            Leiras = leir;
            Elerhetoseg = eler;
            Allapot = 0;
            Koltseg = 0;
            Kivido = "0001:01:01";
        }
        public Project(int id, string pnev, int sid, int all, int kolt, string date, string hely, string le, string eler)
        {
            Id = id;
            Szid = sid;
            Projektnev = pnev;
            Helyszin = hely;
            Leiras = le;
            Elerhetoseg = eler;
            Allapot = all;
            Koltseg = kolt;
            Kivido = date;
        }

        public string newProject()
        {
            string s = "\'" + Projektnev + "\'," + Szid + "," + Allapot + "," + Koltseg + ",\'" + Kivido.ToString() + "\',\'"
                 + Helyszin + "\',\'" + Leiras + "\',\'" + Elerhetoseg + "\'";
            return s;
        }
    }
}
