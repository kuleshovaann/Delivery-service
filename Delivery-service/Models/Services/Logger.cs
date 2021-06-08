using DeliveryService.Contracts;
using System;
using System.IO;
using System.Text;

namespace DeliveryService.Services
{
    public class Logger : ILogger
    {
        public Logger()
        {
            CreateOrOpenFile();
        }

        public string CreateOrOpenFile()
        {
            var pathParts = new[]
            {
                AppDomain.CurrentDomain.BaseDirectory,
                $"{DateTime.Now.ToString("d")}" + ".txt"
            };

            var path = Path.Combine(pathParts);

            if (File.Exists(path))
            {
                return path;
            }

            using var file = new FileStream(path, FileMode.Create);
            using var stream = new StreamWriter(file, Encoding.UTF8);

            return null;
        }

        public void CreateNewNote(string note)
        {
            using var file = new FileStream(CreateOrOpenFile(), FileMode.Append);
            using var stream = new StreamWriter(file, Encoding.UTF8);

            stream.WriteLine(note);
        }    
    }
}
