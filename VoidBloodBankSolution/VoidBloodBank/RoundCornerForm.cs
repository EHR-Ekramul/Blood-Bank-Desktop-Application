using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace VoidBloodBank
{
    internal class RoundCornerForm
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
                int nLeftRect,
                int nToptRect,
                int nRightRect,
                int nBottomRect,
                int nWidthElipse,
                int nHeightElipse
        );
        public RoundCornerForm(Form form)
        {
            form.FormBorderStyle = FormBorderStyle.None;
            form.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, form.Width, form.Height, 30, 30));
        }
    }
}
