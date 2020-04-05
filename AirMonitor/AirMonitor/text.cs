using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace AirMonitor
{
    public partial class text : Component
    {
        public text()
        {
            InitializeComponent();
        }

        public text(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
