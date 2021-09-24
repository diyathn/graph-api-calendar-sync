using System.Security;

namespace CalendarSync_Blazor_WA.Shared
{
    public static class Extenstions
    {
        public static SecureString ToSecureString(this string Source)
        {
            if (string.IsNullOrWhiteSpace(Source))
                return null;
            else
            {
                SecureString Result = new SecureString();
                foreach (char c in Source)
                {
                    Result.AppendChar(c);
                }
                return Result;
            }
        }
    }
}
