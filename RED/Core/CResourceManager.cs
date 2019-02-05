using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using RED.CR2W;
using System.Diagnostics;

namespace RED.Core
{
    public static class CResourceManager
    {
        public static string DepotAttachment { get; set; }

        /// <summary>
        /// Load a CR2W file as a CResource
        /// </summary>
        /// <typeparam name="T">The CResource type to cast the file to.</typeparam>
        /// <param name="resource">Path of the resource file</param>
        /// <param name="isDepotPath">Use the absolute depot path of the file</param>
        /// <returns>CResource instance from the file</returns>
        public static T LoadResource<T>(string resource, bool isDepotPath = false) where T : CResource
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Load a CR2W file as a CResource Asynchronously
        /// </summary>
        /// <param name="resource">Path of the resource file</param>
        /// <param name="isDepotPath">Use the absolute depot path of the file</param>
        /// <returns>Task of type CResource</returns>
        public static async Task<T> LoadResourceAsync<T>(string resource, bool isDepotPath = false) where T : CResource
        {
            return await Task.Run(() => LoadResource<T>(resource, isDepotPath));
        }

        public static C2dArray LoadCSV(string resource, bool isDepotPath = false)
        {
            var arr = new C2dArray();
            arr.ImportCSV(resource);
            return arr;
        }
    }
}