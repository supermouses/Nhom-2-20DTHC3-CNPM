﻿#pragma checksum "..\..\..\UC\UCReceiptList.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "526F89A163A627CEA4C50493F73B86D2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace DormitoryManagement.UC {
    
    
    /// <summary>
    /// UCReceiptList
    /// </summary>
    public partial class UCReceiptList : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\UC\UCReceiptList.xaml"
        internal System.Windows.Controls.ListView lvReceiptList;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\UC\UCReceiptList.xaml"
        internal System.Windows.Controls.Button btAddReceipt;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\UC\UCReceiptList.xaml"
        internal System.Windows.Controls.Button btEditReceipt;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\UC\UCReceiptList.xaml"
        internal System.Windows.Controls.Button btDeleteReceipt;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DormitoryManagement;component/uc/ucreceiptlist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UC\UCReceiptList.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 4 "..\..\..\UC\UCReceiptList.xaml"
            ((DormitoryManagement.UC.UCReceiptList)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lvReceiptList = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.btAddReceipt = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\UC\UCReceiptList.xaml"
            this.btAddReceipt.Click += new System.Windows.RoutedEventHandler(this.btAddReceipt_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btEditReceipt = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\UC\UCReceiptList.xaml"
            this.btEditReceipt.Click += new System.Windows.RoutedEventHandler(this.btEditReceipt_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btDeleteReceipt = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\UC\UCReceiptList.xaml"
            this.btDeleteReceipt.Click += new System.Windows.RoutedEventHandler(this.btDeleteReceipt_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}