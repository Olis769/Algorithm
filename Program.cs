using System;
using System.Collections.Generic;

namespace Pol_Not
{
    class Program
    {


        public struct Val
        {
            public string name;
            public decimal size;
        }
        static void Main(string[] args)
        {
            decimal x;
            Console.WriteLine("Приклад запису -  ss d*f-t+g/");




            List<Val> CurVal = new List<Val>();
           
            string n_auxillary = "0123456789";
            string Aa = "qwertyuiopasdfghjklzxcvbnm";
            string op_auxillary = "*+-/";

            int numb = 0;
            string sdeploy = "";

            sdeploy = Writing5();
            pasting();
            //WrtL();
            decimal p=Handling();
            ;
            Console.WriteLine("result=" + p);
            ConsoleKeyInfo ssd;
         
            string Writing5()
            {
                int tod = 0; ;
                for (; true ;)
                {
                    
                    ssd = Console.ReadKey();
                    
                    if (Convert.ToString(ssd.Key) == "Enter") 
                        break;
                    if (Aa.Contains(ssd.KeyChar))
                    {
                       
 sdeploy += ssd.KeyChar;
                        if (CurVal.Count > 0)
                            break;
                    }
                    else if (ssd.KeyChar == ' ' && sdeploy.Length > 0 && sdeploy[sdeploy.Length - 1] != ' ')
                    {

                        Val t = new Val();
                        t.name = sdeploy;
                       
                        sdeploy += ssd.KeyChar;
                        numb = sdeploy.Length;
                        CurVal.Add(t);

                    }
                    else
                        Console.Write("\n" + sdeploy);
                }



                while (sdeploy.Length < 100)
                {

                    if (Convert.ToString(ssd.Key) == "Enter"&&op_auxillary.Contains(sdeploy[sdeploy.Length-1]))
                    {
                        
                        break;
                }
                    ssd = Console.ReadKey();

                    if (Aa.Contains(ssd.KeyChar))
                    {
                        sdeploy += ssd.KeyChar;

                    }
                    else if (op_auxillary.Contains(ssd.KeyChar))
                    {

                        Val b = new Val();
                        
                        b.name = sdeploy.Substring(numb,  sdeploy.Length - numb );
                        numb = sdeploy.Length+1;
                        
                        CurVal.Add(b);
                        sdeploy += ssd.KeyChar;
                    }
                    else
                        Console.Write("\n" + sdeploy);



                }




                return sdeploy;



            }


            
            void pasting() {
               double d= CurVal.Count;
                int d1 = 0;
                Console.WriteLine();
                while (d1< CurVal.Count) {

                    
                    Console.Write(CurVal[d1].name + "=");
                    Val to = new Val();
                   to.size = Convert.ToDecimal(Console.ReadLine());
                   to.name = CurVal[d1].name;
                    CurVal[d1] = to;
                    d1++;
                    //CurVal[d1].size=Convert.ToDecimal(Console.ReadLine()); 


                }

            }

            void WrtL() {
                int d1 = 0;
                while (d1 < CurVal.Count)
                {


                    Console.WriteLine(CurVal[d1].name +"=" + CurVal[d1].size 
                        );
                    Console.WriteLine(CurVal[d1].size+"\n"
                        );
                    d1++;
                

                }


            }
            decimal Handling()
            {
                decimal d = 0;
                int t = 0,f=1;
                //CurVal[0].size 
                d = CurVal[0].size;

                    while (t < sdeploy.Length) {
                    if (op_auxillary.Contains(sdeploy[t]))
                    {

                        switch ((sdeploy[t])) {
                            case '*':
                                d *= CurVal[f++].size;
                                break;
                            case '+':
                                d += CurVal[f++].size;
                                break;
                            case '-':
                                d -= CurVal[f++].size;
                                break;
                            case '/':
                                d /= CurVal[f++].size;
                                break;



                            default:
                                break;
                        }
                    
                    
                    }
                    t++;          
                }

                return d;
            }
        }
    }
}
