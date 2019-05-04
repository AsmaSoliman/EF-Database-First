using ITI.Smart.UI.EF1.BLL;
using ITI.Smart.UI.EF1.BLL.Managers;
using ITI.Smart.UI.EF1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.UI.EF1.DBF
{
    class Program
    {
        static void Main(string[] args)
        {

            UnitOfWork unit = UnitOfWork.create();
            Country c = unit.CountryManager.Add(new Country { Name="Eg"}); 
            Country c1 = unit.CountryManager.GetById(4);
            bool r = unit.CountryManager.Remove(c1);
           
        }
    }
}
