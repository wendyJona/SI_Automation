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
using UiPath.CodedWorkflows.DescriptorIntegration;

namespace examPREP
{
    public partial class CodedWorkflow : CodedWorkflowBase
    {
        public CodedWorkflow()
        {
            _ = new System.Type[]{typeof(UiPath.Core.Activities.API.ISystemService), typeof(UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService), typeof(UiPath.Testing.API.ITestingService)};
        }

        protected UiPath.Core.Activities.API.ISystemService system { get => serviceContainer.Resolve<UiPath.Core.Activities.API.ISystemService>(); }

        protected UiPath.Testing.API.ITestingService testing { get => serviceContainer.Resolve<UiPath.Testing.API.ITestingService>(); }

        protected UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService uiAutomation { get => serviceContainer.Resolve<UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService>(); }
    }
}

namespace examPREP.ObjectRepository
{
    public static class Descriptors
    {
        public static class Chrome__UiBank_Login_app
        {
            public static _Implementation._Chrome__UiBank_Login_app.__Chrome__UiBank_Login Chrome__UiBank_Login { get; private set; } = new _Implementation._Chrome__UiBank_Login_app.__Chrome__UiBank_Login();
        }

        public static class Chrome__UiBank_Login_app__1_
        {
            public static _Implementation._Chrome__UiBank_Login_app__1_.__Chrome__UiBank_Login Chrome__UiBank_Login { get; private set; } = new _Implementation._Chrome__UiBank_Login_app__1_.__Chrome__UiBank_Login();
        }

        public static class New_Account
        {
        }
    }
}

namespace examPREP._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }

        public IElementDescriptor ParentElement { get; set; }

        public IElementDescriptor Element { get; set; }
    }

    namespace _Chrome__UiBank_Login_app._Chrome__UiBank_Login
    {
        public class __First_Name : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __First_Name(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XrXOaf63ykW2f_3PQO5_vA/SpaT_SThW0OJvPvkkPfCJw", DisplayName = "First Name", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome__UiBank_Login_app._Chrome__UiBank_Login
    {
        public class __Last_Name : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Last_Name(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XrXOaf63ykW2f_3PQO5_vA/T_jecgBedUKjqGI9m5ftLQ", DisplayName = "Last Name", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome__UiBank_Login_app._Chrome__UiBank_Login
    {
        public class __Middle_Name_Or_Initial : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Middle_Name_Or_Initial(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XrXOaf63ykW2f_3PQO5_vA/l_uJ6OIANEixffAOFj6T1g", DisplayName = "Middle Name Or Initial", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome__UiBank_Login_app._Chrome__UiBank_Login
    {
        public class __Sex_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Sex_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XrXOaf63ykW2f_3PQO5_vA/HS3bTY4emUyfy9kz_FgZkg", DisplayName = "Sex*", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome__UiBank_Login_app
    {
        public class __Chrome__UiBank_Login : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Chrome__UiBank_Login()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "XrXOaf63ykW2f_3PQO5_vA/zbDdj6dBwki_M02Mg0-4bw", DisplayName = "Chrome: UiBank-Login", Screen = this};
                First_Name = new _Implementation._Chrome__UiBank_Login_app._Chrome__UiBank_Login.__First_Name(this, null);
                Last_Name = new _Implementation._Chrome__UiBank_Login_app._Chrome__UiBank_Login.__Last_Name(this, null);
                Middle_Name_Or_Initial = new _Implementation._Chrome__UiBank_Login_app._Chrome__UiBank_Login.__Middle_Name_Or_Initial(this, null);
                Sex_ = new _Implementation._Chrome__UiBank_Login_app._Chrome__UiBank_Login.__Sex_(this, null);
            }

            public _Implementation._Chrome__UiBank_Login_app._Chrome__UiBank_Login.__First_Name First_Name { get; private set; }

            public _Implementation._Chrome__UiBank_Login_app._Chrome__UiBank_Login.__Last_Name Last_Name { get; private set; }

            public _Implementation._Chrome__UiBank_Login_app._Chrome__UiBank_Login.__Middle_Name_Or_Initial Middle_Name_Or_Initial { get; private set; }

            public _Implementation._Chrome__UiBank_Login_app._Chrome__UiBank_Login.__Sex_ Sex_ { get; private set; }
        }
    }

    namespace _Chrome__UiBank_Login_app__1_._Chrome__UiBank_Login
    {
        public class __Register_For_Account : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Register_For_Account(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XrXOaf63ykW2f_3PQO5_vA/PF3dqdoxgUuvQAy2Nwq4hA", DisplayName = "Register For Account", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome__UiBank_Login_app__1_
    {
        public class __Chrome__UiBank_Login : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Chrome__UiBank_Login()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "XrXOaf63ykW2f_3PQO5_vA/d18JsXhgME6qJgF0Tbb5rQ", DisplayName = "Chrome: UiBank-Login", Screen = this};
                Register_For_Account = new _Implementation._Chrome__UiBank_Login_app__1_._Chrome__UiBank_Login.__Register_For_Account(this, null);
            }

            public _Implementation._Chrome__UiBank_Login_app__1_._Chrome__UiBank_Login.__Register_For_Account Register_For_Account { get; private set; }
        }
    }
}