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
    [Table("Albums")]
    internal class Album
    {
        private string _ReleaseLabel;

        [Key]
        public int AlbumId { get; set; }
        [Required(ErrorMessage = "Album title is a required field")]
        [StringLength(160, ErrorMessage = "Album Title is limited to 160 characters")]
        public string Title { get; set; }

        //[ForeignKey] dont use
        public int ArtistId { get; set; }
        //do validation in Bll
        public int ReleaseYear { get; set; }
        [StringLength(50, ErrorMessage ="Release Label is limited to 50 characters")]
        public string ReleaseLabel
        {
            get { return _ReleaseLabel; }
            set { _ReleaseLabel = string.IsNullOrEmpty(value) ? null : value; }
        }
        // navigational proerties
        // An album can have zero, one, or more Tracks
        //parent (single) to children (collection)

        public virtual ICollection<Track> Tracks { get; set; }
        // an album has 1 Artists - ONE ARTIST (for this example)
        public virtual Artist Artist { get; set; }



    }
}
