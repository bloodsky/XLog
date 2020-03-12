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
                DisplayAlert("LoginScreen", "Login Failed!", "ok");
            }
        }
    }
}