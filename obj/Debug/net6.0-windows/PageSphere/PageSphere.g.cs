﻿#pragma checksum "..\..\..\..\PageSphere\PageSphere.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A7EF6B80707D864DE7987B398BBF26597493C513"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Задание__1;


namespace Задание__1 {
    
    
    /// <summary>
    /// Sphere
    /// </summary>
    public partial class Sphere : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\PageSphere\PageSphere.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SphereBack;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\PageSphere\PageSphere.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GetResult;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\PageSphere\PageSphere.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RadiusBox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\PageSphere\PageSphere.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AccuracyBox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\PageSphere\PageSphere.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ResultSquareBox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\PageSphere\PageSphere.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ResultVolumeBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Задание №1;V1.0.0.0;component/pagesphere/pagesphere.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\PageSphere\PageSphere.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\..\PageSphere\PageSphere.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Drag);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SphereBack = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\..\PageSphere\PageSphere.xaml"
            this.SphereBack.Click += new System.Windows.RoutedEventHandler(this.BackButtonSphere);
            
            #line default
            #line hidden
            return;
            case 3:
            this.GetResult = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\..\PageSphere\PageSphere.xaml"
            this.GetResult.Click += new System.Windows.RoutedEventHandler(this.ResultButton);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 14 "..\..\..\..\PageSphere\PageSphere.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Exit);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 15 "..\..\..\..\PageSphere\PageSphere.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Deact);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 16 "..\..\..\..\PageSphere\PageSphere.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NewTheme);
            
            #line default
            #line hidden
            return;
            case 7:
            this.RadiusBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.AccuracyBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.ResultSquareBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.ResultVolumeBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

