using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_Registration_System
{
    internal class Paths
    {
        protected string UserNamePath { get; } = @"data\Users Data\userName.txt";
        protected string EmailPath { get; } = @"data\Users Data\email.txt";
        protected string PhonePath { get; } = @"data\Users Data\phone.txt";
        protected string PasswordPath { get; } = @"data\Users Data\password.txt";
        protected string TripPath { get; } = @"data\Trips Data\trip.txt";
        protected string TicketPath { get; } = @"data\Trips Data\ticket.txt";
        protected string AdminPasswordPath { get; } = @"data\admin Data\password.txt";
        protected string UserDataPath { get; } = @"data\Users Data";
    }
}
