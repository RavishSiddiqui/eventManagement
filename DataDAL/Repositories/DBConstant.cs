using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDAL.Repositories
{
    internal class DBConstant
    {
        #region Login
        public const string ValidateUser = "PROC_ValidateUser";
        public const string RegisterUser = "InserUser";
        #endregion
        #region Venue
        public const string AddVenue = "PROC_AddVenue";
        #endregion
    }
}
