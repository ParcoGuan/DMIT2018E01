using chinoolsystem.DAL;
using chinoolsystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chinoolsystem.BLL
{
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
