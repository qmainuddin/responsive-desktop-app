﻿#pragma checksum "..\..\..\..\..\Pages\UserAdmin\TestItem.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "859AC72EB2FD51062D1A62125BFA6AD6682E7128"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HSDL_IDM_P2.Pages.UserAdmin;
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


namespace HSDL_IDM_P2.Pages.UserAdmin {
    
    
    /// <summary>
    /// TestItem
    /// </summary>
    public partial class TestItem : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 121 "..\..\..\..\..\Pages\UserAdmin\TestItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid table_dataGrid;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\..\..\Pages\UserAdmin\TestItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckBox_header;
        
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
            System.Uri resourceLocater = new System.Uri("/HSDL_IDM_P2;component/pages/useradmin/testitem.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Pages\UserAdmin\TestItem.xaml"
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
            
            #line 8 "..\..\..\..\..\Pages\UserAdmin\TestItem.xaml"
            ((HSDL_IDM_P2.Pages.UserAdmin.TestItem)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 5:
            this.table_dataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 125 "..\..\..\..\..\Pages\UserAdmin\TestItem.xaml"
            this.table_dataGrid.Sorting += new System.Windows.Controls.DataGridSortingEventHandler(this.DataGrid_Sorting);
            
            #line default
            #line hidden
            
            #line 125 "..\..\..\..\..\Pages\UserAdmin\TestItem.xaml"
            this.table_dataGrid.LayoutUpdated += new System.EventHandler(this.dataGrid_LayoutUpdated);
            
            #line default
            #line hidden
            
            #line 128 "..\..\..\..\..\Pages\UserAdmin\TestItem.xaml"
            this.table_dataGrid.CopyingRowClipboardContent += new System.EventHandler<System.Windows.Controls.DataGridRowClipboardEventArgs>(this.DataGrid_CopyingRowClipboardContent);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CheckBox_header = ((System.Windows.Controls.CheckBox)(target));
            
            #line 132 "..\..\..\..\..\Pages\UserAdmin\TestItem.xaml"
            this.CheckBox_header.Click += new System.Windows.RoutedEventHandler(this.Header_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 2:
            
            #line 59 "..\..\..\..\..\Pages\UserAdmin\TestItem.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DGTemplateEdit_Click);
            
            #line default
            #line hidden
            
            #line 60 "..\..\..\..\..\Pages\UserAdmin\TestItem.xaml"
            ((System.Windows.Controls.Button)(target)).Loaded += new System.Windows.RoutedEventHandler(this.BtnEdit_Loaded);
            
            #line default
            #line hidden
            break;
            case 3:
            
            #line 80 "..\..\..\..\..\Pages\UserAdmin\TestItem.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DGTemplateView_Click);
            
            #line default
            #line hidden
            
            #line 80 "..\..\..\..\..\Pages\UserAdmin\TestItem.xaml"
            ((System.Windows.Controls.Button)(target)).Loaded += new System.Windows.RoutedEventHandler(this.BtnView_Loaded);
            
            #line default
            #line hidden
            break;
            case 4:
            
            #line 88 "..\..\..\..\..\Pages\UserAdmin\TestItem.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DGTemplateDelete_Click);
            
            #line default
            #line hidden
            
            #line 88 "..\..\..\..\..\Pages\UserAdmin\TestItem.xaml"
            ((System.Windows.Controls.Button)(target)).Loaded += new System.Windows.RoutedEventHandler(this.BtnDelete_Loaded);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

