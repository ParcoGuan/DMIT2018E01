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
      [DataObject]
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



        [DataObjectMethod(DataObjectMethodType.Select, false)]

        public List<SelectionList> Employee_ListNames()
        {
            using (var context =new ChinookContext())
            {
                var employeelist = from x in context.Employees
                                   orderby x.LastName, x.FirstName
                                   select new SelectionList
                                   {
                                       DisplayText = x.LastName + "," + x.FirstName,
                                       IDValueField = x.EmployeeId
                                   };
                return employeelist.ToList();
            }
               
        }

       
    }

    
}
