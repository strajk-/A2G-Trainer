using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A2G_Trainer_XP.Controller
{
    interface IMemoryAccess
    {
        byte ReadByte(IntPtr address);
        void WriteByte(IntPtr address, byte value);
        ushort ReadInt16(IntPtr address);
        void WriteInt16(IntPtr address, ushort value);
        int ReadInt32(IntPtr address);
        void WriteInt32(IntPtr address, int value);
        byte ReadBytes(IntPtr address, int len);
        void WriteBytes(IntPtr address, byte[] data);
    }
}
