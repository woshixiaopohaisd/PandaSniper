﻿#pragma checksum "..\..\PayloadGeneragor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E4C332BE49E0B20808E882FA177AF203F66E51ED7A57B3403E46F2B6FBCD6E81"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using PandaSniper;
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


namespace PandaSniper {
    
    
    /// <summary>
    /// PayloadGeneragor
    /// </summary>
    public partial class PayloadGeneragor : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 422 "..\..\PayloadGeneragor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PayloadGeneragorAdd;
        
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
            System.Uri resourceLocater = new System.Uri("/PandaSniper;component/payloadgeneragor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PayloadGeneragor.xaml"
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
            this.PayloadGeneragorAdd = ((System.Windows.Controls.Button)(target));
            
            #line 433 "..\..\PayloadGeneragor.xaml"
            this.PayloadGeneragorAdd.MouseEnter += new System.Windows.Input.MouseEventHandler(this.PayloadGeneragorAdd_MouseEnter);
            
            #line default
            #line hidden
            
            #line 434 "..\..\PayloadGeneragor.xaml"
            this.PayloadGeneragorAdd.MouseLeave += new System.Windows.Input.MouseEventHandler(this.PayloadGeneragorAdd_MouseLeave);
            
            #line default
            #line hidden
            
            #line 435 "..\..\PayloadGeneragor.xaml"
            this.PayloadGeneragorAdd.Click += new System.Windows.RoutedEventHandler(this.PayloadGeneragorAdd_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
