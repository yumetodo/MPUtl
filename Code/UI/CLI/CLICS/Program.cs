using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;


namespace CLICS
{
    class CLI
    {
               
        static void Main(string[] args)
        {
            UInt32 vendor_buffer_size = 0;
            Icpucheck.cVendor(null, ref vendor_buffer_size);
            Int32 bsize= (Int32)vendor_buffer_size;
            StringBuilder VendorName = new StringBuilder(bsize);
            Icpucheck.cVendor(VendorName, ref vendor_buffer_size);
            UInt32 brand_buffer_size = 0;
            Icpucheck.cBrand(null, ref brand_buffer_size);
            StringBuilder BrandName = new StringBuilder((Int32)brand_buffer_size);
            Icpucheck.cBrand(BrandName, ref brand_buffer_size);

            Console.WriteLine("Vendor : {0}; Brand: {1}", VendorName.ToString(), BrandName.ToString());
            Console.WriteLine("CPU extension detected: ");
            if (Icpucheck.cSSE()) { Console.Write(" SSE "); }
            if (Icpucheck.cSSE2()) { Console.Write(" SSE2 "); }
            if (Icpucheck.cSSE3()) { Console.Write(" SSE3 "); }
            if (Icpucheck.cSSSE3()) { Console.Write(" SSSE3 "); }
            if (Icpucheck.cSSE4a()) { Console.Write(" SSE4a "); }
            if (Icpucheck.cSSE41()) { Console.Write(" SSE41 "); }
            if (Icpucheck.cSSE42()) { Console.Write(" SSE42 "); }
            if (Icpucheck.cAVX()) { Console.Write(" AVX "); }
            if (Icpucheck.cAVX2()) { Console.Write(" AVX2 "); }
            if (Icpucheck.cFMA()) { Console.Write(" FMA "); }
            if (Icpucheck.cXOP()) { Console.Write(" XOP "); }
            if (Icpucheck.cAVX512F()) { Console.Write(" AVX512F "); }
            Console.WriteLine("\nEND of CPU Detection");

            var OS = Environment.OSVersion.Platform;
            if(!Environment.Is64BitOperatingSystem)
            {
                Console.WriteLine("MPUtl requires a 64bit operation system, or this lanucher cannot determine the OS bitness.");
                Environment.Exit(-1);
            }
            if(OS==PlatformID.Win32NT)
            {
                int major_ver = Environment.OSVersion.Version.Major;
                int minor_ver = Environment.OSVersion.Version.Minor;
                float winver = (float)major_ver + (float)minor_ver / (float)10.0;
                Console.WriteLine("Detected win version: {0}", winver);
                if(winver < (float)6.1)
                {
                    ///* Ref: https://msdn.microsoft.com/library/windows/desktop/ms724832.aspx *///
                    ///* Win7 and Server 2008 R2 should be 6.1 *///
                    Console.WriteLine("Windows version {0} is not supported", winver);
                    Environment.Exit(-2);
                }
            }
            string path_slash;
            if(OS== PlatformID.Win32NT)
            {
                path_slash = @"\";
            }
            else
            {
                path_slash = @"/";
            }
            string program_path = System.Environment.CurrentDirectory;
            string plugin_path = program_path + path_slash + "plugin";
            string[] gui_list = Directory.GetFiles(program_path, "*.gui.exe", SearchOption.TopDirectoryOnly);
            
            Console.WriteLine(program_path);
            Console.WriteLine(plugin_path);
            if(args.Length < 1 || args.Contains(@"--gui") || args.Contains(@"/gui"))
            {
                ///* launch GUI exe*///
                if(gui_list.Length<1)
                {
                    Console.WriteLine("No GUI executable is found!");
                }
                else
                {
                    ///* Launch GUI *///
                    ///* At this early stage, just launch the first gui found *///
                    string gui_path = program_path + gui_list[0];
                    if(File.Exists(gui_path))
                    {
                        try
                        {
                            System.Diagnostics.Process.Start(gui_path);
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        
                    }
                }
            }
            else
            {
                ///* Carry on calling process pipeline *///
            }
        }
    }
}
