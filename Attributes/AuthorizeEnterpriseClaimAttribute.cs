using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Linq;
using System.Security.Claims;
namespace FactoryEnterpriseSample
{
    public class AuthorizeEnterpriseClaimAttribute : TypeFilterAttribute
    {
        public AuthorizeEnterpriseClaimAttribute(string claimType, string claimValue) : base(typeof(AuthorizeEnterpriseClaimFilter))
        {
            Arguments = new object[] { new Claim(claimType, claimValue) };
        }
    }
    public class AuthorizeEnterpriseClaimFilter : IAuthorizationFilter
    {
        readonly Claim _claim;

        public AuthorizeEnterpriseClaimFilter(Claim claim)
        {
            _claim = claim;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var hasClaim = context.HttpContext.User.Claims.Any(c => c.Type == _claim.Type && c.Value == _claim.Value);
            if (!hasClaim)
            {
                context.Result = new ForbidResult();
            }
        }
    }
}
