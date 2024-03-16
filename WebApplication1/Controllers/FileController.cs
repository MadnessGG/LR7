using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text;

namespace WebApplication1.Controllers
{
    public class FileController : Controller
    {
        // GET: /File/DownloadFile
        public IActionResult DownloadFile()
        {
            return View();
        }

        // POST: /File/DownloadFile
        [HttpPost]
        public IActionResult DownloadFile(string firstName, string lastName, string fileName)
        {
            string fileContent = $"Ім'я: {firstName}\nПрізвище: {lastName}";
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Files", fileName + ".txt");
            System.IO.File.WriteAllText(filePath, fileContent, Encoding.UTF8);
            return PhysicalFile(filePath, "text/plain", fileName + ".txt");
        }
    }
}









