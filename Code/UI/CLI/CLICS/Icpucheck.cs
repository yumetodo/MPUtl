using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace CLICS
{
    class Icpucheck
    {
        [DllImport("cpucheck")]
        public static extern bool cSSE();
        [DllImport("cpucheck")]
        public static extern bool cSSE2();
        [DllImport("cpucheck")]
        public static extern bool cSSE3();
        [DllImport("cpucheck")]
        public static extern bool cSSSE3();
        [DllImport("cpucheck")]
        public static extern bool cSSE4a();
        [DllImport("cpucheck")]
        public static extern bool cSSE41();
        [DllImport("cpucheck")]
        public static extern bool cSSE42();
        [DllImport("cpucheck")]
        public static extern bool cAVX();
        [DllImport("cpucheck")]
        public static extern bool cAVX2();
        [DllImport("cpucheck")]
        public static extern bool cXOP();
        [DllImport("cpucheck")]
        public static extern bool cFMA();
        [DllImport("cpucheck")]
        public static extern bool cAVX512F();
        [DllImport("cpucheck")]
        public static extern bool cisIntel();
        [DllImport("cpucheck")]
        public static extern bool cisAMD();
        [DllImport("cpucheck", EntryPoint = "cVendor", CharSet = CharSet.Ansi)]
        public static extern UInt32 cVendor(StringBuilder name, ref UInt32 buffer_size);
        [DllImport("cpucheck", EntryPoint = "cBrand", CharSet = CharSet.Ansi)]
        public static extern UInt32 cBrand(StringBuilder name, ref UInt32 buffer_size);

    }
}