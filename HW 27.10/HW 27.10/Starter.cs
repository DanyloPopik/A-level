using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_27._10
{
    public class Starter
    {
        public void Run()
        {
            Actions actions = new Actions();
            for (int i = 0; i < 100; i++)
            {
                actions.PerformRandomAction();
            }

        }
    }
}
