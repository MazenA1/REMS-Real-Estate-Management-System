using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    /// <summary>
    /// Represents the basic client information displayed
    /// by the client card control.
    /// </summary>
    public class ClientCardInfoDTO
    {
        public int ClientID { get; set; }
        public string ClientTypeName { get; set; }
        public DateTime CreationDate { get; set; }
        public string Notes { get; set; }
        public short CreatedByUserID { get; set; }
        public bool IsActive { get; set; }
    }
}
