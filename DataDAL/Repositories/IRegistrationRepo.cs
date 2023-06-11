using DataDOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDAL.Repositories
{
    public interface IRegistrationRepo
    {
        string NEW_Customer(Registration Registration);
        string NEW_Admin(Registration registration);
    }
}
