
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
    //expose the library class for configuration of ODS
    
   public class ArtistController
    {
        [DataObjectMethod(DataObjectMethodType.Select,false)] 
        public List<SelectionList> Artists_List() 
        {
            //due to that the entities will be internal 
            //you will NOT be able to use the entity defintions (classes) as the return datatypes

            //instead, we will create views within  the ViewModel classes that will contain the definitions for your datatypes
            // contain the data definitions for your return datatypes
            //to fill theses view model classes, we will ise linq queries
            //linq queries return their data as Ienumeral OR Iqueryble datasets
            //you can use var when declaring your query recieving variables
            //the recieving variable can then be converted to a list of T List<T>
            //this linq query below uses the query syntax method
           using (var context = new ChinookSystemContext()) 
            {
                //linq to Entity queries
                //where is the access to the application library system entities
                //the entities are accessed by your Dbset<T> -> Artists
                //X represents any occurance (instance) in the Dbset<T>
                var results = from x in context.Artists
                              select new SelectionList
                              {
                                  ValueId = x.ArtistId,
                                  DisplayText = x.Name
                              };
                //sort the dataset by a specific property
                return results.OrderBy(x => x.DisplayText).ToList();

              //return context.Artists.ToList(); // in 1517 entities were public. Wont work in this class


            }
        }
  
}
}
