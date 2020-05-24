using System;
using System.IO;

namespace Skyhop.GribParser
{
    public static class Extensions
    {
        public static byte ReadByte(this FileStream stream, long index)
        {
            stream.Seek(index, SeekOrigin.Begin);
            return (byte)stream.ReadByte();
        }

        public static short ReadShort(this FileStream stream, long index)
        {
            stream.Seek(index, SeekOrigin.Begin);
            
            var buffer = new byte[2];
            stream.Read(buffer, 0, 2);

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(buffer);
            }

            return BitConverter.ToInt16(buffer, 0);
        }

        public static ushort ReadUShort(this FileStream stream, long index)
        {
            stream.Seek(index, SeekOrigin.Begin);

            var buffer = new byte[2];
            stream.Read(buffer, 0, 2);

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(buffer);
            }

            return BitConverter.ToUInt16(buffer, 0);
        }

        public static int ReadInt(this FileStream stream, long index) {
            stream.Seek(index, SeekOrigin.Begin);

            var buffer = new byte[4];
            stream.Read(buffer, 0, 4);

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(buffer);
            }

            return BitConverter.ToInt32(buffer, 0);
        }

        public static uint ReadUInt(this FileStream stream, long index)
        {
            stream.Seek(index, SeekOrigin.Begin);

            var buffer = new byte[4];
            stream.Read(buffer, 0, 4);

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(buffer);
            }

            return BitConverter.ToUInt32(buffer, 0);
        }

        public static long ReadLong(this FileStream stream, long index)
        {
            stream.Seek(index, SeekOrigin.Begin);

            var buffer = new byte[8];

            stream.Read(buffer, 0, 8);

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(buffer);
            }

            return BitConverter.ToInt64(buffer, 0);
        }

        public static ulong ReadULong(this FileStream stream, long index)
        {
            stream.Seek(index, SeekOrigin.Begin);

            var buffer = new byte[8];

            stream.Read(buffer, 0, 8);

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(buffer);
            }

            return BitConverter.ToUInt64(buffer, 0);
        }
    }
}
