using Skyhop.GribParser.Sections;
using Skyhop.GribParser.Tables;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Skyhop.GribParser
{
    public static class Parsers
    {

        //public static async Task<LocalUse> ParseLocalUseSection(this FileStream stream)
        //{
        //    var localUse = new LocalUse();

        //    var buffer = new byte[5];

        //    // ToDo: Base this offset on the previous sections
        //    stream.Seek(16 + 21, SeekOrigin.Begin);
        //    await stream.ReadAsync(buffer, 0, 5);

        //    var lengthBuffer = new byte[4];

        //    Array.Copy(buffer, lengthBuffer, 4);

        //    if (BitConverter.IsLittleEndian)
        //        Array.Reverse(lengthBuffer);

        //    localUse.Length = BitConverter.ToInt32(lengthBuffer, 0);
        //    localUse.Number = buffer[4];

        //    return localUse;
        //}
    }
}
