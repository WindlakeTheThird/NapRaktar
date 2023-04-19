using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napelemosztalyok.classes
{
    public class Project
    {
        public int id { get; set; }
        public int szid { get; set; }
        public int allapot { get; set; }
        public int koltseg { get; set; }
        public string kivido { get; set; }
        public string projektnev { get; set; }
        public string helyszin { get; set; }
        public string leiras { get; set; }
        public string elerhetoseg { get; set; }

        public Project(int szid,string nev,string h,string leir,string eler)
        {
            this.szid = szid;
            this.projektnev = nev;
            helyszin = h;
            leiras = leir;
            elerhetoseg = eler;
            szid = 0;
            allapot = 0;
            koltseg = 0;
            kivido = "0001:01:01";
        }
        public Project(int id,string pnev,int sid,int all,int kolt, string date,string hely,string le,string eler)
        {
            this.id = id;
            this.szid = sid;
            this.projektnev = pnev;
            helyszin = hely;
            leiras = le;
            elerhetoseg = eler;
            allapot = all;
            koltseg = kolt;
            kivido = date;
        }

        public string newProject()
        {
            string s = "\'" + projektnev + "\'," + szid + "," + allapot + "," + koltseg + ",\'" + kivido.ToString() + "\',\'"
                 + helyszin + "\',\'" + leiras + "\',\'" + elerhetoseg + "\'";
            return s;
        }
    }
}
