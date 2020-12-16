using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PonySample.GeneratedCodeCustom
{
    [Table("room_master_table")]
    public partial class room_master_table
    {
        [Key]
        public long id { get; set; }
        public string identity_hash { get; set; }
    }
}
