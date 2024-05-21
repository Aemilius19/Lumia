using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumia_Domain
{
    public  class TeamSlider
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string? ImgUrl {  get; set; }
    }
}
