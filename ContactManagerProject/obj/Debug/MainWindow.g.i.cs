// Updated by XamlIntelliSenseFileGenerator 2020-12-13 4:27:16 PM
#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EF1EB8363A8E407EEA2EEAF965E49801ABFD6602D5256E1AF175CC001A9366BA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ContactManagerProject;
using ContactManagerProject.ViewModels;
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


namespace ContactManagerProject
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 49 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblWelcome;

#line default
#line hidden


#line 50 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblWelcome1;

#line default
#line hidden


#line 51 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Book;

#line default
#line hidden


#line 55 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock menu;

#line default
#line hidden


#line 62 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock info;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ContactManagerProject;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\MainWindow.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.FrmWindow = ((ContactManagerProject.MainWindow)(target));
                    return;
                case 2:
                    this.lblWelcome = ((System.Windows.Controls.Label)(target));
                    return;
                case 3:
                    this.lblWelcome1 = ((System.Windows.Controls.Label)(target));
                    return;
                case 4:
                    this.Book = ((System.Windows.Controls.Image)(target));
                    return;
                case 5:
                    this.menu = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 6:

#line 56 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddUser_Click);

#line default
#line hidden
                    return;
                case 7:

#line 57 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowAll_Click);

#line default
#line hidden
                    return;
                case 8:

#line 58 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Update_Click);

#line default
#line hidden
                    return;
                case 9:

#line 59 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete_Click);

#line default
#line hidden
                    return;
                case 10:

#line 60 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Import_Click);

#line default
#line hidden
                    return;
                case 11:

#line 61 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Export_Click);

#line default
#line hidden
                    return;
                case 12:
                    this.info = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 13:

#line 63 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Quit_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Window FrmWindow;
    }
}

