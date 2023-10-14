using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Runtime.Serialization;
using System.Security.Principal;
using System.Threading.Tasks;

namespace TicketApplication.Authentication
{
    public class AppUser : WindowsIdentity
    {
        public AppUser(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
    public class CurrentUser: IdentityUser
    {

    }

}
