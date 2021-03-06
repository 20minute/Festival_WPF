﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIFestival.Models
{
    public class Organisateur
    {
        public int Id { get; set; }

        public string Login { get; set; }
        public string Mdp { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public virtual ICollection<Festival> Festivals { get; set; }

    }
}