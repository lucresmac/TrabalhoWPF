﻿#pragma checksum "..\..\..\..\Views\frmMedico.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C11A8E4227EEE5950BE107541CDCB0822BAA9895"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using Hospital.Views;
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


namespace Hospital.Views {
    
    
    /// <summary>
    /// frmMedico
    /// </summary>
    public partial class frmMedico : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\Views\frmMedico.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grid;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Views\frmMedico.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grid_prescricao;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Views\frmMedico.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPrescricao;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Views\frmMedico.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCadastrar;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Views\frmMedico.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAlterar;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Views\frmMedico.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRemover;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Hospital;component/views/frmmedico.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\frmMedico.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.grid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 12 "..\..\..\..\Views\frmMedico.xaml"
            this.grid.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.grid_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.grid_prescricao = ((System.Windows.Controls.DataGrid)(target));
            
            #line 19 "..\..\..\..\Views\frmMedico.xaml"
            this.grid_prescricao.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.grid_prescricao_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtPrescricao = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btnCadastrar = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\Views\frmMedico.xaml"
            this.btnCadastrar.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnAlterar = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\Views\frmMedico.xaml"
            this.btnAlterar.Click += new System.Windows.RoutedEventHandler(this.btnAlterar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnRemover = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\Views\frmMedico.xaml"
            this.btnRemover.Click += new System.Windows.RoutedEventHandler(this.btnRemover_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
