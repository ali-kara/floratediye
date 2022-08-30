using Core.Entities.Abstract;
using Entities.Log.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Log.Concrete
{
    public class AppVersion : IEntity
    {
        //TODO: Version TypeSafe olarak saklanmalı.

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public string Version { get; set; }
        public string Description { get; set; }
        public bool IsForcedUpdate { get; set; }

        public DevicePlatform Platform { get; set; }
    }
}

