using System;
using System.IO;
using System.Text;

namespace RED.IO.ChunkedLz4
{
    public class ChunkedLz4FileTable
    {
        public Lz4Chunk[] Chunks { get; set; }

        public static ChunkedLz4FileTable Read(Stream input, int chunkCount)
        {
            var buffer = new byte[12];
            Lz4Chunk[] chunks = new Lz4Chunk[chunkCount];
            for (int i = 0; i < chunkCount; i++)
            {
                input.Read(buffer, 0, 12);
                chunks[i] = new Lz4Chunk
                {
                    CompressedChunkSize = BitConverter.ToInt32(buffer, 0),
                    DecompressedChunkSize = BitConverter.ToInt32(buffer, 4),
                    EndOfChunkOffset = BitConverter.ToInt32(buffer, 8),
                };
            }
            
            return new ChunkedLz4FileTable
            {
                Chunks = chunks,
            };
        }
    }
}