using System;
using System.Collections.Generic;
using System.Linq;

namespace Menu
{
    public partial class Project_Part_List
    {
        public class utvonal
        {
            List<rekesz> ut = new List<rekesz>();


            public void utAdd(rekesz rekeszObj)
            {
                ut.Add(rekeszObj);
            }

            public void kiirUtvonal()
            {
                Console.WriteLine("----------utvonal----------");
                foreach (rekesz item in ut)
                {
                    Console.WriteLine(item.getSor().ToString() + ", " + item.getOszlop().ToString() + ", " + item.getSzint().ToString());
                }
            }
            public string utvonalKi() {
                string ki = "";
                for(int i= 0;i<ut.Count();i++)
                {
                    ki += ut[i].getSor().ToString() + "," + ut[i].getOszlop().ToString() + "," + ut[i].getSzint().ToString()+"|";
                }
                return ki;
            }
            public int getAbsDistance(int szam1, int szam2)
            {
                return Math.Abs(szam1 - szam2);
            }
            public void getMinDistance(ref rekeszek rekeszlista)
            {
                Dictionary<rekesz, int> tavolsagok = new Dictionary<rekesz, int>();
                rekesz utolso = ut.Last();
                int size = rekeszlista.rekeszlista.Count();
                for (int i = 0; i < size; i++)
                {
                    foreach (rekesz item in rekeszlista.rekeszlista)
                    {
                        utolso = ut.Last();
                        int tav = 0;
                        //sortavolsag
                        tav += getAbsDistance(utolso.getSor(), item.getSor()) / 2 * 2;


                        if ((getAbsDistance(utolso.getSor(), item.getSor()) % 2 == 1) && ((Math.Max(utolso.getSor(), item.getSor()) % 2 == 0)))
                        {
                            tav += 2;
                        }
                        if (tav == 0)
                        {
                            tav += getAbsDistance(utolso.getOszlop(), item.getOszlop());
                        }
                        else if (tav != 0)
                        {
                            if ((utolso.getOszlop() == 1 && item.getOszlop() == 1) || (utolso.getOszlop() == 4 && item.getOszlop() == 4))
                            {
                                tav += 2;
                            }
                            if ((utolso.getOszlop() == 2 && item.getOszlop() == 2) || (utolso.getOszlop() == 3 && item.getOszlop() == 3))
                            {
                                tav += 4;
                            }
                            if ((utolso.getOszlop() == 2 && item.getOszlop() == 3) || (utolso.getOszlop() == 3 && item.getOszlop() == 2))
                            {
                                tav += 5;
                            }
                            if ((utolso.getOszlop() == 1 && item.getOszlop() == 4) || (utolso.getOszlop() == 4 && item.getOszlop() == 1))
                            {
                                tav += 5;
                            }
                            if ((utolso.getOszlop() == 1 && item.getOszlop() == 3) || (utolso.getOszlop() == 3 && item.getOszlop() == 1))
                            {
                                tav += 4;
                            }
                            if ((utolso.getOszlop() == 2 && item.getOszlop() == 4) || (utolso.getOszlop() == 4 && item.getOszlop() == 2))
                            {
                                tav += 4;
                            }
                            if ((utolso.getOszlop() == 1 && item.getOszlop() == 2) || (utolso.getOszlop() == 2 && item.getOszlop() == 1))
                            {
                                tav += 3;
                            }
                            if ((utolso.getOszlop() == 3 && item.getOszlop() == 4) || (utolso.getOszlop() == 4 && item.getOszlop() == 3))
                            {
                                tav += 3;
                            }
                        }
                        tavolsagok[item] = tav;
                    }
                    var min = tavolsagok.Aggregate((l, r) => l.Value < r.Value ? l : r).Key;
                    ut.Add(min);
                    rekeszlista.rekeszlista.Remove(min);
                    tavolsagok.Clear();
                }

            }
        }
    }
}
