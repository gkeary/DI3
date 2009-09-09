using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Configuration.Provider;
using System.Configuration;
using System.IO;
// ???
//using TabDispatch.My;
using SubSonic;
using System.Xml;
using System.Text;
using System.Collections;
using BLL;
using DispatchAR;

namespace WinClient
{
    /// <summary>
    ///Contains the main entry point for the application.
    /// cannot be instantiated.
    /// contains useful static methods
    /// </summary>
    static class Program
    {
        #region properties
        public static List<ScreenDimension> ScreenArray;
        public static List<Route> RouteArray;
        private static int _screenheight;
        private static int _screenwidth;
        //    private static Stream Stream;

        public static int ScreenHeight
        {
            get { return _screenheight; }
            set { _screenheight = value; }
        }
        public static int ScreenWidth
        {
            get { return _screenwidth; }
            set { _screenwidth = value; }
        }

        //public static Stream Stream
        //{
        //    get { return _stream; }
        //    //set { _stream = value; }
        //}
        #endregion
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Program pr = new Program(); // cannot create instance of an abstract class.  look for instances of pr ???
            // take this out when we remove the unused constructor Application.Run(new MainForm(_stream));
            Application.Run(new MainForm());
        }

        #region static methods
        public static void ComputeScreenBoundaries()
        {
            int intShortestHeight = 0;
            int intThisHeight = 0;
            int intLastHeight = 0;
            var intScreenWidth = 0;
            int intScreenHeight = 0;
            int Index = 0;
            int UpperBound = 0;
            System.Windows.Forms.Screen[] Screens = System.Windows.Forms.Screen.AllScreens;

            UpperBound = Screens.GetUpperBound(0);

            if ((Screens.GetUpperBound(0) > 0))
            {
                for (Index = 0; Index <= UpperBound; Index++)
                {
                    intScreenWidth += Screens[Index].Bounds.Width;
                    intThisHeight = Screens[Index].Bounds.Height;
                    if ((intThisHeight <= intLastHeight))
                    {
                        intShortestHeight = intThisHeight;
                    }
                    intLastHeight = intThisHeight;
                }
            }
            else
            {
                intScreenWidth += Screens[Index].Bounds.Width;
                intShortestHeight = Screens[Index].Bounds.Height;
            }
            intScreenHeight = intShortestHeight;

            ScreenHeight = intScreenHeight;

            ScreenWidth = intScreenWidth;
        }
        public static void SaveWindowPositions(MainForm mainForm)
        {
        
            var Stream = File.Open("scr.xml", FileMode.OpenOrCreate);
            var settings = new XmlWriterSettings();
            var writer = XmlWriter.Create(Stream, settings);

            // bug: what should I do with this, now that I'm using streams?
            //File.Delete("scr.xml") ' throws no exception if file does not exist
            if (Stream.CanSeek)
            {
                Stream.SetLength(0);
            }

            settings.Indent = true;
            settings.ConformanceLevel = ConformanceLevel.Fragment;

            //settings.NewLineOnAttributes = True  ' File will have one screen per line if this is false
            settings.IndentChars = "  ";
            //writer is placing 3 spurious characters at the beginning of the file ?
            // the next line fixes that --- but is default good enough? -Yes
            settings.Encoding = Encoding.Default;

            // Write XML data.[Index]
            char[] NL = Environment.NewLine.ToArray();
            writer.WriteStartDocument(true);
            writer.WriteComment("Created at " + DateTime.Now.ToString("G"));
            writer.WriteStartElement("Screens");
            writer.WriteChars(NL, 0, 1);
            writer.WriteStartElement("Items", "scr");
            writer.WriteChars(NL, 0, 1);
            for (int i = 0; i <= mainForm.MdiChildren.Length - 1; i++)
            {
                writer.WriteStartElement("Item", "scr");

                writer.WriteStartAttribute("Title");
                writer.WriteValue(mainForm.MdiChildren[i].Text);
                writer.WriteEndAttribute();

                writer.WriteStartAttribute("Left");
                writer.WriteValue(mainForm.MdiChildren[i].Left);
                writer.WriteEndAttribute();

                writer.WriteStartAttribute("Top");
                writer.WriteValue(mainForm.MdiChildren[i].Top);
                writer.WriteEndAttribute();

                writer.WriteStartAttribute("Width");
                writer.WriteValue(mainForm.MdiChildren[i].Width);
                writer.WriteEndAttribute();

                writer.WriteStartAttribute("Height");
                writer.WriteValue(mainForm.MdiChildren[i].Height);
                writer.WriteEndAttribute();

                writer.WriteEndElement();
                //Item
                writer.WriteChars(NL, 0, 1);
            }
            //mdiChild
            writer.WriteEndElement();
            //Items
            writer.WriteChars(Environment.NewLine.ToArray(), 0, 1);
            writer.WriteEndElement();
            //Screens

            writer.Flush();
            // there are issues here...
            //XMLStream.Close()
            writer.Close();
        }

        public static void LoadMDIList(Stream stream)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            XmlReader reader = default(XmlReader);
            settings.ConformanceLevel = ConformanceLevel.Fragment;
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;

            //see Nunit test pp 99 
            //this is what it used to be
            // you have to test for scr.xml
            // don't build for testing at the expense of needed functionality
            try
            {
                reader = XmlReader.Create(stream);
            }
            catch
            {
                var sb = new StringBuilder();
                sb.AppendLine("The scr.xml file is missing or faulty");
                sb.AppendLine("Please create it ");
                sb.AppendLine(" by saving Screen Positions");
                MessageBox.Show(sb.ToString());
                return;
            }
            while (reader.Read())
            {
                switch (reader.Name)
                {
                    case "":
                        continue;
                    case "xml":
                        continue;
                    case "Screens":
                        continue;
                    case "Items":
                        continue;
                    //default:
                    // TODO: fix this

                    //  ScreenDimension sd = new ScreenDimension();
                    //sd.WinTitle = reader.Item["Title"];
                    //sd.TopInt = reader.Item["Top"];
                    //sd.LeftInt = reader.Item["Left"];
                    //sd.WidthInt = reader.Item["Width"];
                    //sd.HeightInt = reader.Item["Height"];
                    //ScreenArray.Add(sd);
                    //if (sd.WinTitle != "Input" & sd.WinTitle != "TabForm") {
                    //    // it is a frmRoute Screen
                    //    RouteArray.Add(sd);
                    //}

                    //break;
                }
            }
            //reader
            // file remains open unless this happens
            // don't know how to open it at write time however...
            // todo: find out about stream.close this and fix it
            //stream.Close()
            reader.Close();
        }
        // depricated because I'm using SPRING...
        //public static void SetProvider(string appConfigPath)
        //{
        //    //clear the providers and reset
        //    DataService.Provider = new SqlDataProvider();
        //    DataService.Providers = new DataProviderCollection();


        //    //if present, get the connection strings and the SubSonic config
        //    if (File.Exists(appConfigPath)) {
        //        ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
        //        Console.WriteLine("Building configuration from " + Path.Combine(Directory.GetCurrentDirectory(), appConfigPath));
        //        fileMap.ExeConfigFilename = appConfigPath;

        //        // Open another config file
        //        Configuration subConfig = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);

        //        try {
        //            SubSonicSection section = (SubSonicSection)subConfig.GetSection(ConfigurationSectionName.SUB_SONIC_SERVICE);

        //            if (section != null) {
        //                DataService.ConfigSection = section;
        //                //Dim argTemplateDirectory As String = GetArg(ConfigurationPropertyName.TEMPLATE_DIRECTORY)
        //                //Dim activeTemplateDirectory As String = IIf([String].IsNullOrEmpty(argTemplateDirectory), section.TemplateDirectory, argTemplateDirectory)


        //                //Dim argTraceFlag As String = GetArg(ConfigurationPropertyName.ENABLE_TRACE)
        //                //Dim activeTraceFlag As String = IIf([String].IsNullOrEmpty(argTraceFlag), section.EnableTrace, argTraceFlag)

        //                //If Not [String].IsNullOrEmpty(activeTraceFlag) Then
        //                //    DataService.EnableTrace = Convert.ToBoolean(activeTraceFlag)
        //                //End If

        //                //If Not [String].IsNullOrEmpty(activeTemplateDirectory) Then
        //                //    Console.WriteLine("Overriding default templates with those from " + section.TemplateDirectory)
        //                //    CodeService.TemplateDirectory = activeTemplateDirectory
        //                //End If

        //                //initialize
        //                //need to pull out the default connection string
        //                //since this application doesn't have a config file, the target one does
        //                //so reconciling connection string won't work
        //                string connectionStringName = section.Providers(0).Parameters("connectionStringName");
        //                if (connectionStringName == null) {
        //                    throw new ConfigurationErrorsException("The Parameter 'connectionStringName' was not specified");
        //                }

        //                ConnectionStringSettings connSettings = subConfig.ConnectionStrings.ConnectionStrings(connectionStringName);
        //                if (connSettings == null) {
        //                    throw new ConfigurationErrorsException(string.Format("ConnectionStrings section missing connection string with the name '{0}'", connectionStringName));
        //                }

        //                string connString = subConfig.ConnectionStrings.ConnectionStrings(connectionStringName).ConnectionString;
        //                //DataService.ConnectionString = connString;


        //                System.Web.Configuration.ProvidersHelper.InstantiateProviders(section.Providers, DataService.Providers, typeof(DataProvider));

        //                //this is a tad backwards, but it's what needs to happen since our application
        //                //is configuring another application's providers
        //                //go back and reset the provider's connection strings
        //                //tcp:elwood\sqlexpress;Initial Catalog=dispatch_production;Integrated Security=SSPI;" 
        //                //               MySettings.Default.Terminal + " Pickups Today: " + frmRoute.DailyCount.ToString()
        //                foreach (DataProvider provider in DataService.Providers) {
        //                    Console.WriteLine("Adding connection to " + provider.Name);

        //                    //provider.ConnectionString = subConfig.ConnectionStrings.ConnectionStrings[provider.ConnectionStringName].ConnectionString;
        //                    if (MySettings.Default.ConnectionType == "AppConfig") {
        //                        provider.SetDefaultConnectionString(subConfig.ConnectionStrings.ConnectionStrings(provider.ConnectionStringName).ConnectionString);
        //                    }
        //                    else {
        //                        string constr = BuildConnectionString();
        //                        provider.SetDefaultConnectionString(constr);
        //                    }
        //                }


        //                //reset the default provider
        //                //Dim providerName As String = GetArg("provider")
        //                string providerName = "RossData";
        //                if (providerName != string.Empty) {
        //                    try {
        //                        DataService.Provider = DataService.Providers(providerName);
        //                    }
        //                    catch (Exception e) {
        //                        Console.WriteLine("ERROR: There is no provider with the name '{0}'. Exception: {1}", providerName, e);
        //                    }
        //                }
        //                else {
        //                    DataService.Provider = DataService.Providers(section.DefaultProvider);
        //                }
        //            }
        //        }
        //        catch (ConfigurationErrorsException x) {
        //            //let the user know the config was problematic...
        //            Console.WriteLine("Can't set the configuration for the providers. There is an error with your config setup (did you remember to configure SubSonic in your config file?). '{0}'", x.Message);
        //        }
        //    }
        //    else {
        //        throw new Exception("There's no config file present at " + appConfigPath);
        //    }
        //}
        //tcp:elwood\sqlexpress;Initial Catalog=dispatch_production;Integrated Security=SSPI;" 
        //nini connection string:
        //connectionString="Provider=SQLOLEDB;
        //Driver={SQL Server};
        //Server=elwood\sqlexpress;
        //    Initial Catalog=dispatch_development;Uid=ross_devel;PWD=123ross321;" />


        private static string BuildConnectionString()
        {
            StringBuilder sb = new StringBuilder();
            {
                // build a good string here but...
                // look at other ways to do this???
                sb.Append("Data Source=");
                sb.Append("tcp:");
                // sb.Append(Dispatch3.Properties.Settings.Default.Server);
                sb.Append("\\sqlexpress;Initial Catalog=");
                //  sb.Append(Settings.Default.DB);
                sb.Append(";Uid=");
                // sb.Append(Settings.Default.dbuser);
                sb.Append(";PWD=");
                //sb.Append(Settings.Default.dbpw);
                sb.Append(";");
            }
            return sb.ToString();
        }
        public static bool TestConnectionString()
        {
            var TestConnectionString = true;
            try
            {
                TestConnectionString = true;
                var dvr =  (BLL.Driver.DriverBLL)WinClient.ApplicationContext["DriverBLL"];
                var d = dvr.GetAll();
            }
            catch (Exception ex)
            {
                var sb = new StringBuilder();
                sb.AppendLine("Unable to connect with the database.");
                sb.AppendLine();
                sb.AppendLine(ex.Message);
                sb.AppendLine("");
                sb.AppendLine("Current Settings:");
                //sb.AppendLine(String.Format("\tDB Server: {0}", WinClient.Properties.Settings.Default.Server));
                //sb.AppendLine(String.Format("\tDatabase Name: {0}", WinClient.Properties.Settings.Default.DB));
                //sb.AppendLine(String.Format("\tDatabase User: {0}", WinClient.Properties.Settings.Default.dbuser));
                //sb.AppendLine(String.Format("\tDatabase Password: {0}", WinClient.Properties.Settings.Default.dbpw));
                MessageBox.Show(sb.ToString(), "DB CONNECTION FAILURE");
                TestConnectionString = false;
            }
            return TestConnectionString;
        }
        // to add many records, use SimpleRepository.AddMany<T>
    //    public void AddMany<T>(System.Collections.Generic.IEnumerable<T> items)
    //where T : new(), class
    //Member of SubSonic.Repository.SimpleRepository

        internal static List<CurrentDayRoute> GetCDRCollection()
        //internal static IQuery<CurrentDayRoute> GetCDRCollection()
        {
            var cdr = (List<CurrentDayRoute>)WinClient.ApplicationContext["CDRBLL"];
           // var cdr = (BLL.CDPCDR.CurrentDayRouteBLL)WinClient.ApplicationContext["CDRBLL"];
            return cdr;
        }
        internal static int GetCDRCount()
        {
            return 20;
        //    throw new NotImplementedException();
        }
        internal static int GetCDPCount()
        {
            return 20;
         ////   throw new NotImplementedException();
        }

        #endregion static methods


    }
}