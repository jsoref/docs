﻿#pragma checksum "..\..\Pane1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "56DCB4185ADD1C5F205B685B11FFE51332462BB60B037D2DEFDD48EFD0AACD57"
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


namespace TabControl {
    
    
    /// <summary>
    /// Pane1
    /// </summary>
    public partial class Pane1 : System.Windows.Controls.StackPanel, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\Pane1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem backgroundcolor;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Pane1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem foregroundcolor;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Pane1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem bordercolor;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\Pane1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabItem1;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\Pane1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabItem2;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\Pane1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPlacement;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\Pane1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas cv2;
        
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
            System.Uri resourceLocater = new System.Uri("/TabControlSimple;component/pane1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Pane1.xaml"
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
            this.backgroundcolor = ((System.Windows.Controls.TabItem)(target));
            return;
            case 2:
            this.foregroundcolor = ((System.Windows.Controls.TabItem)(target));
            return;
            case 3:
            this.bordercolor = ((System.Windows.Controls.TabItem)(target));
            return;
            case 4:
            
            #line 56 "..\..\Pane1.xaml"
            ((System.Windows.Controls.TabControl)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tabItem1 = ((System.Windows.Controls.TabItem)(target));
            return;
            case 6:
            this.tabItem2 = ((System.Windows.Controls.TabItem)(target));
            return;
            case 7:
            this.btnPlacement = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            
            #line 72 "..\..\Pane1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.cv2 = ((System.Windows.Controls.Canvas)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
