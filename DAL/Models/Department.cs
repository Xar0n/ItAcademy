using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Department
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CompanyId { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [ForeignKey(nameof(CompanyId))]
        public Company Company { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<User> Employees { get; set; }
    }
}
