﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    /// <summary>
    /// Критерий КПЭ
    /// </summary>
    public class CriteriaKPI
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
