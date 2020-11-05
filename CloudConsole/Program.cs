using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudLibrary.Interfaces;
using CloudLibrary.Enums;
using CloudLibrary.APIs;


namespace CloudConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------------------------------------------------------------------
            //-- Here you Can test the Cloud Library, you can use the comments for test every part alone.  
            //-------------------------------------------------------------------------------------------

            // -- Here you can construct, which any Cloud Provider will deal with. 
            ICloudServiceProvider igsCloudProvider = CloudServiceProviderFactory.ConstructCloudProvider(CloudServiceProviders.IGS);

            // -- Create New Infrastructure in the cloud provider you constructed before.
            igsCloudProvider.CreateInfrastructure("UAT");

            // -- Add Resources for the Infrastructure.
            Dictionary<string, string> specs = new Dictionary<string, string>();
            specs.Add("RAM", "16 GB");
            specs.Add("Storage", "1000 GB");
            specs.Add("Proccessor", "4 Cores");
            specs.Add("OS", "Windows");
            igsCloudProvider.AddResource("UAT", "SERVER", CloudServiceProviderResources.VirtualMachine, specs);

            // -- Delete the Infrastructure
            igsCloudProvider.DeleteInfrastructure("UAT");
        }

    }
}
