using CloudLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudLibrary.Interfaces
{
    public interface ICloudServiceProvider
    {
        string ProviderDirectoryName { get; }
        void CreateInfrastructure(string infrastructureName);
        void AddResource(string infrastructureName,string resourceName, CloudServiceProviderResources resourceType, Dictionary<string, string> resourceSpecs);
        void DeleteInfrastructure(string infrastructureName);
    }
}
