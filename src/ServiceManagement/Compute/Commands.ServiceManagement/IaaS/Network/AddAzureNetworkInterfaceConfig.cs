﻿// ----------------------------------------------------------------------------------
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
using System.Management.Automation;
using Microsoft.WindowsAzure.Commands.ServiceManagement.Model;
using Microsoft.WindowsAzure.Commands.ServiceManagement.Properties;
namespace Microsoft.WindowsAzure.Commands.ServiceManagement.IaaS.Network
{
    [Cmdlet(VerbsCommon.Add, NetworkInterfaceConfig), OutputType(typeof(IPersistentVM))]
    public class AddAzureNetworkInterfaceConfig : VirtualMachineConfigurationCmdletBase
    {
        [Parameter(Position = 1, Mandatory = true, HelpMessage = "The NetworkInterface Name.")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter(Position = 2, Mandatory = true, HelpMessage = "The Subnet Name.")]
        [ValidateNotNullOrEmpty]
        public string SubnetName { get; set; }

        [Parameter(Position = 3, Mandatory = false, HelpMessage = "The Subnet Name.")]
        public string StaticVNETIPAddress { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            var networkConfiguration = GetNetworkConfiguration();
            if (networkConfiguration == null)
            {
                throw new ArgumentOutOfRangeException(Resources.NetworkConfigurationNotFoundOnPersistentVM);
            }

            if (networkConfiguration.NetworkInterfaces == null)
            {
                networkConfiguration.NetworkInterfaces = new AssignNetworkInterfaceCollection();
            }

            networkConfiguration.NetworkInterfaces.Add(
                new AssignNetworkInterface()
                {
                    Name = this.Name,
                    IPConfigurations = new AssignIPConfigurationCollection()
                    {
                        new AssignIPConfiguration
                        {
                            SubnetName = this.SubnetName,
                            StaticVirtualNetworkIPAddress = this.StaticVNETIPAddress
                        }
                    }
                });
            WriteObject(VM);
        }
    }
}


