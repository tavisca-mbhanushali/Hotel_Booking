using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementOperation
{
    interface IUserOperationDB
    {
        void InsertUser(Int64 Id, string FirstName, string LastName, string EmailId, string PhoneNumber);

    }
}
