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
            CreateFile();
        }

        private void CreateFile()
        {
            var pathParts = new[]
            {
                AppDomain.CurrentDomain.BaseDirectory,
                $"{DateTime.Now.ToString("d")}" + ".txt"
            };

            var path = Path.Combine(pathParts);

            if (File.Exists(path))
            {
                return;
            }
            
            using var file = new FileStream(path, FileMode.Create);
            using var stream = new StreamWriter(file, Encoding.UTF8);
        }

        public void Log(string note)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                $"{DateTime.Now.ToString("d")}" + ".txt");

            if (!File.Exists(path))
            {
                CreateFile();
            }

            using var file = new FileStream(path, FileMode.Append);
            using var stream = new StreamWriter(file, Encoding.UTF8);

            stream.WriteLine(note);
        }
    }
}
