using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XLog.Models;

namespace XLog.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginScreen : ContentPage
    {
        public LoginScreen()
        {
            // Init for the xaml layout, label and button
            InitializeComponent();
            // Init screen with custom costants and custom stackpanel
            MyInit();
        }


        void MyInit()
        {
            // Controlling our design (?Alessandro?)
            BackgroundColor = Constants.BgColor;
            Username_Label.TextColor = Constants.TextColor;
            Password_Label.TextColor = Constants.TextColor;
            ActivitySpinner.IsVisible = false;
            LoginImg.HeightRequest = Constants.IconHeight;

            // Cool things Android Studio didn't do so well :)
            // Setting jobs schedule with closing keyboard and stuff related to animation.
            Username_Entry.Completed += (s, e) => Password_Entry.Focus();
            Password_Entry.Completed += (s, e) => SignInHandler(s, e);

        }

        void SignInHandler(object sender, EventArgs e)
        {
            User user = new User(Username_Entry.Text, Password_Entry.Text);

            if (user.InfoCheck())
            {
                // DisplayAlert(Titolo,Messaggio,Testo button)
                DisplayAlert("LoginScreen", "Login Success", "ok");
            }
            else
            {
                // DisplayAlert(Titolo,Messaggio,Testo button)
                DisplayAlert("LoginScreen", "Login Failed!!!", "ok");
            }
        }
    }
}