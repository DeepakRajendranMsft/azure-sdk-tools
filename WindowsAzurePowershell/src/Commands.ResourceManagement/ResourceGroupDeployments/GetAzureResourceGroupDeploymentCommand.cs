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

using Microsoft.Azure.Commands.ResourceManagement.Models;
using System.Collections.Generic;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.ResourceManagement.ResourceGroups
{
    /// <summary>
    /// Filters resource group deployments.
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "AzureResourceGroupDeployment"), OutputType(typeof(List<PSResourceGroupDeployment>))]
    public class GetAzureResourceGroupDeploymentCommand : ResourceBaseCmdlet
    {
        [Parameter(Position = 0, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The name of the resource group.")]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Parameter(Position = 1, Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = "The name of the resource group deployment.")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter(Position = 2, Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = "The provisioning state of the resource group deployment.")]
        [ValidateNotNullOrEmpty]
        public string ProvisioningState { get; set; }
        
        public override void ExecuteCmdlet()
        {
            WriteObject(ResourceClient.FilterResourceGroupDeployments(ResourceGroupName, Name, ProvisioningState), true);
        }
    }
}