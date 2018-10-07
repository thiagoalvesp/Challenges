using System;
using System.IO;
using System.Net;

namespace Challenge_Cap7
{
    class Program
    {
        static void Main(string[] args)
        {
            var content = string.Empty;
            using (var crawler = new Crawler())
            {
                crawler.Url = @"http://www.google.com.br";
                content = crawler.GetContent();
            }
            Console.WriteLine(content);
            Console.ReadKey();
        }
    }

    public class Crawler : IDisposable
    {
        bool disposed = false;
        StreamReader reader;

        public string Url { get; set; }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public string GetContent()
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(Url);
                var response = (HttpWebResponse)request.GetResponse();
                reader = new StreamReader(response.GetResponseStream());
                return reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
               if (reader != null)
                {
                    reader.Dispose();
                }
            }

            disposed = true;
        }

        ~Crawler()
        {
            Dispose(false);
        }
    }
}
