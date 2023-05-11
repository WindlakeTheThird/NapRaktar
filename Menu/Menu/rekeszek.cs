using System;
using System.Collections.Generic;

namespace Menu
{
    public partial class Project_Part_List
    {
        public class rekeszek
        {
            public List<rekesz> rekeszlista = new List<rekesz>();

            public void rekeszAdd(rekesz rekeszObj)
            {
                rekeszlista.Add(rekeszObj);
            }
            public void kiir()
            {
                Console.WriteLine("----------alkatreszek----------");
                foreach (rekesz item in rekeszlista)
                {
                    Console.WriteLine(item.getSor().ToString() + ", " + item.getOszlop().ToString() + ", " + item.getSzint().ToString());
                }
            }

        }
    }
}
