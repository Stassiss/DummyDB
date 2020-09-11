using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DemoDB.Models
{
    
    public class Piemers
    {
        
        [Column(name:"Trasakcijas kods")]
        public int CodeName { get; set; }
        [Column(name: "Apraksts")]

        public string Description { get; set; }
    }
}
