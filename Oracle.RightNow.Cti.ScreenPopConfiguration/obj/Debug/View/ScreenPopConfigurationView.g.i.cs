﻿#pragma checksum "..\..\..\View\ScreenPopConfigurationView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F31D6AB882C99F447A78D1FA9692B33E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Oracle.RightNow.Cti.ScreenPopConfiguration.Converters;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace Oracle.RightNow.Cti.ScreenPopConfiguration.View {
    
    
    /// <summary>
    /// ScreenPopConfigurationView
    /// </summary>
    public partial class ScreenPopConfigurationView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 45 "..\..\..\View\ScreenPopConfigurationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ColumnDefinition columnwidth;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\View\ScreenPopConfigurationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid config;
        
        #line default
        #line hidden
        
        
        #line 181 "..\..\..\View\ScreenPopConfigurationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox VoiceCheckbox;
        
        #line default
        #line hidden
        
        
        #line 235 "..\..\..\View\ScreenPopConfigurationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ChatCheckBox;
        
        #line default
        #line hidden
        
        
        #line 295 "..\..\..\View\ScreenPopConfigurationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox incidentCheckBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Oracle.RightNow.Cti.ScreenPopConfiguration;component/view/screenpopconfiguration" +
                    "view.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\ScreenPopConfigurationView.xaml"
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
            this.columnwidth = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 2:
            this.config = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.VoiceCheckbox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 4:
            this.ChatCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            this.incidentCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

