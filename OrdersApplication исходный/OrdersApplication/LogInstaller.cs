using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Diagnostics;

namespace OrdersApplication
{
    [RunInstaller(true)]
    public partial class LogInstaller : Installer
    {
        public LogInstaller()
        {
            InitializeComponent();
        }
        public override void Install(System.Collections.IDictionary stateSaver)
        {
            base.Install(stateSaver);
            System.Diagnostics.EventLog.CreateEventSource("OrdersSource", "Orders Log");
        }
        public override void Uninstall(System.Collections.IDictionary savedState)
        {
            base.Uninstall(savedState);
            System.Diagnostics.EventLog.DeleteEventSource("OrdersSource");
        }
    }
}