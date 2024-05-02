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
    /// Модель сотрудника
    /// </summary>
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }

        public string Login { get; set; }
        public string Password { get; set; }
        public int DepartmentId { get; set; }

        public bool IsHead { get; set; }

        /// <summary>
        /// Дата устройства
        /// </summary>
        public DateTime DateIn { get; set; }

        public string? Email { get; set; }
        
        [ForeignKey(nameof(DepartmentId))]
        public Department? Department { get; set; }
    }
}
