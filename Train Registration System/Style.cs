using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_Registration_System
{
    internal class Style
    {
        public void RoundButtonBorder(Button button)
        {
            button.Font = new Font("Arial", 14, FontStyle.Bold);
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, 10, 10, 180, 90);
            path.AddArc(button.Width - 11, 0, 10, 10, 270, 90);
            path.AddArc(button.Width - 11, button.Height - 11, 10, 10, 0, 90);
            path.AddArc(0, button.Height - 11, 10, 10, 90, 90);
            path.CloseFigure();
            button.Region = new Region(path);
        }
        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
