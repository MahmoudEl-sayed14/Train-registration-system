using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train_Registration_System
{
    public partial class Trip : UserControl
    {
        public string email;
        public Trip()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            List<string> selectedButtons = new List<string>();

            for (int i = 1; i <= 32; i++)
            {
                Button? button = Controls["btn" + i] as Button;
                if (button?.BackColor == Color.Green)
                {
                    selectedButtons.Add(i.ToString());
                    button.Enabled = false;
                    button.BackColor = Color.White;
                }
            }

            if (selectedButtons.Count > 0)
            {
                string[] selectedButtonsArray = selectedButtons.ToArray();
                var data = new Data();
                data.UserBookedTickets(email, selectedButtonsArray);
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = (button.BackColor == Color.White) ? Color.Green : Color.White;
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 32; i++)
            {
                Button? button = Controls["btn" + i] as Button;
                button.BackColor = Color.White;
            }
        }
        private void RoundButtonBorder(Button button)
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
        private void Trip_Load(object sender, EventArgs e)
        {
            RoundButtonBorder(saveBtn);
            RoundButtonBorder(cancelBtn);
            DisableBookedButtons();
        }
        private void DisableBookedButtons()
        {
            var data = new Data();
            string[] bookedTickets = data.GetAllBookedTickets();

            foreach (string userBookedTickets in bookedTickets)
            {
                string[] numbers = userBookedTickets.Split(' ');
                
                foreach (string number in numbers)
                {
                    if (int.TryParse(number, out int buttonNumber))
                    {
                        Button? button = Controls["btn" + buttonNumber] as Button;
                        button.Enabled = false;
                    }                    
                }
            
            }
        }
    }
}
