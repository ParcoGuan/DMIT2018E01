using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinookSystem.BLL
{
    #region Additional Namespaces
    using ChinookSystem.DAL;
    using ChinookSystem.Data.Entities;
    using System.ComponentModel;
    using DMIT2018Common.UserControls;
    using ChinookSystem.Data.POCOs;
    #endregion

    public class EmployeeController
    {
        public List<string> Employee_Gettitle()
        {
            using (var context = new ChinookContext())
            {
                var result = (from x in context.Employees select x.Title).Distinct();
                return result.ToList();
            }
        }
    }
}
