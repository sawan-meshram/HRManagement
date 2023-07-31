using System;
using System.Web;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using HRManagement.Util;
using HRManagement.Models;
using HRManagement.DAO;
using HRManagement.DAOImpl;
namespace HRManagement.Handler
{
    public class AddCandidateRegistration : IHttpHandler
    {
        public bool IsReusable => true;

        public void ProcessRequest(HttpContext context)
        {

            string firstName = context.Request.Form["firstName"];
            string lastName = context.Request.Form["lastName"];

            string designateId = context.Request.Form["designateId"];
            string gender = context.Request.Form["gender"];
            string interviewMode = context.Request.Form["interviewMode"];
            string interviewerName = context.Request.Form["interviewerName"];
            string interviewResult = context.Request.Form["result"];

            Console.WriteLine("firstName ::" + firstName);
            Console.WriteLine("lastName ::" + lastName);

            Console.WriteLine("designateId ::" + designateId);
            Console.WriteLine("gender ::" + gender);
            Console.WriteLine("interviewMode ::" + interviewMode);
            Console.WriteLine("interviewerName ::" + interviewerName);
            Console.WriteLine("interviewResult ::" + interviewResult);

            if (context.Request.Files.Count > 0)
            {
                // Get the uploaded file
                HttpPostedFile file = context.Request.Files[0];
                // Save the file to a folder or process it as needed
                string fileName = System.IO.Path.GetFileName(file.FileName);
                Console.WriteLine("fileName :" + fileName);
                string filePath = System.IO.Path.Combine(HRManagement.Util.Path.INTERVIEW_RESUME_PATH, fileName);
                file.SaveAs(filePath);

                context.Response.Write("File uploaded successfully!");
            }
            else
            {
                context.Response.Write("No file was uploaded.");
            }


        }
    }
}
