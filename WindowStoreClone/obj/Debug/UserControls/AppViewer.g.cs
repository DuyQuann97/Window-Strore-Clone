﻿#pragma checksum "..\..\..\UserControls\AppViewer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6FD95553C7005CA5CD843293F238747C647CAF5A4EE37F00C40EE332931CE749"
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
using WindowStoreClone.UserControls;


namespace WindowStoreClone.UserControls {
    
    
    /// <summary>
    /// AppViewer
    /// </summary>
    public partial class AppViewer : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\UserControls\AppViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ScrollLeftButton;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\UserControls\AppViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ScrollRightButton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\UserControls\AppViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer AppScrollView;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\UserControls\AppViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl AppList;
        
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
            System.Uri resourceLocater = new System.Uri("/WindowStoreClone;component/usercontrols/appviewer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControls\AppViewer.xaml"
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
            this.ScrollLeftButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\UserControls\AppViewer.xaml"
            this.ScrollLeftButton.Click += new System.Windows.RoutedEventHandler(this.ScrollLeftButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ScrollRightButton = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\UserControls\AppViewer.xaml"
            this.ScrollRightButton.Click += new System.Windows.RoutedEventHandler(this.ScrollRightButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AppScrollView = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 4:
            this.AppList = ((System.Windows.Controls.ItemsControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

