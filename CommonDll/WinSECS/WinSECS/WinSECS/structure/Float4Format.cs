﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinSECS.structure
{
    public class Float4Format : Format
    {
        private const long serialVersionUID = 1L;
        public static readonly byte TYPE = 0x24;

        public override int encoding(int startPos, byte[] bs)
        {
            string[] splits = this.Value.Split(new char[] { ' ' });
            int num = this.getLowerLoopCountBetweenLengthAndSplits(splits);
            this.Length = num;
            startPos = base.encodingHeader(startPos, bs);
            byte[] destinationArray = new byte[this.Length * this.DefaultByteLength];
            for (int i = 0; i < num; i++)
            {
                Array.Copy(this.float2Byte(float.Parse(splits[i])), 0, destinationArray, i * 4, 4);
            }
            Array.Copy(destinationArray, 0, bs, startPos, destinationArray.Length);
            return (startPos += destinationArray.Length);
        }

        private byte[] float2Byte(float data)
        {
            try
            {
                byte[] buffer = new byte[4];
                return FormatUtility.swapFloat(BitConverter.GetBytes(data));
            }
            catch (Exception)
            {
                return new byte[4];
            }
        }

        public override int valueCopy(byte[] bs, int pos)
        {
            int length = this.Length * this.DefaultByteLength;
            byte[] destinationArray = new byte[length];
            Array.Copy(bs, pos, destinationArray, 0, length);
            this.Value = ByteToObject.byte2Float4String(destinationArray);
            return (pos += length);
        }

        public override int DefaultByteLength
        {
            get
            {
                return 4;
            }
        }

        public override string LogType
        {
            get
            {
                return "F4";
            }
        }

        public override byte Type
        {
            get
            {
                return TYPE;
            }
        }
    }
}
