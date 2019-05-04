using ITI.Smart.UI.EF1.Model;
using ITI.Smart.UI.EF1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.UI.EF1.BLL.Managers
{
    public class CityManager : Repository<City, Entities>
    {
        public CityManager(Entities context) : base(context)
        {
        }
    }
}
