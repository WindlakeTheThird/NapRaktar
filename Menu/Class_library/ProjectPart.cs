using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Class_library
{
    public class ProjectPart
    {


        
        public int Rekesz_sor { get; set; }
        public int Rekesz_oszlop { get; set; }
        public int Rekesz_szint { get; set; }
        int Mennyiseg { get; set; }

        public ProjectPart()
        {
        }
        public ProjectPart(int rekesz_sor, int rekesz_oszlop, int rekesz_szint,int mennyiseg)
        {
            Rekesz_sor = rekesz_sor;
            Rekesz_oszlop = rekesz_oszlop;
            Rekesz_szint = rekesz_szint;
            Mennyiseg = mennyiseg;
        }
        public string Peldany_to_string()
        {
            return $"Helye:[{Rekesz_sor},{Rekesz_oszlop},{Rekesz_szint}] mennyiség: {Mennyiseg}";
        }
    }
}
