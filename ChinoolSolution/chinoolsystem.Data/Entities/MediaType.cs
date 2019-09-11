using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chinoolsystem.Data.Entities
{
    class MediaType
    {
        [Key]
        public int MediaTypeid { get; set; }

        private string _Name;

        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _Name = null;
                }
                else
                {
                    _Name = value;
                }
            }

        }

    }
}
