using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region addditional namespace
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
#endregion

namespace chinoolsystem.Data.Entities
{
    [Table("Artsties")]
    public class Artist
    {
        [Key]
        public int ArtstId { get; set; }
        private string _Name;
        
        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    _Name = null;
                }
                else
                {
                    _Name = value;
                }
            }

        }
        

        public virtual ICollection<Album> Albums { get; set; }




    }
}
