namespace Lesnichestvo.Extensions
{
    public static class IHttpContextExtensions
    {
        public static bool IsUserInRoles(this HttpContext context, params string[] roles)
        {
            if (context is null)
            {
                return false;
            }

            foreach (string role in roles)
            {
                if(context.User.IsInRole(role))
                    return true;
            }
            return false;
        }
    }
}
