using System;
using System.Globalization;
namespace HRManagement.Util
{
    public class U
    {
        public U()
        {
        }

        //Convert string to capitalise except the upper case
        public static string ToTitleCase(string title)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(title.ToLower());
        }
    }
}
