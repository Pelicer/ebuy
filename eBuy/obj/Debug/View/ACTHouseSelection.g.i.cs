﻿#pragma checksum "..\..\..\View\ACTHouseSelection.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DCBB3220DC9C9D41256ED066F03AE62E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using eBuy.View;


namespace eBuy.View {
    
    
    /// <summary>
    /// ACTHouseSelection
    /// </summary>
    public partial class ACTHouseSelection : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\View\ACTHouseSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal eBuy.View.ACTHouseSelection HouseSelection;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\View\ACTHouseSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblHouseSelection;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\View\ACTHouseSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblMessage;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\View\ACTHouseSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgS;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\View\ACTHouseSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgG;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\View\ACTHouseSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgR;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\View\ACTHouseSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgH;
        
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
            System.Uri resourceLocater = new System.Uri("/eBuy;component/view/acthouseselection.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\ACTHouseSelection.xaml"
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
            this.HouseSelection = ((eBuy.View.ACTHouseSelection)(target));
            return;
            case 2:
            this.lblHouseSelection = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lblMessage = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.imgS = ((System.Windows.Controls.Image)(target));
            
            #line 22 "..\..\..\View\ACTHouseSelection.xaml"
            this.imgS.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.imgS_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.imgG = ((System.Windows.Controls.Image)(target));
            
            #line 23 "..\..\..\View\ACTHouseSelection.xaml"
            this.imgG.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.imgG_MouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.imgR = ((System.Windows.Controls.Image)(target));
            
            #line 24 "..\..\..\View\ACTHouseSelection.xaml"
            this.imgR.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.imgR_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.imgH = ((System.Windows.Controls.Image)(target));
            
            #line 25 "..\..\..\View\ACTHouseSelection.xaml"
            this.imgH.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.imgH_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
