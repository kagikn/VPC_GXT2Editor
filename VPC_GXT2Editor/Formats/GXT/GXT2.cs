using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VPC_GXT2Editor.Formats.GXT
{
    public class GXT2
    {
        public const int Header = 0x47585432; //"GXT2"

        public Dictionary<uint, byte[]> DataItems;
        public void AddStringItem(string name, string str)
        {
            DataItems.Add(Utils.GetHash(name), System.Text.Encoding.UTF8.GetBytes(str));
        }
        public void AddStringItem(uint hash, string str)
        {
            DataItems.Add(hash, System.Text.Encoding.UTF8.GetBytes(str));
        }
        public GXT2()
        {
            DataItems = new Dictionary<uint, byte[]>();
        }

        public GXT2(Stream xIn)
        {
            this.DataItems = new Dictionary<uint, byte[]>();
            BinaryReader reader = new BinaryReader(xIn);
            reader.ReadInt32(); //header
            int itemcount = reader.ReadInt32();
            for (int i = 0; i < itemcount; i++)
            {
                uint hash = reader.ReadUInt32();
                int location = reader.ReadInt32();

                long tempLoc = reader.BaseStream.Position;

                reader.BaseStream.Position = location;
                List<byte> thisItemBytes = new List<byte>();
                while (true)
                {
                    byte b = reader.ReadByte();
                    if (b == 0)
                        break;
                    thisItemBytes.Add(b);

                }
                reader.BaseStream.Position = tempLoc;
                this.DataItems.Add(hash, thisItemBytes.ToArray());
            }

        }
        public void WriteToStream(Stream xOut)
        {
            BinaryWriter writer = new BinaryWriter(xOut);

            writer.Write(Header);
            writer.Write(DataItems.Count);

            long startTablePos = writer.BaseStream.Position;
            foreach (KeyValuePair<uint, byte[]> datas in this.DataItems)
            {
                writer.Write(datas.Key);
                writer.Write(0);
            }

            writer.Write(Header); //end header
            long endHeaderLoc = writer.BaseStream.Position;
            writer.Write(0);

            int indexer = 0;
            foreach (KeyValuePair<uint, byte[]> datas in DataItems)
            {
                byte[] thisItemData = datas.Value;
                long _thisItemDataWriteLoc = writer.BaseStream.Position;
                writer.BaseStream.Position = startTablePos + (indexer * 8) + 4;
                writer.Write((int)_thisItemDataWriteLoc);
                writer.BaseStream.Position = _thisItemDataWriteLoc;
                writer.Write(thisItemData, 0, thisItemData.Length);
                writer.Write((byte)0);
                indexer++;
            }

            long _finalEndLoc = writer.BaseStream.Position;
            writer.BaseStream.Position = endHeaderLoc;
            writer.Write((int)_finalEndLoc);
            writer.Flush();
        }
    }
}
