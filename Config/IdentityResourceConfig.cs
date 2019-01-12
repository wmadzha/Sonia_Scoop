public static IEnumerable<IdentityResource> GetIdentityResources()
{
    var openid = new IdentityResources.OpenId();
    var profile = new IdentityResources.Profile();
    profile.UserClaims.Add("accounting_module");
    profile.UserClaims.Add("humanresource_module");
    profile.UserClaims.Add("warehouse_module");
    profile.UserClaims.Add("marketing_module");
    var data = new List<IdentityResource>
    {   
       openid,profile
    };
    return data;
}
