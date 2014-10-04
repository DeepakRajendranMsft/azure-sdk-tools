
// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Management.Automation;
using Microsoft.WindowsAzure.Commands.ServiceManagement.Model;
using Microsoft.WindowsAzure.Commands.ServiceManagement.Properties;

namespace Microsoft.WindowsAzure.Commands.ServiceManagement.IaaS.Network
{
    [Cmdlet(VerbsCommon.Get, NetworkInterfaceConfig), OutputType(typeof(IPersistentVM))]
    public class GetAzureNetworkInterfaceConfig : VirtualMachineConfigurationCmdletBase
    {
        [Parameter(Position = 1, Mandatory = false, HelpMessage = "The NetworkInterface Name.")]
        public string Name { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            var networkConfiguration = GetNetworkConfiguration();
            if (networkConfiguration == null)
            {
                throw new ArgumentOutOfRangeException(Resources.NetworkConfigurationNotFoundOnPersistentVM);
            }

            if (networkConfiguration.NetworkInterfaces != null)
            {
                if (string.IsNullOrEmpty(Name))
                {
                    WriteObject(networkConfiguration.NetworkInterfaces, true);
                }
                else
                {
                    var nics =
                        networkConfiguration.NetworkInterfaces.Where(
                            n => string.Equals(n.Name, this.Name, StringComparison.OrdinalIgnoreCase)).ToList();

                    if (nics.Count != 0)
                    {
                        WriteObject(nics.First());
                    }
                }
            }
        }
    }
}