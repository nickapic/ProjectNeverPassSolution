﻿#pragma checksum "..\..\Register Window.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20D2D406E954C3333A6E2CD4CC313E24DBCB61D6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjectNeverPass;
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


namespace ProjectNeverPass {
    
    
    /// <summary>
    /// Register_Window
    /// </summary>
    public partial class Register_Window : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\Register Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Username_reg;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Register Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox First_name_reg;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Register Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Last_name_reg;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Register Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox email_reg;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Register Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Register;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Register Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Passwordtoregister;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjectNeverPass;component/register%20window.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Register Window.xaml"
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
            this.Username_reg = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.First_name_reg = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Last_name_reg = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.email_reg = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Register = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\Register Window.xaml"
            this.Register.Click += new System.Windows.RoutedEventHandler(this.Register_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Passwordtoregister = ((System.Windows.Controls.PasswordBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

