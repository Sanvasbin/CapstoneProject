﻿#pragma checksum "..\..\..\Pages\ProjectProperties.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AD4A2E215B934AC2B3782AAC5DA2A4910120A2792AD9ACF42BE23058BDD6977F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CapstoneProject.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace CapstoneProject.Pages {
    
    
    /// <summary>
    /// ProjectProperties
    /// </summary>
    public partial class ProjectProperties : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\Pages\ProjectProperties.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxName;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Pages\ProjectProperties.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxDescription;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Pages\ProjectProperties.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpStartDate;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Pages\ProjectProperties.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxWorkingHours;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\ProjectProperties.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSubmit;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\ProjectProperties.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ProjectDropDownMenu;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\ProjectProperties.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Project_Name_Label;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\ProjectProperties.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnConnect;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CapstoneProject;component/pages/projectproperties.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ProjectProperties.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.tbxName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tbxDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.dpStartDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.tbxWorkingHours = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\..\Pages\ProjectProperties.xaml"
            this.tbxWorkingHours.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.numberValidation);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnSubmit = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Pages\ProjectProperties.xaml"
            this.btnSubmit.Click += new System.Windows.RoutedEventHandler(this.btnSubmit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ProjectDropDownMenu = ((System.Windows.Controls.ComboBox)(target));
            
            #line 25 "..\..\..\Pages\ProjectProperties.xaml"
            this.ProjectDropDownMenu.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ProjectDropDownMenu_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Project_Name_Label = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.btnConnect = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Pages\ProjectProperties.xaml"
            this.btnConnect.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

