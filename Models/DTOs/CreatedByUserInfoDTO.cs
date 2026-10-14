using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    /// <summary>
    /// Represents the basic user information required
    /// for displaying created-by user details in the UI.
    /// </summary>
    public class CreatedByUserInfoDTO
    {
        public int UserID { get; set; }

        public string UserName { get; set; }

        public bool IsActive { get; set; }
    }
}
