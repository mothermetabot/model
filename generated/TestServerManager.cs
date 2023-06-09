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
** Project: .NET OPC UA SDK information model for namespace http://spectaris.de/DynamicMechanicalAnalyzer/
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
using UnifiedAutomation.UaServer;

namespace Netzsch.LadshackDma
{
    internal class TestServerManager : ServerManager
    {
        public TestServerManager()
        {
        }

        protected override void OnRootNodeManagerStarted(RootNodeManager nodeManager)
        {
            UnifiedAutomation.UaServer.BaseNodeManager nm;
            nm = new UnifiedAutomation.UaBase.UaBaseNodeManager(this);
            nm.Startup();
            nm = new UnifiedAutomation.UaBase.UaBaseNodeManager(this);
            nm.Startup();
            nm = new UnifiedAutomation.Lads.LadsNodeManager(this);
            nm.Startup();
            nm = new Netzsch.Dma.DmaNodeManager(this);
            nm.Startup();

        }
    }
}
