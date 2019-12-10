using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Interfaces.Carteles
{
    public partial class CartelActividadesStandard : Component
    {
        public CartelActividadesStandard()
        {
            InitializeComponent();
        }

        public CartelActividadesStandard(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
