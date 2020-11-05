using CloudLibrary.Enums;
using CloudLibrary.Helpers;
using CloudLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudLibrary.Domain
{
    class AzureCloudService : ICloudServiceProvider
    {
        public string ProviderDirectoryName => "Azure";
        public void CreateInfrastructure(string infrastructureName)
        {
            Utils.CreateInfrastructureDirectory(ProviderDirectoryName, infrastructureName);
        }
        public void AddResource(string infrastructureName, string resourceName, CloudServiceProviderResources resourceType, Dictionary<string, string> resourceSpecs)
        {
            Utils.AddInfrastructureResource(ProviderDirectoryName, infrastructureName, resourceName, resourceType, resourceSpecs);
        }
        public void DeleteInfrastructure(string infrastructureName)
        {
            Utils.DeleteInfrastructure(ProviderDirectoryName, infrastructureName);
        }
    }
}
