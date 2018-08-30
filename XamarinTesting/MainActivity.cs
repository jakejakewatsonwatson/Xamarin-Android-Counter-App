using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace XamarinTesting
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView txtNumber;

        TextView txtNumber2;

        int number = 20;
        int number2 = 20;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            txtNumber = FindViewById<TextView>(Resource.Id.txtNumber);

            FindViewById<Button>(Resource.Id.btnIncrement).Click += (o, e) => txtNumber.Text = (++number).ToString();

            FindViewById<Button>(Resource.Id.btnDecrement).Click += (o, e) => txtNumber.Text = (--number).ToString();

            txtNumber2 = FindViewById<TextView>(Resource.Id.txtNumber2);

            FindViewById<Button>(Resource.Id.btnIncrement2).Click += (o, e) => txtNumber2.Text = (++number2).ToString();

            FindViewById<Button>(Resource.Id.btnDecrement2).Click += (o, e) => txtNumber2.Text = (--number2).ToString();

        }
    }
}