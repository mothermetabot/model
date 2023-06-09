/******************************************************************************
**
** <auto-generated>
**     This code was generated by a tool: UaModeler
**     Runtime Version: 1.6.8, using .NET Server 3.2.0 template (version 0)
**
**     This is a template file that was generated for your convenience.
**     This file will not be overwritten when generating code again.
**     ADD YOUR IMPLEMTATION HERE!
**
**     Generated by gresser <enrico.gresser@brand.de>
** </auto-generated>
**
** Copyright (c) 2006-2023 Unified Automation GmbH All rights reserved.
**
** Software License Agreement ("SLA") Version 2.8
**
** Unless explicitly acquired and licensed from Licensor under another
** license, the contents of this file are subject to the Software License
** Agreement ("SLA") Version 2.8, or subsequent versions
** as allowed by the SLA, and You may not copy or use this file in either
** source code or executable form, except in compliance with the terms and
** conditions of the SLA.
**
** All software distributed under the SLA is provided strictly on an
** "AS IS" basis, WITHOUT WARRANTY OF ANY KIND, EITHER EXPRESS OR IMPLIED,
** AND LICENSOR HEREBY DISCLAIMS ALL SUCH WARRANTIES, INCLUDING WITHOUT
** LIMITATION, ANY WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
** PURPOSE, QUIET ENJOYMENT, OR NON-INFRINGEMENT. See the SLA for specific
** language governing rights and limitations under the SLA.
**
** Project: .NET OPC UA SDK information model for namespace http://opcfoundation.org/UA/LADS/
**
** Description: OPC Unified Architecture Software Development Kit.
**
** The complete license agreement can be found here:
** http://unifiedautomation.com/License/SLA/2.8/
**
** Created: 25.03.2023
**
******************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using ;
using UnifiedAutomation.UaBase;
using UnifiedAutomation.UaServer;

namespace UnifiedAutomation.Lads
{
    public partial class ProgramManagerModel : TopologyElementModel, IProgramManagerMethods
    {
        /// <summary>
        /// </summary>
        /// <param name="context"></param>
        /// <param name="model"></param>
        /// <param name="Name"></param>
        /// <param name="Name">out: </param>
        /// <param name="Properties">out: </param>
        /// <param name="Data">out: </param>
        /// <param name="Data2">out: </param>
        /// <returns></returns>
        public StatusCode ProgramTemplateSet_Download(
            RequestContext context,
            ProgramManagerModel model,
            string Name,
            out string Name,
            out Variant Properties,
            out byte[] Data,
            out Variant Data2
            )
        {
            Name = null;
            Properties = Variant.Null;
            Data = null;
            Data2 = Variant.Null;
            return StatusCodes.BadNotImplemented;
        }

        /// <summary>
        /// </summary>
        /// <param name="context"></param>
        /// <param name="model"></param>
        /// <param name="Name"></param>
        /// <returns></returns>
        public StatusCode ProgramTemplateSet_Remove(
            RequestContext context,
            ProgramManagerModel model,
            string Name
            )
        {
            return StatusCodes.BadNotImplemented;
        }

        /// <summary>
        /// </summary>
        /// <param name="context"></param>
        /// <param name="model"></param>
        /// <param name="Name"></param>
        /// <param name="Properties"></param>
        /// <param name="Data"></param>
        /// <returns></returns>
        public StatusCode ProgramTemplateSet_Upload(
            RequestContext context,
            ProgramManagerModel model,
            string Name,
            Variant Properties,
            byte[] Data
            )
        {
            return StatusCodes.BadNotImplemented;
        }

    }
}

