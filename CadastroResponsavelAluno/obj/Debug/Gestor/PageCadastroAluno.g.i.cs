﻿#pragma checksum "..\..\..\Gestor\PageCadastroAluno.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CFB77A38160478604B07B5068A419F9740D909D968713ECDB824610F083133C9"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using CadastroResponsavelAluno;
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


namespace CadastroResponsavelAluno {
    
    
    /// <summary>
    /// PageCadastroAluno
    /// </summary>
    public partial class PageCadastroAluno : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\Gestor\PageCadastroAluno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CampoAluno;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Gestor\PageCadastroAluno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxTurma;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Gestor\PageCadastroAluno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CampoResponsavel;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Gestor\PageCadastroAluno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BotaoLimparAluno;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Gestor\PageCadastroAluno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BotaoCadastrarAluno;
        
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
            System.Uri resourceLocater = new System.Uri("/CadastroResponsavelAluno;component/gestor/pagecadastroaluno.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Gestor\PageCadastroAluno.xaml"
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
            this.CampoAluno = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.ComboBoxTurma = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.CampoResponsavel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.BotaoLimparAluno = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Gestor\PageCadastroAluno.xaml"
            this.BotaoLimparAluno.Click += new System.Windows.RoutedEventHandler(this.BotaoLimparAluno_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BotaoCadastrarAluno = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Gestor\PageCadastroAluno.xaml"
            this.BotaoCadastrarAluno.Click += new System.Windows.RoutedEventHandler(this.BotaoCadastrarAluno_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

