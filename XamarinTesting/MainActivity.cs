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
        TextView txtPlayerOneLife;
        TextView txtPLayerTwoLife;

        TextView txtWhiteMana;
        TextView txtBlueMana;
        TextView txtRedMana;
        TextView txtGreenMana;
        TextView txtBlackMana;


        int playerOneLife = 20;
        int playerTwoLife = 20;

        int totalWhiteMana;
        int totalBlueMana;
        int totalRedMana;
        int totalGreenMana;
        int totalBlackMana;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            txtPlayerOneLife = FindViewById<TextView>(Resource.Id.txtPlayerOneLife);
            FindViewById<Button>(Resource.Id.btnIncrement).Click += (o, e) => txtPlayerOneLife.Text = (++playerOneLife).ToString();
            FindViewById<Button>(Resource.Id.btnDecrement).Click += (o, e) => txtPlayerOneLife.Text = (--playerOneLife).ToString();

            txtPLayerTwoLife = FindViewById<TextView>(Resource.Id.txtPLayerTwoLife);
            FindViewById<Button>(Resource.Id.btnIncrement2).Click += (o, e) => txtPLayerTwoLife.Text = (++playerTwoLife).ToString();
            FindViewById<Button>(Resource.Id.btnDecrement2).Click += (o, e) => txtPLayerTwoLife.Text = (--playerTwoLife).ToString();

            txtWhiteMana = FindViewById<TextView>(Resource.Id.txtWhiteMana);
            FindViewById<Button>(Resource.Id.btnWhiteManaInc).Click += (o, e) => txtWhiteMana.Text = (++totalWhiteMana).ToString();
            FindViewById<Button>(Resource.Id.btnWhiteManaDec).Click += (o, e) => txtWhiteMana.Text = (--totalWhiteMana).ToString();

            txtBlueMana = FindViewById<TextView>(Resource.Id.txtBlueMana);
            FindViewById<Button>(Resource.Id.btnBlueManaInc).Click += (o, e) => txtBlueMana.Text = (++totalBlueMana).ToString();
            FindViewById<Button>(Resource.Id.btnBlueManaDec).Click += (o, e) => txtBlueMana.Text = (--totalBlueMana).ToString();

            txtRedMana = FindViewById<TextView>(Resource.Id.txtRedMana);
            FindViewById<Button>(Resource.Id.btnRedManaInc).Click += (o, e) => txtRedMana.Text = (++totalRedMana).ToString();
            FindViewById<Button>(Resource.Id.btnRedManaDec).Click += (o, e) => txtRedMana.Text = (--totalRedMana).ToString();

            txtGreenMana = FindViewById<TextView>(Resource.Id.txtGreenMana);
            FindViewById<Button>(Resource.Id.btnGreenManaInc).Click += (o, e) => txtGreenMana.Text = (++totalGreenMana).ToString();
            FindViewById<Button>(Resource.Id.btnGreenManaDec).Click += (o, e) => txtGreenMana.Text = (--totalGreenMana).ToString();

            txtBlackMana = FindViewById<TextView>(Resource.Id.txtBlackMana);
            FindViewById<Button>(Resource.Id.btnBlackManaInc).Click += (o, e) => txtBlackMana.Text = (++totalBlackMana).ToString();
            FindViewById<Button>(Resource.Id.btnBlackManaDec).Click += (o, e) => txtBlackMana.Text = (--totalBlackMana).ToString();

        }
    }
}