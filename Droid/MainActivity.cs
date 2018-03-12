using Android.App;
using Android.Widget;
using Android.OS;
//using Qoden.UI;

namespace Droid
{
    [Activity(Label = "Registration", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            
            SetContentView (new Button(this));
        }
    }
}