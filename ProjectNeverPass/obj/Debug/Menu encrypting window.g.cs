﻿#pragma checksum "..\..\Menu encrypting window.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "430252708A94462880B349984120B66A42E69194"
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
    /// Menu_encrypting_window
    /// </summary>
    public partial class Menu_encrypting_window : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\Menu encrypting window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add_Information;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Menu encrypting window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Username_to_be_stored;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Menu encrypting window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Password_Tobestored;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Menu encrypting window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Website;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Menu encrypting window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Decrypt_button;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Menu encrypting window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FilePath;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Menu encrypting window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SelectPath_Button;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Menu encrypting window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Close_Button;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjectNeverPass;component/menu%20encrypting%20window.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Menu encrypting window.xaml"
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
            this.Add_Information = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Menu encrypting window.xaml"
            this.Add_Information.Click += new System.Windows.RoutedEventHandler(this.Add_Information_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Username_to_be_stored = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Password_Tobestored = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Website = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Decrypt_button = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\Menu encrypting window.xaml"
            this.Decrypt_button.Click += new System.Windows.RoutedEventHandler(this.Decrypt_button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.FilePath = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.SelectPath_Button = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\Menu encrypting window.xaml"
            this.SelectPath_Button.Click += new System.Windows.RoutedEventHandler(this.SelectPath_Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Close_Button = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\Menu encrypting window.xaml"
            this.Close_Button.Click += new System.Windows.RoutedEventHandler(this.Close_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
