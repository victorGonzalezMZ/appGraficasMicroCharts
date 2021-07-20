using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Microcharts;
using Microcharts.Droid;
using SkiaSharp;
using System.Collections.Generic;

namespace appGraficaMicrocharts
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        List<ChartEntry> entries = new List<ChartEntry>
        {
            new ChartEntry(197)
            {
                Color = SKColor.Parse("#800040"),
                Label = "Morena",
                ValueLabel = "197"
            },
            new ChartEntry(111)
            {
                Color = SKColor.Parse("#0000ff"),
                Label = "PAN",
                ValueLabel = "111"
            },
            new ChartEntry(69)
            {
                Color = SKColor.Parse("#ff0000"),
                Label = "PRI",
                ValueLabel = "69"
            },
            new ChartEntry(44)
            {
                Color = SKColor.Parse("#008f39"),
                Label = "PVEM",
                ValueLabel = "44"
            },
            new ChartEntry(38)
            {
                Color = SKColor.Parse("#8b0000"),
                Label = "PT",
                ValueLabel = "38"
            },
            new ChartEntry(24)
            {
                Color = SKColor.Parse("#ff8000"),
                Label = "MC",
                ValueLabel = "24"
            },
            new ChartEntry(17)
            {
                Color = SKColor.Parse("#ffff00"),
                Label = "PRD",
                ValueLabel = "17"
            }
        };

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            SupportActionBar.Hide();

            var Grafica1 = FindViewById<ChartView>(Resource.Id.grafica1);
            var Grafica2 = FindViewById<ChartView>(Resource.Id.grafica2);
            var Grafica3 = FindViewById<ChartView>(Resource.Id.grafica3);
            var Grafica4 = FindViewById<ChartView>(Resource.Id.grafica4);

            var Datos1 = new LineChart() { Entries = entries };
            var Datos2 = new DonutChart() { Entries = entries };
            var Datos3 = new PointChart() { Entries = entries };
            var Datos4 = new BarChart() { Entries = entries };

            Grafica1.Chart = Datos1;
            Grafica2.Chart = Datos2;
            Grafica3.Chart = Datos3;
            Grafica4.Chart = Datos4;
        }
    }
}