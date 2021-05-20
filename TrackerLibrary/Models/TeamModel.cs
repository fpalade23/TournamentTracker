using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// 
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// 
        /// </summary>
        public string TeamName { get; set; }
    }
}
