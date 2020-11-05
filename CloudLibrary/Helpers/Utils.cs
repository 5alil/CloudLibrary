using CloudLibrary.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CloudLibrary.Helpers
{
    static class Utils
    {
        public static string GetBasePath()
        {
            string currentDir = Path.GetDirectoryName(Environment.CurrentDirectory);
            string baseDir = currentDir + "\\Cloud_Providers\\";
            return baseDir;
        }
        public static void CreateDirectory(string path)
        {
            // If directory does not exist, create it. 
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
        public static void CreateInfrastructureDirectory(string ProviderDirectoryName, string infrastructureName)
        {
            string newDir = GetBasePath() + ProviderDirectoryName + "\\" + infrastructureName;
            CreateDirectory(newDir);
        }

        public static void AddInfrastructureResource(string ProviderDirectoryName, string infrastructureName, string resourceName, CloudServiceProviderResources resourceType, Dictionary<string, string> resourceSpecs)
        {
            string newDir = GetBasePath() + ProviderDirectoryName + "\\" + infrastructureName + "\\" + resourceType.ToString();
            CreateDirectory(newDir);

            string resourceSpecsAsJSON = JsonConvert.SerializeObject(resourceSpecs, Formatting.Indented);
            File.WriteAllText(newDir + "\\" + infrastructureName + "_" + resourceName + ".json", resourceSpecsAsJSON);
        }

        public static void DeleteInfrastructure(string ProviderDirectoryName, string infrastructureName)
        {
            string infrastructureDir = GetBasePath() + ProviderDirectoryName + "\\" + infrastructureName;
            foreach (var subDir in new DirectoryInfo(infrastructureDir).GetDirectories())
            {
                subDir.Delete(true);
            }
        }
    }
}
