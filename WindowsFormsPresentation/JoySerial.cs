using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPresentation
{
    public class JoySerial
    {
        public static byte[] GetSerialCommand(float x, float y)
        {
            byte startByte = (byte)0x02;
            byte endByte = (byte)0x03;
            byte[] xBytes = _ConvertPercentToBytes(x);
            byte[] yBytes = _ConvertPercentToBytes(y);
            byte[] serialBytes = new byte[6] { startByte, xBytes[0], xBytes[1], yBytes[0], yBytes[1], endByte };
            return serialBytes;
        }

        public static string GetSerialCommandToString(byte[] serialBytes)
        {
            return String.Join(" ", serialBytes.Select(b => b.ToString("X2")));
        }

        static byte[] _ConvertPercentToBytes(float percent)
        {
            byte byteOne = (byte)0x00;
            byte byteTwo = (byte)0x00;
            int zeroOneOffset = 72;
            int oneTwoOffset = 56;
            int ofOneHundred = (int)(percent * 100);
            if (ofOneHundred > 55)
            {
                byteOne = (byte)0x02;
                byteTwo = (byte)(ofOneHundred - oneTwoOffset);
            }
            else
            {
                if (ofOneHundred < -zeroOneOffset)
                {
                    byteOne = (byte)0x00;
                    byteTwo = (byte)(ofOneHundred + zeroOneOffset - 128);
                }
                else
                {
                    byteOne = (byte)0x01;
                    byteTwo = (byte)(ofOneHundred + zeroOneOffset);
                }
            }
            return new byte[2] { byteOne, byteTwo };
        }
    }
}
