﻿#pragma checksum "..\..\..\Pages\IngredientsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9EE13A29B7FFDC999EC8957E6D220F45B6A74E4E91BD929741109EC5D70048F3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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
using ZetaClient.pages;


namespace ZetaClient.pages {
    
    
    /// <summary>
    /// IngredientsPage
    /// </summary>
    public partial class IngredientsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 32 "..\..\..\Pages\IngredientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTextBox;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Pages\IngredientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameInput;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Pages\IngredientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DescriptionInput;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Pages\IngredientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddButton;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Pages\IngredientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid IngDataGrid;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Pages\IngredientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup ModifyPopup;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\Pages\IngredientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CloseModifyPopupButton;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\Pages\IngredientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ModifyNameInput;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\Pages\IngredientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ModifyDescriptionInput;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\Pages\IngredientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ModifyValidationButton;
        
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
            System.Uri resourceLocater = new System.Uri("/ZetaClient;component/pages/ingredientspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\IngredientsPage.xaml"
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
            
            #line 10 "..\..\..\Pages\IngredientsPage.xaml"
            ((ZetaClient.pages.IngredientsPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.IngredientsPage_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SearchTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\..\Pages\IngredientsPage.xaml"
            this.SearchTextBox.KeyUp += new System.Windows.Input.KeyEventHandler(this.SearchTextBox_KeyUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.NameInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.DescriptionInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.AddButton = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\Pages\IngredientsPage.xaml"
            this.AddButton.Click += new System.Windows.RoutedEventHandler(this.AddButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.IngDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            this.ModifyPopup = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 10:
            this.CloseModifyPopupButton = ((System.Windows.Controls.Label)(target));
            
            #line 85 "..\..\..\Pages\IngredientsPage.xaml"
            this.CloseModifyPopupButton.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.CloseModifyPopupButton_MouseDown);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ModifyNameInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.ModifyDescriptionInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.ModifyValidationButton = ((System.Windows.Controls.Button)(target));
            
            #line 103 "..\..\..\Pages\IngredientsPage.xaml"
            this.ModifyValidationButton.Click += new System.Windows.RoutedEventHandler(this.ModifyValidationButton_Click);
            
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
            case 7:
            
            #line 61 "..\..\..\Pages\IngredientsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Modify_Click);
            
            #line default
            #line hidden
            break;
            case 8:
            
            #line 68 "..\..\..\Pages\IngredientsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Remove_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

