﻿#pragma checksum "..\..\EditableField.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BB96ABBC58B4F7448C96C8CA4B1B2F50B6A5A810AFE9B2C16AA4DC436A765376"
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
using TestingElementsForScrumBoard;


namespace TestingElementsForScrumBoard {
    
    
    /// <summary>
    /// EditableField
    /// </summary>
    public partial class EditableField : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\EditableField.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TestingElementsForScrumBoard.EditableField userControl;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\EditableField.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel mainGrid;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\EditableField.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\EditableField.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\EditableField.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\EditableField.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel stackPanel;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\EditableField.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridEditButton;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\EditableField.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editButton;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\EditableField.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridDeleteButton;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\EditableField.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteButton;
        
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
            System.Uri resourceLocater = new System.Uri("/ScrumBoardNewDesign;component/editablefield.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EditableField.xaml"
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
            this.userControl = ((TestingElementsForScrumBoard.EditableField)(target));
            
            #line 7 "..\..\EditableField.xaml"
            this.userControl.MouseEnter += new System.Windows.Input.MouseEventHandler(this.userControlMouseEnter);
            
            #line default
            #line hidden
            
            #line 7 "..\..\EditableField.xaml"
            this.userControl.MouseLeave += new System.Windows.Input.MouseEventHandler(this.userControlMouseLeave);
            
            #line default
            #line hidden
            return;
            case 2:
            this.mainGrid = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 3:
            this.grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.textBlock = ((System.Windows.Controls.TextBlock)(target));
            
            #line 10 "..\..\EditableField.xaml"
            this.textBlock.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.textBlockMouseUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.textBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\EditableField.xaml"
            this.textBox.LostFocus += new System.Windows.RoutedEventHandler(this.textBoxLostFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.stackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 7:
            this.gridEditButton = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.editButton = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\EditableField.xaml"
            this.editButton.Click += new System.Windows.RoutedEventHandler(this.editButtonClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.gridDeleteButton = ((System.Windows.Controls.Grid)(target));
            return;
            case 10:
            this.deleteButton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\EditableField.xaml"
            this.deleteButton.Click += new System.Windows.RoutedEventHandler(this.deleteButtonClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
