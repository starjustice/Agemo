using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;


namespace agendamemo
{
    [Activity(Label = "agendamemo", MainLauncher = true)]   
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var email = FindViewById<TextView>(Resource.Id.email);
            var pass = FindViewById<TextView>(Resource.Id.password);
            var btnlogin = FindViewById<Button>(Resource.Id.btn_login);


        }
    }
}

