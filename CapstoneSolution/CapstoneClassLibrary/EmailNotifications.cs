using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneClassLibrary
{
    class EmailNotifications
    {

        public static void changePasswordNotification()
        {
            // Email notification reagrding passwrd change
            string to = Apex.i.mainUser.userEmail;
            string subject = "Venzi notification alert";
            string body = "Hello " + Apex.i.mainUser.userName + "," + "\nYour password was changed successfully";
            Apex.i.sendEmail(to, subject, body);

        }
        public static void changeUsernameNotification()
        {
            //email notification regarding username change
            string to = Apex.i.mainUser.userEmail;
            string subject = "Venzi notification alert";
            string body = "Your username was changed successfully \nYour new user name is " + Apex.i.mainUser.userName;

            Apex.i.sendEmail(to, subject, body);
        }
        public static void WelcomeNotification(string to)
        {
            //Welcome email
            //This method requires the "to" to be passed
            //because "main user" does not exist yet at the time of user creation, so i pass newUser.email instead
            //TODO ADD USER GUIDE
            string subject = "Welcome to Venzi";
            string body = "Testing welcome email";
            Apex.i.sendEmail(to, subject, body);
        }
        public static void requestDeniedNotification(string to)
        {
            //email notification for denying request
            //This method requires the "to" to be passed
            
            string subject = "Venzi notification alert";
            string body = "Your request has been denied";

            Apex.i.sendEmail(to, subject, body);
        }
        public static void requestAcceptedNotification(string to)
        {
            //email notification for accepting requests
            //This method requires the "to" to be passed
            string subject = "Venzi notification alert";
            string body = "Your request has been approved";

            Apex.i.sendEmail(to, subject, body);
        }


    }
}
