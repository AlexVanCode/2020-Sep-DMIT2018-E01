using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;


#region Additional Namespaces
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
#endregion




namespace ChinookSystem.Entities
{
    //annotate your entity to link to sql table
    // indicate primary key and key type 
    // Include validation on fields

        [Table("Artists")]

    internal class Artist
    {
        //private data members.. only if you need.... 
        private string _Name;

        //properties
        // each sql table attribute will be mapped within this defintion
        // annotation may be needed for some of the properties 
        // ANY property annotation must appear PRIOR to the property
        // [key] primary key
        // an additional option within this annotation is DataBaseGenerated()
        // By defaulkt if no dataBaseGenerate option is given, 
        // the promary key is assumed to be Identity sql primart key
        // Identity pkwy: [key] or [key, DatabaseGenerated(DataBaseGeneratedOption.Identity)]
        // user pkey: [key, DatabaseGenerated(DataBaseGeneratedOption.None)]
        // third option is .Computed


         

        [Key]
        public int ArtistId { get; set; }



        //[Required(ErrorMessage = "Name is required")]
        [StringLength(120,ErrorMessage ="Name is limited to 120 characters")]
        public string Name
        {
            get { return _Name; }
            set { _Name = string.IsNullOrEmpty(value) ? null : value; }

        }

        //navigational properties
        // an artist (parent) can have zero, one, ore moire Albums (collection)

        public virtual ICollection<Album> Albums { get; set; }




        //constructors.. not now

        //behaviours... not now tho





    }
}
