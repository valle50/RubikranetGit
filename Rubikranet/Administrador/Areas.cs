﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rubikranet.Administrador
{
    public partial class Areas : UserControl
    {
        public Areas()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        public static Areas Instancia = new Areas();
    }
}
