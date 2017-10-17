using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

namespace SQlite2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            SQLiteAsyncConnection database;
            string db;

            db = DependencyService.Get<ISQLite>().GetLocalFilePath("TDB.db");
            database = new SQLiteAsyncConnection(db);
            database.CreateTableAsync<Datos>().Wait();
            var elemento = new Datos
            {
                Id = "1",
            Dto1 = "Lulu",
            Dto2 = "Jimenez",
            Dto3 = "Naucalpan",
            Dto4 = "555555555",
            Dto5 = "ISC",
            Dto6 = "Noveno",
            Dto7 = "13090390",
            Dto8 = "jnz_lulu@Hotmail.com",
            Dto9 = "MireyaLulu",
               };
            

            database.InsertAsync(elemento);


        }
    }
}
