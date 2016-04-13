using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Http;

namespace Api.Util
{
    public static class FileUpload
    {
        private const string PATH = "Images";

        /// <summary>
        /// Method for save image
        /// </summary>
        /// <param name="typeUpload"></param>
        /// <returns></returns>
        public static string Upload()
        {
            if (HttpContext.Current.Request.Files.AllKeys.Any())
            {
                var httpPostedFile = HttpContext.Current.Request.Files["Photo"];
                var parametro = HttpContext.Current.Request.Params["Photo"];

                if (httpPostedFile != null)
                {
                    string fileName;
                    string extention = httpPostedFile.FileName.Substring(httpPostedFile.FileName.Length - 5);
                    
                    do
                    {
                        fileName = Path.GetRandomFileName() + extention;
                    }
                    while (System.IO.File.Exists(Path.Combine(HttpContext.Current.Server.MapPath(VirtualPathUtility.ToAbsolute("~/" + PATH)), fileName)));

                    var fileSavePath = Path.Combine(HttpContext.Current.Server.MapPath(VirtualPathUtility.ToAbsolute("~/" + PATH)), fileName);

                    httpPostedFile.SaveAs(fileSavePath);

                    return fileName;
                }
            }
            return "File not found";
        }
    }
}