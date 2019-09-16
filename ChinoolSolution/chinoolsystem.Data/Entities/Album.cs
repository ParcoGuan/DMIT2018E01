using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chinoolsystem.Data.Entities
{

    [Table("Albums")]
    public  class Album
    {
        [Key]
        public int ArtistId { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public int Albumid { get; set; }

        private string _ReleaseLabel;
        public string ReleaseLabel
        {
            get
            {
                return ReleaseLabel;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _ReleaseLabel = null;
                }
                else
                {
                    _ReleaseLabel = value;
                }
            }

        }
        public virtual Artist Artists { get; set; }
    }
}
