using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces

using ChinookSystem.Data.Entities;
using System.ComponentModel;
using ChinookSystem.DAL;
#endregion

namespace ChinookSystem.BLL
{
    [DataObject]
    public class AlbumController
    {
        private List<string> reason = new List<string>;



        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Album> Album_List()
        {
            using (var context = new ChinookContext())
            {
                return context.Albums.ToList();
            }
        }

        public Album Album_Get(int albumid)
        {
            using (var context = new ChinookContext())
            {
                return context.Albums.Find(albumid);
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public List<Album> Album_FindByArtist(int artistid)
        {
            using (var context = new ChinookContext())
            {
                var results = from x in context.Albums
                              where x.ArtistId == artistid
                              select x;
               
                return results.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Insert,false)]
        public int Album_Add(Album item) 
        {
         
            using (var context =new ChinookContext())
            {
                if (CheckReleaseYear(item))
                {
                    context.Albums.Add(item);
                    context.SaveChanges();
                    return item.AlbumId;
                }
                else
                {
                    throw new BusinessRule("")
                }
            }
         
        }
        [DataObjectMethod(DataObjectMethodType.Update,false)]

        public int Album_Update(Album item)
        {
            using (var context =new ChinookContext())
            {
                context.Entry(item).State = System.Data.Entity.EntityState.Modified;
                return context.SaveChanges();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]

        public int Album_Delete(Album item)
        {
            return Album_Delete(item.AlbumId);


        }

        public int Album_Delete(int albumid)
        {
            using (var context = new ChinookContext())
            {
                var existing = context.Albums.Find(albumid);
                if(existing==null)
                {
                    throw new Exception("Album not find");
                }
                else
                {
                    context.Albums.Remove(existing);
                    return context.SaveChanges();
                }
            }
        }



        private bool CheckReleaseYear(Album item)
        {
            bool isValid =true;
            int releaseyear;
            if (string.IsNullOrEmpty(item.ReleaseYear.ToString()))
            {
                isValid = false;
                reason.Add("Release year is required");
            }
           else if(int.TryParse(item.ReleaseYear.ToString(), out releaseyear
))
            {
                isValid = false;
                reason.Add("Release year is not an number");
            }
           else if (releaseyear < 1950 || releaseyear >DateTime.Today.Year)
            {
                isValid = false;
                reason.Add(string.Format("album is not in between 1950 - today"));
            }
            return isValid;
        }
    }

    
}
