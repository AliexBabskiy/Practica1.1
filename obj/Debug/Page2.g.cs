﻿#pragma checksum "..\..\Page2.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F515E097EBE8C4AC6E7EFD3882149B43B5A146CBDB334FFD21C8E137CC1ED04B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PrPract1._1;
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


namespace PrPract1._1 {
    
    
    /// <summary>
    /// Page2
    /// </summary>
    public partial class Page2 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\Page2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid tablic;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Page2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame FrameP;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Page2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text1;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Page2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text2;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Page2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text3;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Page2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtDob;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Page2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtIzm;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Page2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtDel;
        
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
            System.Uri resourceLocater = new System.Uri("/PrPract1.1;component/page2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Page2.xaml"
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
            this.tablic = ((System.Windows.Controls.DataGrid)(target));
            
            #line 23 "..\..\Page2.xaml"
            this.tablic.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.tablic_Dob);
            
            #line default
            #line hidden
            return;
            case 2:
            this.FrameP = ((System.Windows.Controls.Frame)(target));
            return;
            case 3:
            this.text1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.text2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.text3 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.BtDob = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\Page2.xaml"
            this.BtDob.Click += new System.Windows.RoutedEventHandler(this.BtDob_Cl);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtIzm = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\Page2.xaml"
            this.BtIzm.Click += new System.Windows.RoutedEventHandler(this.BtIzm_Cl);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtDel = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\Page2.xaml"
            this.BtDel.Click += new System.Windows.RoutedEventHandler(this.BtDel_Cl);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

