using Microsoft.AspNetCore.Authorization;

using static Server.Data.Common.Constants.ValidationConstants.Identity;

namespace Server.Extensions
{
    public class AuthorizeAdministratorAttribute : AuthorizeAttribute
    {
        public AuthorizeAdministratorAttribute() => this.Roles = AdministratorRole;
    }
}
