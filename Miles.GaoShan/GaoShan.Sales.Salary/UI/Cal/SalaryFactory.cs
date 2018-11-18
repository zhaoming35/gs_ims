using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Salary.UI.Cal
{
    public class SalaryFactory
    {
        public static SalaryCal GetSalaryCal(int odrType,string mainOdrNo, Model.Bu_CalSalaryGen salaryGen)
        {
            if (odrType == 1)
            {
                return new SalaryCalSales(odrType, mainOdrNo, salaryGen);
            }
            else if (odrType == 2)
            {
                return new SalaryCalLease(odrType, mainOdrNo, salaryGen);
            }
            else if (odrType == 3)
            {
                return null;
            }
            else
            {
                return null;
            }

        }
    }
}
