﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "62BD5DEEB1148A9F681B9E680BE11084"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using CatConverter;
using DataConvert;
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


namespace CatConverter {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal CatConverter.MainWindow window;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Hex;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_ASCII;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Dec;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Bin;
        
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
            System.Uri resourceLocater = new System.Uri("/CatConverter;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.window = ((CatConverter.MainWindow)(target));
            return;
            case 2:
            
            #line 12 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Format);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 13 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_UnFormat);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TB_Hex = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\MainWindow.xaml"
            this.TB_Hex.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TB_Hex_TextChanged);
            
            #line default
            #line hidden
            
            #line 23 "..\..\MainWindow.xaml"
            this.TB_Hex.SelectionChanged += new System.Windows.RoutedEventHandler(this.TB_Hex_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 23 "..\..\MainWindow.xaml"
            this.TB_Hex.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TB_Hex_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TB_ASCII = ((System.Windows.Controls.TextBox)(target));
            
            #line 47 "..\..\MainWindow.xaml"
            this.TB_ASCII.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TB_ASCII_TextChanged);
            
            #line default
            #line hidden
            
            #line 47 "..\..\MainWindow.xaml"
            this.TB_ASCII.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TB_ASCII_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TB_Dec = ((System.Windows.Controls.TextBox)(target));
            
            #line 74 "..\..\MainWindow.xaml"
            this.TB_Dec.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TB_Dec_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 74 "..\..\MainWindow.xaml"
            this.TB_Dec.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TB_Dec_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TB_Bin = ((System.Windows.Controls.TextBox)(target));
            
            #line 101 "..\..\MainWindow.xaml"
            this.TB_Bin.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TB_Bin_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 101 "..\..\MainWindow.xaml"
            this.TB_Bin.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TB_Bin_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

