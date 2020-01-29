using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace APIFestival.Models
{
    public class Festivalier:Personne
    {
        public string Genre { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Naissance { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Mdp { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string Rue { get; set; }
        public string Pays { get; set; }

        [ForeignKey("Festival")]
        public int FestivalId { get; set; }
        public virtual Festival Festival { get; set; }
    }
}