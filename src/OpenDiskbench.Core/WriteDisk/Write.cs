using System;
using System.Configuration.Assemblies;
using System.IO;

namespace OpenDiskbench.Core.WriteDisk
{
    public class WriteOnDisk
    {
        public void WriteFile(string subpath = "/tmp/")
        {
            try
            {
                Console.WriteLine("init write");
                File.WriteAllBytes(subpath + "testefile", GetByteArray(2048));
                Console.WriteLine("writed");
            }
            catch (System.Exception)
            {
                Console.WriteLine("error");
                throw;
            }
        }
        private byte[] GetByteArray(int sizeInKb)
        {
            Random rnd = new Random();
            byte[] b = new byte[sizeInKb * 1024]; // convert kb to byte
            rnd.NextBytes(b);
            return b;
        }
        public void GetPath()
        {
            Console.WriteLine(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }
    }
}