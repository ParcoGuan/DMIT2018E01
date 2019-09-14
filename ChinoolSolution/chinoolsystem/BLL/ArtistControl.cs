using chinoolsystem.DAL;
using System.ComponentModel;
using chinoolsystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using chinoolsystem.Data.Entities;

namespace chinoolsystem.BLL
{
    [DataObject]
     public class ArtistControl
     {
       
        public List<Artist> Artist_List()
        {
            using (var context =new ChinoolContext())
            {
                return context.Artists.ToList();
            }
        }
        public Artist Artist_Get(int artistid)
        {
            using (var context = new ChinoolContext())
            {
                return context.Artists.Find(artistid);
            }
        }
     }
}
