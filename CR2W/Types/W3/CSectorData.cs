using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CR2W.IO;

namespace CR2W.Types.W3
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class CSectorData : /*ISerializable*/ CObject
    {
        public UInt32 Unknown1 { get; set; }
        //public byte Unknown2 { get; set; }
        public UInt32 Unknown2 { get; set; }

        public override ushort Flags { get; set; }
        public override uint Template { get; set; }


        //public SSectorDataResource[] resources { get; set; }
        //public SSectorDataObject[]   objects { get; set; }
        [TypeConverter(typeof(ListConverter))]
        public List<SSectorDataResource> resources { get; set; }
        [TypeConverter(typeof(ListConverter))]
        public List<SSectorDataObject>   objects { get; set; }
        //[TypeConverter(typeof(ListConverter))]
        //public List<List<byte>> blockdata { get; set; }

        /*public override event SerializeEventHandler Serialize;
        public override event DeSerializeEventHandler DeSerialize;

        public override void OnSerialize(IFile source, REDEventArgs e)
        {
            throw new NotImplementedException();
        }

        public override void OnDeSerialize(IFile source, REDEventArgs e)
        {
            throw new NotImplementedException();
        }*/

        public override void ParseBytes(CR2WBinaryReader br, uint size)
        {
            //base.ParseBytes(br, size);
            ReadCSectorData(br);

        }

        public void ReadCSectorData(CR2WBinaryReader br)
        {
            var temp = new CSectorData
            {
                Unknown1 = br.ReadUInt32(),
                Unknown2 = br.ReadUInt32(),
                //Unknown2 = br.ReadByte(),
            };

            var numresources = br.Read7BitFlaggedValue();
            //resources = new SSectorDataResource[numresources];
            resources = new List<SSectorDataResource>();
            for (int i = 0; i < numresources; i++)
            {
                resources.Add( new SSectorDataResource()
                {
                    box0 = br.ReadSingle(),
                    box1 = br.ReadSingle(),
                    box2 = br.ReadSingle(),
                    box3 = br.ReadSingle(),
                    box4 = br.ReadSingle(),
                    box5 = br.ReadSingle(),
                    patchHash = br.ReadUInt64(),
                });
            }

            var numobjects = br.Read7BitFlaggedValue();
            //objects = new SSectorDataObject[numobjects];
            objects = new List<SSectorDataObject>();
            for (int i = 0; i < numobjects; i++)
            {
                objects.Add(new SSectorDataObject()
                {
                    type = br.ReadByte(),
                    flags = br.ReadByte(),
                    radius = br.ReadUInt16(),
                    offset = br.ReadUInt64(),
                    positionX = br.ReadSingle(),
                    positionY = br.ReadSingle(),
                    positionZ = br.ReadSingle(),
                });
            }

            int datasize = br.Read7BitFlaggedValue();
            var blockdata = ReadBlockData(br, datasize);

            //adding blockdata to the objects
            if (objects.Count == blockdata.Count)
            {
                for (int i = 0; i < blockdata.Count; i++)
                {
                    objects[i].blockdata = blockdata[i];
                    //ParseBlockData(br, blockdata[i]);
                }
            }
            
        }

        public List<List<byte>> ReadBlockData(CR2WBinaryReader br, int datasize)
        {
            List<List<byte>> temp = new List<List<byte>>();

            //go through all SSectorDataObjects an split the blockdata up
            for (int i = 0; i < objects.Count; i++)
            {
                //get the length of the current chunk inside the blockdata
                int curoffset = (int)objects[i].offset;
                int nextoffset = datasize;
                if (i != objects.Count -1) nextoffset = (int)objects[i+1].offset;
                int length = nextoffset - curoffset;

                //read the stream for that length
                List<byte> curchunk = new List<byte>();

                //parse the chunk
                /*
                 * type 1 - 64 bytes
                 * type 2 - 76 bytes
                 * type 3 - 76 bytes
                 */
                //var test = br.Read7BitFlaggedValue();


                curchunk.AddRange(br.ReadBytes(length).ToList());
                temp.Add(curchunk);

                

            }

            return temp;
        }

        public void ParseBlockData(CR2WBinaryReader br, List<byte> data)
        {
            


        }

    }
}
