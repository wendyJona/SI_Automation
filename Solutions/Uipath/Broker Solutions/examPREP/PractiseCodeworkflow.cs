using examPREP.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace examPREP
{
    public class PractiseCodeworkflow : CodedWorkflow
    {
        [Workflow]
        public void Execute()
        {
           var UiBank = uiAutomation.Open("UiBank-Login");
            UiBank.Click("Register For Account");
            
            
           var NewAccount = uiAutomation.Attach("UiBank-Login");
            NewAccount.TypeInto("First Name", "wENDY");
            NewAccount.TypeInto("Last Name", "JONA");
        }
    }
}