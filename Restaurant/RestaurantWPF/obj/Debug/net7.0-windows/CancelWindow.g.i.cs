﻿#pragma checksum "..\..\..\CancelWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D98152BCE6EDA83144357DF0FB5954FEED9575E6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using RestaurantWPF;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace RestaurantWPF {
    
    
    /// <summary>
    /// CancelWindow
    /// </summary>
    public partial class CancelWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 58 "..\..\..\CancelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameInput;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\CancelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ReservationIdInput;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/RestaurantWPF;component/cancelwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CancelWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.NameInput = ((System.Windows.Controls.TextBox)(target));
            
            #line 58 "..\..\..\CancelWindow.xaml"
            this.NameInput.GotFocus += new System.Windows.RoutedEventHandler(this.ExampleNameBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 58 "..\..\..\CancelWindow.xaml"
            this.NameInput.LostFocus += new System.Windows.RoutedEventHandler(this.ExampleNameBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ReservationIdInput = ((System.Windows.Controls.TextBox)(target));
            
            #line 68 "..\..\..\CancelWindow.xaml"
            this.ReservationIdInput.GotFocus += new System.Windows.RoutedEventHandler(this.ExampleTextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 68 "..\..\..\CancelWindow.xaml"
            this.ReservationIdInput.LostFocus += new System.Windows.RoutedEventHandler(this.ExampleTextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 80 "..\..\..\CancelWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 81 "..\..\..\CancelWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NewReserv_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 84 "..\..\..\CancelWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Back);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

