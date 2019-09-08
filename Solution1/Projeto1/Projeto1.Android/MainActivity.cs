using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Projeto1.Classes;

namespace Projeto1.Droid
{
    [Activity(Label = "Projeto1", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        private TextView lblResultado;
        private EditText edtNumero1;
        private EditText edtNumero2;
        private Button btnSomar;

        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MainPage);

            edtNumero1 = FindViewById<EditText>(Resource.Id.edtNumero1);
            edtNumero2 = FindViewById<EditText>(Resource.Id.edtNumero2); 
            btnSomar = FindViewById<Button>(Resource.Id.btnSomar);
            lblResultado = FindViewById<TextView>(Resource.Id.lblResultado);

            btnSomar.Click += BtnSomar_Click;
        }

        private void BtnSomar_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(edtNumero1.Text);
            int num2 = int.Parse(edtNumero2.Text);

            int result = MyClass.Somar(num1, num2);

            lblResultado.Text = "A soma dos valores é: " + result.ToString();

        }
    }
}