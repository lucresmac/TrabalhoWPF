﻿#pragma checksum "..\..\..\..\Views\frmPrincipal.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CAB71D423D83E83C6B76E98E4BE4C1EA65611F4B"
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
    /// frmPrincipal
    /// </summary>
    public partial class frmPrincipal : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\Views\frmPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuSair;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Views\frmPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem CadastrarPaciente;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Views\frmPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem BuscarPaciente;
        
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
            System.Uri resourceLocater = new System.Uri("/Hospital;component/views/frmprincipal.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\frmPrincipal.xaml"
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
            this.menuSair = ((System.Windows.Controls.MenuItem)(target));
            
            #line 12 "..\..\..\..\Views\frmPrincipal.xaml"
            this.menuSair.Click += new System.Windows.RoutedEventHandler(this.menuSair_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CadastrarPaciente = ((System.Windows.Controls.MenuItem)(target));
            
            #line 15 "..\..\..\..\Views\frmPrincipal.xaml"
            this.CadastrarPaciente.Click += new System.Windows.RoutedEventHandler(this.CadastrarPaciente_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BuscarPaciente = ((System.Windows.Controls.MenuItem)(target));
            
            #line 16 "..\..\..\..\Views\frmPrincipal.xaml"
            this.BuscarPaciente.Click += new System.Windows.RoutedEventHandler(this.BuscarPaciente_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

