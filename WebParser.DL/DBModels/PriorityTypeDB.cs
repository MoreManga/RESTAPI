﻿using CommonLib.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebParser.DL.DBModels
{
    [Table("PriorityType")]
    public class PriorityTypeDB : IBaseDBModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
