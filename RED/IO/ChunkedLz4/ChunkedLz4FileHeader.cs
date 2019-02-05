using System;
using System.IO;
using System.Text;

namespace RED.IO.ChunkedLz4
{
    public class ChunkedLz4FileHeader
    {
        public int ChunkCount { get; set; }
        public int HeaderSize { get; set; }

        public static ChunkedLz4FileHeader Read(Stream input)
        {
            var buffer = new byte[8];

            input.Read(buffer, 0, 4);
            var saveFileHeader = BitConverter.ToUInt32(buffer, 0);
            if (saveFileHeader != 0x48464E53)
            {
                throw new InvalidOperationException();
            }

            input.Read(buffer, 4, 4);
            var chunkedLz4FileHeader = BitConverter.ToUInt32(buffer, 4);
            if (chunkedLz4FileHeader != 0x434C5A46)
            {
                throw new InvalidOperationException();
            }

            input.Read(buffer, 0, 8);
            return new ChunkedLz4FileHeader
            {
                ChunkCount = BitConverter.ToInt32(buffer, 0),
                HeaderSize = BitConverter.ToInt32(buffer, 4),
            };
        }
    }
}