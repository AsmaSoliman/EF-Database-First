using ITI.Smart.UI.EF1.BLL.Managers;
using ITI.Smart.UI.EF1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.UI.EF1.BLL
{
    public class UnitOfWork
    {
        private static Entities context = new Entities();
        private static UnitOfWork unitOfWork;
        public CityManager CityManager {
            get
            {
                return new CityManager(context);
            }       
    }
        public CountryManager CountryManager {
            get {
                return new CountryManager(context);
            }
                
        }


        private UnitOfWork()
        {

        }

        public static UnitOfWork create()
        {
            if(unitOfWork == null)
            {
                unitOfWork = new UnitOfWork();
            }
            return unitOfWork;
        }
    }
}
