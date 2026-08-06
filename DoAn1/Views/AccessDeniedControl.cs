using System;
using System.Drawing;
using System.Windows.Forms;

namespace DoAn1.Views
{
    public partial class AccessDeniedControl : UserControl
    {
        public AccessDeniedControl()
        {
            InitializeComponent();
        }

        private void AccessDeniedControl_Resize(object sender, EventArgs e)
        {
            if (panelContainer != null)
            {
                panelContainer.Left = (this.ClientSize.Width - panelContainer.Width) / 2;
                panelContainer.Top = (this.ClientSize.Height - panelContainer.Height) / 2;
            }
        }
    }
}
