using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIFestival.Models.DTO
{
    public class SceneDTO
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Capacite { get; set; }
        public string Accessibilite { get; set; }


        //public IEnumerable<ProgrammationDTO> Programmations { get; set; }
    }
}