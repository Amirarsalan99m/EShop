using Ganss.Xss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Application.Security
{
    static class XssSecurity
    {
        public static string SanitizeText(this string text)
        {
            var htmlSanitize = new HtmlSanitizer();

            htmlSanitize.KeepChildNodes = true;

            htmlSanitize.AllowDataAttributes = true;

            return htmlSanitize.Sanitize(text);
        }
    }
}
