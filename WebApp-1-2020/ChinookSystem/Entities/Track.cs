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


    [Table("Tracks")]
    internal class Track

    {
        private string _Composer;
        [Key]
        public int TrackId { get; set; }
        [Required(ErrorMessage = "Track Name is Required")]
        [StringLength(200, ErrorMessage = "Track Name is limited to 200 characters")]

        public string Name { get; set; }

        public int? AlbumId { get; set; }

        public int MediaTypeId { get; set; }

        public int? GenreId { get; set; }

        [StringLength(220, ErrorMessage = "Track Composer is limited to 220 characters")]
        public string Composer

        {

            get { return _Composer; }
            set { _Composer = string.IsNullOrEmpty(value) ? null : value; }

        }

        public int Milliseconds { get; set; }

        public int? Bytes { get; set; }

        public decimal UnitPrice { get; set; }

        //navigational properties
        //virtually map the relationship of Table A to Table B
        // Use to overlay a model of the database ERD relathionshoip
        //Tracks has a relationship to Albums, MediaTypes, Genres, InvoiceLines, PlaylistTracks - could map virtal proerties to all these
        // A track has one parent (Album)
        //an etity may have both virtual properties for parent relationshops and childrent relationships 
        // Track and MediaTypes (child to parent)
        // TRach and Genres (child to parent)
        //Track and playlistTracks (parent to children)
        //tracks has an Albums
        public virtual Album Album { get; set; }
        public virtual MediaType GetMediaType { get; set; }


















    }
}
