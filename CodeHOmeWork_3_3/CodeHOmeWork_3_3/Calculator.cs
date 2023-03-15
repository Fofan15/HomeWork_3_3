using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeHOmeWork_3_3
{
    public delegate int SumDelegate(int x, int y);
    public class Calculator
    {
        public event SumDelegate SumEvent;

        public void Calculate() 
        {
            SumDelegateWrapper(SumEvent);
        }

        private void SumDelegateWrapper(SumDelegate sumDelegate) 
        {
            int result = 0;
            try
            {
                foreach (SumDelegate sum in sumDelegate.GetInvocationList())
                {
                    result += sum(3, 1);
                }

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
