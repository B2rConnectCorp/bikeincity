﻿#pragma checksum "E:\projects\BikeInCity\branches\version3\Mobile\WP7\BikeInCity\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "669BC7E326780DCB11234E62E4AB3A44"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Controls.Maps;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace BikeInCity {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal Microsoft.Phone.Controls.Maps.Map map;
        
        internal System.Windows.Controls.Button ButtonZoomIn;
        
        internal System.Windows.Controls.Button ButtonZoomOut;
        
        internal System.Windows.Controls.Border DirectionsPanel;
        
        internal System.Windows.Controls.TextBlock ToTextBox;
        
        internal System.Windows.Controls.TextBox AddressTextBox;
        
        internal System.Windows.Controls.Button bntSearch;
        
        internal System.Windows.Controls.Border AppInfoOverlay;
        
        internal System.Windows.Controls.TextBlock InformationTextbox;
        
        internal System.Windows.Controls.Border CityInfoOverlay;
        
        internal System.Windows.Controls.TextBlock CityInformationBox;
        
        internal System.Windows.Controls.Border CitiesPanel;
        
        internal System.Windows.Controls.ListBox CitiesList;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/BikeInCity;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.map = ((Microsoft.Phone.Controls.Maps.Map)(this.FindName("map")));
            this.ButtonZoomIn = ((System.Windows.Controls.Button)(this.FindName("ButtonZoomIn")));
            this.ButtonZoomOut = ((System.Windows.Controls.Button)(this.FindName("ButtonZoomOut")));
            this.DirectionsPanel = ((System.Windows.Controls.Border)(this.FindName("DirectionsPanel")));
            this.ToTextBox = ((System.Windows.Controls.TextBlock)(this.FindName("ToTextBox")));
            this.AddressTextBox = ((System.Windows.Controls.TextBox)(this.FindName("AddressTextBox")));
            this.bntSearch = ((System.Windows.Controls.Button)(this.FindName("bntSearch")));
            this.AppInfoOverlay = ((System.Windows.Controls.Border)(this.FindName("AppInfoOverlay")));
            this.InformationTextbox = ((System.Windows.Controls.TextBlock)(this.FindName("InformationTextbox")));
            this.CityInfoOverlay = ((System.Windows.Controls.Border)(this.FindName("CityInfoOverlay")));
            this.CityInformationBox = ((System.Windows.Controls.TextBlock)(this.FindName("CityInformationBox")));
            this.CitiesPanel = ((System.Windows.Controls.Border)(this.FindName("CitiesPanel")));
            this.CitiesList = ((System.Windows.Controls.ListBox)(this.FindName("CitiesList")));
        }
    }
}

