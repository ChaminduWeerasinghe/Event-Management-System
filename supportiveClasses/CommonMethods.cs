using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.supportiveClasses
{
    class CommonMethods
    {
        //Common String for employee ID
        public const string emp_ID = "EMP00";

        public static string generate_Emp_ID(ArrayList arrayList)
        {
            string eID;
            int next = arrayList.Count;
            next++;
            eID = emp_ID + next;

            if (arrayList.Contains(eID))
            {
                next++;
                eID = emp_ID + next;
            }

            return eID;
        }
    }
}
