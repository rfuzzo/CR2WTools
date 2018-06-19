﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CR2W.Types.W3;
using CR2W.Types;
using CR2W.IO;
using CR2W.Attributes;
using System.IO;
using System.Reflection;

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
            if(!File.Exists(resource))
            {
                throw new FileNotFoundException($"The file '{resource}' could not be found.");
            }
            using (var br = new CR2WBinaryReader(resource, false))
            {
                return br.CreateResource();
            }
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


        public static C2dArray LoadCSV( string resource )
        {
            if(!File.Exists(resource))
            {
                throw new FileNotFoundException($"The file '{resource}' cannot be found.");
            }

            var arr = new C2dArray();
            var lines = File.ReadAllLines(resource);

            arr.Headers = new Array<string>();
            arr.Headers.AddRange(lines[0].Split(new char[] { ';' }));

            arr.Data = new Array<Array<string>>();
            for (int i = 1; i < lines.Length; i++)
            {
                var temp = new Array<string>();
                temp.AddRange(lines[i].Split(new char[] { ';' }));
                arr.Data.Add(temp);
            }
            return arr;
        }
    }
}