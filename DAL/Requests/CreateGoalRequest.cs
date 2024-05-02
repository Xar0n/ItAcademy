using DAL.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Requests
{
    public class CreateGoalRequest
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Коэффициент
        /// </summary>
        public decimal Coef { get; set; }

        /// <summary>
        /// Критерии
        /// </summary>
        public List<CriteriaDto> Criterias {get; set;}
    }
}
