﻿#pragma checksum "..\..\..\Views\ShowAllUsers.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7E399CEA9EB7ACC09304C5D1C5C26EE310DB8A0BA06C60734210F7A5FDFA6C86"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ContactManagerProject.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace ContactManagerProject.Views {
    
    
    /// <summary>
    /// ShowAllUsers
    /// </summary>
    public partial class ShowAllUsers : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\Views\ShowAllUsers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataDisplay;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Views\ShowAllUsers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowAll;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Views\ShowAllUsers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteAll;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Views\ShowAllUsers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button View;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Views\ShowAllUsers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox viewBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Views\ShowAllUsers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock displayView;
        
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
            System.Uri resourceLocater = new System.Uri("/ContactManagerProject;component/views/showallusers.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\ShowAllUsers.xaml"
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
            this.dataDisplay = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.ShowAll = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Views\ShowAllUsers.xaml"
            this.ShowAll.Click += new System.Windows.RoutedEventHandler(this.ShowAll_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DeleteAll = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Views\ShowAllUsers.xaml"
            this.DeleteAll.Click += new System.Windows.RoutedEventHandler(this.DeleteAll_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.View = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Views\ShowAllUsers.xaml"
            this.View.Click += new System.Windows.RoutedEventHandler(this.View_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.viewBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.displayView = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

