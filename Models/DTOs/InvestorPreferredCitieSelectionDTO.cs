using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    public class InvestorPreferredCitieSelectionDTO
    {
        public short CitieId { get; set; }
        public string CitieName {  get; set; }
        public short PlateCode {  get; set; } 
        public bool Selected {  get; set; }  
    }
}
