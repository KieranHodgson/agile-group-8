using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Org.Apache.Http.Authentication;
using System.Threading.Tasks;
using System;

namespace Union_Organiser
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText Username;
        EditText Password;
        TextView error;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            Username = FindViewById<EditText>(Resource.Id.Username);
            Password = FindViewById<EditText>(Resource.Id.Password);
            error = FindViewById<TextView>(Resource.Id.Error);
            FindViewById<Button>(Resource.Id.ButtonLogin).Click += (e, o) =>
            getLogin();
        }
        
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        public void getLogin()
        { 
            string usernameString = Username.Text;
            string passwordString = Password.Text;
            if (Login(passwordString, usernameString))
            {
                SetContentView(Resource.Layout.activity_main);
            }
            else
            {
                error.Text = "incorrect username/password";
            }
        }
        public bool Login (string loginPasswordString, string loginUsernameString)
        {
            return false;
        }

    }
}