﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Investo.Models.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }

    }
}
