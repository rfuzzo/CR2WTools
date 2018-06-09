using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CR2W.Types.W3;
using CR2W.Types;
using CR2W.IO;
using System.IO;

namespace CR2W
{
    public static class CR2WController
    {
        /// <summary>
        /// Load a CR2W file as a CResource
        /// </summary>
        /// <param name="resource">Path of the resource file</param>
        /// <param name="isDepotPath">Use the absolute depot path of the file</param>
        /// <returns>CResource instance from the file</returns>
        public static CResource LoadResource(string resource, bool isDepotPath = false)
        {
            CR2WBinaryReader br = new CR2WBinaryReader
            (
                resource,
                new FileStream
                (
                    resource,
                    FileMode.Open,
                    FileAccess.Read
                )
            );
            return br.Resource;
        }

        /// <summary>
        /// Load a CR2W file as a CResource Asynchronously
        /// </summary>
        /// <param name="resource">Path of the resource file</param>
        /// <param name="isDepotPath">Use the absolute depot path of the file</param>
        /// <returns>Task of type CResource</returns>
        public static async Task<CResource> LoadResourceAsync(string resource, bool isDepotPath = false)
        {
            return await Task.Run(() => LoadResource(resource, isDepotPath));
        }
    }
}