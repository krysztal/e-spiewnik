﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace espiewnik.Entities
{
    [Table("Voice")]
    public class Voice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(20)]
        public string Name { get; set; }

        public ICollection<Scope> Scops { get; set; }
    }
}
