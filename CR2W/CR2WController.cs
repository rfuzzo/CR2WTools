using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CR2W.Types.W3;
using CR2W.Types;
using CR2W.IO;

namespace CR2W
{
    public class CR2WController
    {
        /// <summary>
        /// Load a CR2W file as a CResource
        /// </summary>
        /// <param name="resource">Path of the resource file</param>
        /// <param name="isDepotPath">Use the absolute depot path of the file</param>
        /// <returns>CResource instance from the file</returns>
        public CResource LoadResource(string resource, bool isDepotPath = false)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Load a CR2W file as a CResource Asynchronously
        /// </summary>
        /// <param name="resource">Path of the resource file</param>
        /// <param name="isDepotPath">Use the absolute depot path of the file</param>
        /// <returns>Task of type CResource</returns>
        public async Task<CResource> LoadResourceAsync(string resource, bool isDepotPath = false)
        {
            return await Task.Run(() => LoadResource(resource, isDepotPath));
        }
    }
}