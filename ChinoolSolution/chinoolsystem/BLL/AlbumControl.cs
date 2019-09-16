using chinoolsystem.DAL;
using chinoolsystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chinoolsystem.BLL
{
  public class AlbumControl

    {
        
        public List<Album> Album_List()
        {
            using (var context = new ChinoolContext())
            {
                return context.Albums.ToList();
            }
        }
        public Album Album_Get(int albumid)
        {
            using (var context = new ChinoolContext())
            {
                return context.Albums.Find(albumid);
            }
        }

        [DataObjectMethod (DataObjectMethodType.Select,false)]
        public List<Album> Album_FindbyArtist(int artistid)
        {
            using (var context = new ChinoolContext())
            {
                var results = from x in context.Albums
                              where x.ArtistId == artistid
                              select x;
                return results.ToList();
            }
        }
    }
}
