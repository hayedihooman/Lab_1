﻿#pragma checksum "..\..\Shipping.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E86990E49D9884C2E830488ADD2CFEAE4DB5134AAF461AF227F015DAF52F9CDD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Lab_1;
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


namespace Lab_1 {
    
    
    /// <summary>
    /// Shipping
    /// </summary>
    public partial class Shipping : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Shipping.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Weight_Lbl;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Shipping.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ShippingFee_Lbl;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Shipping.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ShippingFee_TxtBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Shipping.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TotalFee_TxtBox;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Shipping.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FeeCalc_Btn;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Shipping.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button return_Btn;
        
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
            System.Uri resourceLocater = new System.Uri("/Lab_1;component/shipping.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Shipping.xaml"
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
            this.Weight_Lbl = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.ShippingFee_Lbl = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.ShippingFee_TxtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TotalFee_TxtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.FeeCalc_Btn = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\Shipping.xaml"
            this.FeeCalc_Btn.Click += new System.Windows.RoutedEventHandler(this.FeeCalc_Btn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.return_Btn = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Shipping.xaml"
            this.return_Btn.Click += new System.Windows.RoutedEventHandler(this.return_Btn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

