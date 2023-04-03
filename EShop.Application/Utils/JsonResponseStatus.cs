using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Application.Utils
{
    public static class JsonResponseStatus
    {
        public static JsonResult Success()
        {
            var serializerSettings = new JsonSerializerSettings
            {
                StringEscapeHandling = StringEscapeHandling.Default
            };

            return new JsonResult(new {status = "Success"}, serializerSettings);
        }
        
        public static JsonResult Success(object returnData)
        { 
            return new JsonResult(new {status = "Success", data = returnData}, new JsonSerializerSettings
            {
                StringEscapeHandling = StringEscapeHandling.Default
            });
        }

        public static JsonResult NotFound()
        {
            return new JsonResult(new { status = "NotFound"});
        }

        public static JsonResult NotFound(object returnData)
        {
            return new JsonResult(new { status = "NotFound", data = returnData });
        }

        public static JsonResult Error()
        {
            return new JsonResult(new { status = "Error" });
        }

        public static JsonResult Error(object returnData)
        {
            return new JsonResult(new { status = "Error", data = returnData });
        }
    }
}
