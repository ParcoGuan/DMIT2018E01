using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chinoolsystem.Data.Entities
{
    public  class Albums
    {
        [Key]
        public int ArtstId { get; set; }

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
        public virtual Artists Artists { get; set; }
    }
}
