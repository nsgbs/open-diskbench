using OpenDiskbench.Core.WriteDisk;

namespace OpenDiskbench.Core
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting write on disk:");
            WriteOnDisk wd = new WriteOnDisk();
            wd.WriteFile();
        }
    }
}
