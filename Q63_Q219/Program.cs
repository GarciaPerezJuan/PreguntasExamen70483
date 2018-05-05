using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Q63_Q219
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = GetHash();

            Console.ReadKey();
        }

        public static byte[] GetHash()
        {
            var signatureAlgo = HashAlgorithm.Create("SHA1");
            var fileBuffer = System.IO.File.ReadAllBytes("F:\\Borrame\\ArchivoFirma.txt");
            Console.WriteLine("Entrada: " + Encoding.Default.GetString(fileBuffer));

            //A. Da error
            //var outputBuffer = new byte[fileBuffer.Length];
            //signatureAlgo.TransformBlock(fileBuffer, 0, fileBuffer.Length, outputBuffer, 0);
            //signatureAlgo.TransformFinalBlock(fileBuffer, fileBuffer.Length - 1, fileBuffer.Length);
            //return outputBuffer;

            //B. No compila
            //signatureAlgo.ComputeHash(fileBuffer);
            //return signatureAlgo.GetHashCode(); 

            //C. Es la misma salida
            ////var outputBuffer2 = new byte[fileBuffer.Length];
            ////signatureAlgo.TransformBlock(fileBuffer,0,fileBuffer.Length,outputBuffer2,0);
            ////Console.WriteLine();
            ////Console.WriteLine("Salida: " + Encoding.Default.GetString(outputBuffer2));
            ////return outputBuffer2;

            //D. CORRECTA.
            //var outputBuffer3 = signatureAlgo.ComputeHash(fileBuffer);
            //Console.WriteLine();
            //Console.WriteLine("Salida: " + Encoding.Default.GetString(outputBuffer3));
            //return outputBuffer3;
        }
    }
}
