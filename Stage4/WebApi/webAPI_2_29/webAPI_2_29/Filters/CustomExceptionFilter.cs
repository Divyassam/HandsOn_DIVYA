using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace webAPI_2_29.Filters
{
    public class CustomExceptionFilter:IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var exceptionDetail = context.Exception;
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\logs"))
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\logs");
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\logs\\ServiceLog_" + DateTime.Now.Date.ToShortDateString().Replace('/', '-') + ".txt";
            //string filepath = @"C:\Users\Vraj\Desktop\#\Handson\WebAPI\EmployeeAPI\EmployeeAPI\log.txt";


            if (!File.Exists(filepath))
                File.Create(filepath);


            else
            {
                using (StreamWriter writer = File.AppendText(filepath))
                {
                    writer.WriteLine("******************************************");
                    writer.WriteLine("Exception:");
                    writer.WriteLine("Message: " + exceptionDetail.Message);
                    writer.WriteLine(DateTime.Now);
                }
                context.ExceptionHandled = true;
                context.Result = new ExceptionResult(exceptionDetail, true);
            }
        }

    }
}
