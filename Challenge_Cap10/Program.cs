using System;
using System.IO;
using System.Net;

namespace Challenge_Cap10
{
    class Program
    {

        //Talves o link não funcione.
        //https://picsum.photos/200/300/?random

        static void Main(string[] args)
        {
            FileStream file = File.Create("ImageData");
            BinaryWriter binaryWriter = new BinaryWriter(file);
            //Download to Binary and Save
            WebRequest request = WebRequest.Create("https://picsum.photos/200/300/?random");
            WebResponse response = request.GetResponse();
            MemoryStream memoryStream = new MemoryStream();
            response.GetResponseStream().CopyTo(memoryStream);
            byte[] img = memoryStream.ToArray();
            binaryWriter.Write(img);
            binaryWriter.Close();
            Console.WriteLine("Binary Writer Complete!");

            //Save img
            FileStream fileToOpen = File.Open("ImageData", FileMode.Open);
            BinaryReader binaryReader = new BinaryReader(fileToOpen);
           
            FileStream fileImg = File.Create("ImageData.jpg");
            BinaryWriter bw = new BinaryWriter(fileImg);
            byte[] imgJpg = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
            bw.Write(imgJpg);
            bw.Close();
            Console.WriteLine("Save Img Complete!");

            Console.ReadLine();

        }
    }
}
