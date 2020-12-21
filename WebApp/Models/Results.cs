using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Results
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FaceRectangle { get; set; }
        public int ClientID { get; set; }
        public string  CameraID { get; set; }
        public string FileName { get; set; }
        public DateTime DateTime { get; set; }
    }
}
