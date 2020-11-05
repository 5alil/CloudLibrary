using CloudLibrary.Domain;
using CloudLibrary.Enums;
using CloudLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudLibrary.APIs
{
    public static class CloudServiceProviderFactory
    {
        public static ICloudServiceProvider ConstructCloudProvider(CloudServiceProviders cloudProvider)
        {
            ICloudServiceProvider provider = null;
            switch (cloudProvider)
            {
                case CloudServiceProviders.IGS:
                    provider = new IGSCloudService();
                    break;
                case CloudServiceProviders.Azure:
                    provider = new AzureCloudService();
                    break;
                case CloudServiceProviders.AWS:
                    provider = new AWSCloudService();
                    break;
                case CloudServiceProviders.Google:
                    provider = new GoogleCloudService();
                    break;
                default:
                    provider = new IGSCloudService();
                    break;
            }
            return provider;
        }
    }
}
