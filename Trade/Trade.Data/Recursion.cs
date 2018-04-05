using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Trade.Data
{
    public class Recursion
    {
        static public List<int> countA = new List<int>();
        

        public int Dignity { get; private set; }
 
        public Recursion(int dignity)
        {
            Dignity = dignity;
        }
        ~Recursion()
        {
            
        }
        public static int Recurs(int Count)
        {
          
            if (Count > 0)
            {           
                return 2 * countA[Count - 1] + Recurs(Count - 1);
            }
            else
            {
                return 0;
            }
        }

        public static int Pay_for_product(int Count, int Cost, List<int>countA)
        {
            int valid;
            int valid1;
            int min = Int32.MaxValue;
            valid = Cost - Recurs(Count);
            valid1 = Recurs(Count) - Cost;
            if(valid ==0)
            {
                return 1;
            }
            else if(valid<0)
            { 
                bool res1 = false;
                valid = Recurs(Count) - Cost;
                int count = 0; 
                bool res = false;
                for (int i = 0; i < Count; i++)
                {
                    if (min > countA[i])
                    {
                        min = countA[i];
                    }
                    if (Cost < min)
                    {
                        res = true;
                        break;
                    }
                }
                for (int i = 0; i < Count; i++)
                {
                    if ((countA[i] % 2 == 0) && (countA[i] != 0))
                    {
                        count++;
                    }

                    if ((Count == count) && (Cost % 2 != 0))
                    {
                        res = true;
                        break;
                    }
                }
                if (res)
                {
                    return 4;
                }

                for (int i = 0; i < Count; i++)
                {
                    if ((countA[i] == 1) || (countA[i] == 2))
                    {
                        res1 = true;
                        break;
                    }
                }
                                
                for (int i = 0; i < Count; i++)
                {
                    if ((countA[i] == Cost) || (2 * countA[i] == Cost))
                    {
                        res1 = true;
                        break;
                    }
                }
                for (int i = 0; i < Count; i++)
                {
                    for (int j = 0; j < Count; j++)
                    {
                        if (i == j)
                        {
                            continue;
                        }
                        if (countA[i] + countA[j] == Cost)
                        {
                            res1=true;
                            break;
                        }
                    }
                }
                for (int i = 0; i < Count - 1; i++)
                {
                    if ((countA[i] + countA[i + 1] == Cost) || (2 * countA[i] + 2 * countA[i + 1] == Cost))
                    {
                        res1 = true;
                        break;
                    }
                }

                for (int i = 0; i < Count - 1; i++)
                {
                    if ((countA[i] + countA[i + 1] > Cost) || (2 * countA[i] + 2 * countA[i + 1] > Cost))
                    {
                        res1 = true;
                        break;
                    }

                }
                if (res1)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            else 
            {
                return 3;
            }
        }
        public override string ToString()
        {
            return Dignity.ToString();
        }
    }
}
