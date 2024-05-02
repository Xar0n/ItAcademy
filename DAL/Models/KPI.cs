using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    /// <summary>
    /// КПЭ
    /// Id, Наименование, Есть в справочнике, Критерии
    /// </summary>
    public class KPI
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public bool ExistInDict { get; set; }
    }
}
