using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chinoolsystem.Data.Entities
{
     public class Track
    {
        [Key]
        public int Trackid { get; set; }
        public int ArtstId { get; set; }
        public string Name { get; set; }

        private string _Albumid;
        public string Albumid
        {
            get
            {
                return Albumid;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _Albumid = null;
                }
                else
                {
                    _Albumid = value;
                }
            }

        }

        public int MediaTypeid { get; set; }
        private string _Genreid;
        public string Genreid 
        {
            get
            {
                return Genreid;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _Genreid = null;
                }
                else
                {
                    _Genreid = value;
                }
            }

        }
        public int Milliseconds { get; set; }
        private string _bytes;

        public string Bytes
        {
            get
            {
                return Bytes;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _bytes = null;
                }
                else
                {
                    _bytes = value;
                }
            }

        }

        private string _composer;

        public string Composer
        {
            get
            {
                return Composer;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _composer = null;
                }
                else
                {
                    _composer = value;
                }
            }

        }
        public double UnitPrice { get; set; }

    }
}
