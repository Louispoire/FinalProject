﻿#pragma checksum "..\..\..\Views\ImportUsers.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A7302068C2B4B4FCC642ECCEAB71BE24BF2C9592307B8433B4439638A11DC7C0"
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
    /// ImportUsers
    /// </summary>
    public partial class ImportUsers : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Views\ImportUsers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ImportAll;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Views\ImportUsers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock exportInfo;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Views\ImportUsers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ImportInfo2;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Views\ImportUsers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ImportInfo3;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Views\ImportUsers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ImportInfo4;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Views\ImportUsers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock path;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Views\ImportUsers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox filePath;
        
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
            System.Uri resourceLocater = new System.Uri("/ContactManagerProject;component/views/importusers.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\ImportUsers.xaml"
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
            this.ImportAll = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\Views\ImportUsers.xaml"
            this.ImportAll.Click += new System.Windows.RoutedEventHandler(this.ImportAll_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.exportInfo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.ImportInfo2 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.ImportInfo3 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.ImportInfo4 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.path = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.filePath = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

