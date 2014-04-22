using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPresentation
{
    class NativeMethods
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct NativeMessage
        {
            public IntPtr Handle;
            public uint Message;
            public IntPtr WParameter;
            public IntPtr LParameter;
            public uint Time;
            public System.Drawing.Point Location;
        }

        [DllImport("user32.dll")]
        public static extern bool PeekMessage(out Message message, IntPtr window,
            uint messageFilterMinimum, uint messageFilterMaximum, uint shouldRemoveMessage);
    }
}
