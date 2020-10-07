using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using ChinookSystem.Entities;
using ChinookSystem.DAL;
using ChinookSystem.ViewModels;
using System.ComponentModel;
#endregion

namespace ChinookSystem.BLL
{
    [DataObject]
    public class AlbumController
    {
        #region Queries
        public List<AlbumArtist> Album_FindByArtist(int artistId) 
        {
            using (var context = new ChinookSystemContext())
            {
                var results = from k in context.Albums
                              where k.ArtistId == artistId
                              select new AlbumArtist
                              {
                                  Title = k.Title,
                                  ReleaseYear = k.ReleaseYear,
                                  ReleaseLabel = k.ReleaseLabel,
                                  AlbumId = k.AlbumId,
                                  ArtistId = k.ArtistId

                              };
                return results.ToList();




            }
        
        
        }
        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public AlbumItem Album_FindById(int albumid)
        {
            using (var context = new ChinookSystemContext())
            {
                var results = (from k in context.Albums
                             where k.AlbumId == albumid
                              select new AlbumItem
                              {
                                  Title = k.Title,
                                  ReleaseYear = k.ReleaseYear,
                                  ReleaseLabel = k.ReleaseLabel,
                                  AlbumId = k.AlbumId,
                                  ArtistId = k.ArtistId

                              }).FirstOrDefault();
                return results;




            }

        }
        #endregion
        #region CRUD: add, Update, and Delete
        // this is an add method - use insert 


        [DataObjectMethod(DataObjectMethodType.Insert,false)]
        public void Album_Add(AlbumItem item)
        {
            using (var context = new ChinookSystemContext()) 
            {
                Album newItem = new Album
                {
                    // dont need pk here
                    Title = item.Title,
                    ArtistId = item.ArtistId,
                    ReleaseYear = item.ReleaseYear,
                    ReleaseLabel = item.ReleaseLabel
                };

                context.Albums.Add(newItem);
                context.SaveChanges();

            
            }

        }
        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void Album_Update(AlbumItem item)
        {
            using (var context = new ChinookSystemContext())
            {
                Album newItem = new Album
                {
                    // pk is needed this time for updatibg to find the instance from the database

                    AlbumId = item.AlbumId,
                    Title = item.Title,
                    ArtistId = item.ArtistId,
                    ReleaseYear = item.ReleaseYear,
                    ReleaseLabel = item.ReleaseLabel
                };

                context.Entry(newItem).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();


            }

        }


        // this is the delete
        // this delete cannot be called from the crud ods, the crud ods control passes in an instance of the record
        [DataObjectMethod(DataObjectMethodType.Delete,false)]
        public void Album_Delete(AlbumItem item)
        {
            Album_Delete(item.AlbumId);
        }

        public void Album_Delete(int albumid) 
        {
            using (var context = new ChinookSystemContext())


            {
                var exists = context.Albums.Find(albumid);
                context.Albums.Remove(exists);
                context.SaveChanges();
            }
        }
        #endregion
    }
}
