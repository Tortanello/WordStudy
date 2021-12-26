using System;
using System.IO;
using System.Reflection;
using WordStudy.Resources.BaseData;
using WordStudy.Resources.layaout;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WordStudy
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "Words.db";
        public static Class_Words database;


        public const string DATABASE_NAME_Lang = "Lang.db";
        public static Class_Lang database_Lang;

        public const string DATABASE_NAME_Lang_C = "Lang_C.db";
        public static Class_Lang_C database_Lang_C;

        public const string DATABASE_NAME_Settings = "Settings.db";
        public static Class_Settings database_Settings;

        public static Class_Words Database
        {
            get
            {
                if (database == null)
                {
                    database = new Class_Words(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }

       
        public static Class_Lang Database_Lang
        {
            get
            {
                if (database_Lang == null)
                {
                    /*database_Lang = new Class_Lang(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME_Lang));*/
                    string Path_db = Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME_Lang);
                    // если база данных не существует (еще не скопирована)
                    if (!File.Exists(Path_db))
                    {
                        // получаем текущую сборку
                        var assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
                        // берем из нее ресурс базы данных и создаем из него поток
                        using (Stream stream = assembly.GetManifestResourceStream($"WordStudy.Resources.BaseData.Floder_For_DB.{DATABASE_NAME_Lang}"))
                        {
                            using (FileStream fs = new FileStream(Path_db, FileMode.OpenOrCreate))
                            {
                                stream.CopyTo(fs);  // копируем файл базы данных в нужное нам место
                                fs.Flush();
                            }
                        }
                    }
                    database_Lang = new Class_Lang(Path_db);
                }
                return database_Lang;
            }
        }





        public static Class_Lang_C Database_Lang_C
        {
            get
            {
                if (database_Lang_C == null)
                {
                    string Path_db = Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME_Lang_C);
                    // если база данных не существует (еще не скопирована)
                    if (!File.Exists(Path_db))
                    {
                        // получаем текущую сборку
                        var assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
                        // берем из нее ресурс базы данных и создаем из него поток
                        using (Stream stream = assembly.GetManifestResourceStream($"WordStudy.Resources.BaseData.Floder_For_DB.{DATABASE_NAME_Lang_C}"))
                        {
                            using (FileStream fs = new FileStream(Path_db, FileMode.OpenOrCreate))
                            {
                                stream.CopyTo(fs);  // копируем файл базы данных в нужное нам место
                                fs.Flush();
                            }
                        }
                    }
                    database_Lang_C = new Class_Lang_C(Path_db);
                }
                return database_Lang_C;
            }
        }

        public static Class_Settings Database_Settins
        {
            get
            {
                if (database_Settings == null)
                {
                    string Path_db = Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME_Settings);
                    // если база данных не существует (еще не скопирована)
                    if (!File.Exists(Path_db))
                    {
                        // получаем текущую сборку
                        var assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
                        // берем из нее ресурс базы данных и создаем из него поток
                        using (Stream stream = assembly.GetManifestResourceStream($"WordStudy.Resources.BaseData.Floder_For_DB.{DATABASE_NAME_Settings}"))
                        {
                            using (FileStream fs = new FileStream(Path_db, FileMode.OpenOrCreate))
                            {
                                stream.CopyTo(fs);  // копируем файл базы данных в нужное нам место
                                fs.Flush();
                            }
                        }
                    }
                    database_Settings = new Class_Settings(Path_db);
                }
                return database_Settings;
            }
        }




        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
