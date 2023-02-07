using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_Registration_System
{
    internal class Paths
    {
        protected static string UserNamePath { get; } = @"data\Users Data\userName.txt";
        protected static string EmailPath { get; } = @"data\Users Data\email.txt";
        protected static string PhonePath { get; } = @"data\Users Data\phone.txt";
        protected static string PasswordPath { get; } = @"data\Users Data\password.txt";
        protected static string TripPath { get; } = @"data\Trips Data\trip.txt";
        protected static string TicketPath { get; } = @"data\Trips Data\ticket.txt";
        protected static string AdminPasswordPath { get; } = @"data\admin Data\password.txt";
    }
}
