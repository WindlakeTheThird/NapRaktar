namespace Menu
{
    public partial class Project_Part_List
    {
        public class rekesz
        {
            int sor;
            int oszlop;
            int szint;

            public rekesz(int _sor, int _oszlop, int _szint)
            {
                this.sor = _sor;
                this.oszlop = _oszlop;
                this.szint = _szint;
            }
            public int getSor()
            {
                return sor;
            }
            public int getOszlop()
            {
                return oszlop;
            }
            public int getSzint()
            {
                return szint;
            }

        }
    }
}
