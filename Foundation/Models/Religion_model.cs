﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Foundation.Models;
[Table("Religion")]
public class Religion_model
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("religion_id")]
    public int Religion_modelId { get; set; }

    [Column("type")]
    [MaxLength(20)]
    public string Type { get; set; }


    public virtual ICollection<Person_model> Person_model { get; set; }

}