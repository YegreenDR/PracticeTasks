using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_8.Task_2
{

        class Accauntant
        {
        public bool AskForBonus(Dolzhnosti dol, int hours)
            {
                if (hours > (int)dol) return true;
                else return false;
            }
        }
    }
