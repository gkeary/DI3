using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.Configuration.Provider;
using System.Configuration;
using System.IO;
// ???
//using TabDispatch.My;
using RossData;
using SubSonic;
using System.Xml;
using System.Text;
using System.Collections;



namespace Dispatch3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // from vb...
                //Application.EnableVisualStyles();
                //    Application.SetCompatibleTextRenderingDefault(false);
                //    Program pr = new Program();
                //    Application.Run(new MainForm(_stream));
                //        Application.Run(new MainForm());
        }


    #region "Declarations"
    //Public Shared mdiArray() As ArrayList(ScreenDimension?<
    // removed mdiArray() to eliminate (hopefully) occasional off-by-one errors
    //Public Shared mdiArray() As ScreenDimension
    public static ArrayList ScreenArray = new ArrayList();
    public static ArrayList RouteArray = new ArrayList();
    
    private static Stream _stream;
    // Settings not needed ??? 
    //public static My.MySettings Settings = new My.MySettings();
    #endregion
    #region "Constructors"
    public Program()
    {
        _stream = File.Open("scr.xml", FileMode.OpenOrCreate);
    }
    
    public Program(Stream stream)
    {
        _stream = stream;
    }
    
    #endregion
    //here is a link which provides some advice on setup:
    //    http://www.dotnet247.com/247reference/msgs/51/257248.aspx
    
    //'
    //'<summary>
    //'The main entry point for the application.
    //'</summary> 
/*************    
    [STAThread()]
    public static void Main(string[] args)
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Program pr = new Program();
        Application.Run(new MainForm(_stream));
    }
 * *********************/
    //# Imports System.IO
    //#
    //# Namespace RossData
    //#     Public Class Program
    //#         Private _stream As Stream
    //#      
    //#       Use this constructor for testing.
    //@      'then Stream can be a memory object
    //#         Public Sub New(ByVal XMLStream As Stream)
    //#             _stream = XMLStream
    //#         End Sub
    //#         Public Sub New()
    //#             _stream = File.Open("scr.xml", FileMode.OpenOrCreate)
    //#         End Sub
    //#     End Class
    //#    
    //# End Namespace
    public static void ComputeScreenBoundaries()
    {
        int x = 0;
        int y = 0;
        int intShortestHeight = 0;
        int intThisHeight = 0;
        int intLastHeight = 0;
        var intScreenWidth = 0;
        int intScreenHeight = 0;
        int Index = 0;
        int UpperBound = 0;
        System.Windows.Forms.Screen[] Screens = System.Windows.Forms.Screen.AllScreens;
        
        UpperBound = Screens.GetUpperBound(0);
        
        if ((Screens.GetUpperBound(0) > 0)) {
            for (Index = 0; Index <= UpperBound; Index++) {
                intScreenWidth += Screens[Index].Bounds.Width;
                intThisHeight = Screens[Index].Bounds.Height;
                if ((intThisHeight <= intLastHeight)) {
                    intShortestHeight = intThisHeight;
                }
                intLastHeight = intThisHeight;
            }
        }
        else {
            intScreenWidth += Screens[Index].Bounds.Width;
            intShortestHeight = Screens[Index].Bounds.Height;
        }
        intScreenHeight = intShortestHeight;
        
        ScreenHeight = intScreenHeight;
            
        ScreenWidth = intScreenWidth;
    }
    private static int _screenheight;
    private static int _screenwidth;
    private static Stream _XMLStream;
    
    public static int ScreenHeight {
        get { return _screenheight; }
        set { _screenheight = value; }
    }
    public static int ScreenWidth {
        get { return _screenwidth; }
        set { _screenwidth = value; }
    }
    public class ScreenDimension
    {
        private string _title;
        private int _top;
        private int _left;
        private int _width;
        private int _height;
        private int _screenheight;
        private int _screenwidth;
        public ScreenDimension ScreenDimension(string t, int ti, int li, int wi, int hi)
        {
            ScreenDimension sv = new ScreenDimension();
            sv.WinTitle = t;
            sv.TopInt = ti;
            sv.LeftInt = li;
            sv.WidthInt = wi;
            sv.HeightInt = hi;
            return sv;
        }
        
        public string WinTitle {
            get { return _title; }
            set { _title = value; }
        }
        
        public int TopInt {
            get { return _top; }
            set { _top = value; }
        }
        
        public int LeftInt {
            get { return _left; }
            set { _left = value; }
        }
        
        public int WidthInt {
            get { return _width; }
            set { _width = value; }
        }
        
        public int HeightInt {
            get { return _height; }
            set { _height = value; }
        }
    }
    public static Stream XMLStream {
        get { return _XMLStream; }
        set { _XMLStream = value; }
    }
    public static void SaveWindowPositions(MainForm mainForm)
    {
        var settings = new XmlWriterSettings();
        var writer = XmlWriter.Create(XMLStream, settings);
        
        // bug: what should I do with this, now that I'm using streams?
        //File.Delete("scr.xml") ' throws no exception if file does not exist
        if (XMLStream.CanSeek) {
            XMLStream.SetLength(0);
        }
        
        settings.Indent = true;
        settings.ConformanceLevel = ConformanceLevel.Fragment;
        
        //settings.NewLineOnAttributes = True  ' File will have one screen per line if this is false
        settings.IndentChars = "  ";
        //writer is placing 3 spurious characters at the beginning of the file ?
        // the next line fixes that --- but is default good enough? -Yes
        settings.Encoding = Encoding.Default;
        
        // Write XML data.[Index]
        char[] NL =  Environment.NewLine.ToArray();
        writer.WriteStartDocument(true);
        writer.WriteComment("Created at " + DateTime.Now.ToString("G"));
        writer.WriteStartElement("Screens");
        writer.WriteChars(NL, 0, 1);
        writer.WriteStartElement("Items", "scr");
        writer.WriteChars(NL, 0, 1);
        for (int i = 0; i <= mainForm.MdiChildren.Length - 1; i++) {
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
        try {
            reader = XmlReader.Create(stream);
        }
        catch {
            var sb = new StringBuilder();
            sb.AppendLine("The scr.xml file is missing or faulty");
            sb.AppendLine("Please create it ");
            sb.AppendLine(" by saving Screen Positions");
            MessageBox.Show(sb.ToString());
            return;
        }
        while (reader.Read()) {
            switch (reader.Name) {
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
    public static void SetProvider(string appConfigPath)
    {
        //clear the providers and reset
        DataService.Provider = new SqlDataProvider();
        DataService.Providers = new DataProviderCollection();
        
        
        //if present, get the connection strings and the SubSonic config
        if (File.Exists(appConfigPath)) {
            ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
            Console.WriteLine("Building configuration from " + Path.Combine(Directory.GetCurrentDirectory(), appConfigPath));
            fileMap.ExeConfigFilename = appConfigPath;
            
            // Open another config file
            Configuration subConfig = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
            
            try {
                SubSonicSection section = (SubSonicSection)subConfig.GetSection(ConfigurationSectionName.SUB_SONIC_SERVICE);
                
                if (section != null) {
                    DataService.ConfigSection = section;
                    //Dim argTemplateDirectory As String = GetArg(ConfigurationPropertyName.TEMPLATE_DIRECTORY)
                    //Dim activeTemplateDirectory As String = IIf([String].IsNullOrEmpty(argTemplateDirectory), section.TemplateDirectory, argTemplateDirectory)
                    
                    
                    //Dim argTraceFlag As String = GetArg(ConfigurationPropertyName.ENABLE_TRACE)
                    //Dim activeTraceFlag As String = IIf([String].IsNullOrEmpty(argTraceFlag), section.EnableTrace, argTraceFlag)
                    
                    //If Not [String].IsNullOrEmpty(activeTraceFlag) Then
                    //    DataService.EnableTrace = Convert.ToBoolean(activeTraceFlag)
                    //End If
                    
                    //If Not [String].IsNullOrEmpty(activeTemplateDirectory) Then
                    //    Console.WriteLine("Overriding default templates with those from " + section.TemplateDirectory)
                    //    CodeService.TemplateDirectory = activeTemplateDirectory
                    //End If
                    
                    //initialize
                    //need to pull out the default connection string
                    //since this application doesn't have a config file, the target one does
                    //so reconciling connection string won't work
                    string connectionStringName = section.Providers(0).Parameters("connectionStringName");
                    if (connectionStringName == null) {
                        throw new ConfigurationErrorsException("The Parameter 'connectionStringName' was not specified");
                    }
                    
                    ConnectionStringSettings connSettings = subConfig.ConnectionStrings.ConnectionStrings(connectionStringName);
                    if (connSettings == null) {
                        throw new ConfigurationErrorsException(string.Format("ConnectionStrings section missing connection string with the name '{0}'", connectionStringName));
                    }
                    
                    string connString = subConfig.ConnectionStrings.ConnectionStrings(connectionStringName).ConnectionString;
                    //DataService.ConnectionString = connString;
                    
                    
                    System.Web.Configuration.ProvidersHelper.InstantiateProviders(section.Providers, DataService.Providers, typeof(DataProvider));
                    
                    //this is a tad backwards, but it's what needs to happen since our application
                    //is configuring another application's providers
                    //go back and reset the provider's connection strings
                    //tcp:elwood\sqlexpress;Initial Catalog=dispatch_production;Integrated Security=SSPI;" 
                    //               MySettings.Default.Terminal + " Pickups Today: " + frmRoute.DailyCount.ToString()
                    foreach (DataProvider provider in DataService.Providers) {
                        Console.WriteLine("Adding connection to " + provider.Name);
                        
                        //provider.ConnectionString = subConfig.ConnectionStrings.ConnectionStrings[provider.ConnectionStringName].ConnectionString;
                        if (MySettings.Default.ConnectionType == "AppConfig") {
                            provider.SetDefaultConnectionString(subConfig.ConnectionStrings.ConnectionStrings(provider.ConnectionStringName).ConnectionString);
                        }
                        else {
                            string constr = BuildConnectionString();
                            provider.SetDefaultConnectionString(constr);
                        }
                    }
                    
                    
                    //reset the default provider
                    //Dim providerName As String = GetArg("provider")
                    string providerName = "RossData";
                    if (providerName != string.Empty) {
                        try {
                            DataService.Provider = DataService.Providers(providerName);
                        }
                        catch (Exception e) {
                            Console.WriteLine("ERROR: There is no provider with the name '{0}'. Exception: {1}", providerName, e);
                        }
                    }
                    else {
                        DataService.Provider = DataService.Providers(section.DefaultProvider);
                    }
                }
            }
            catch (ConfigurationErrorsException x) {
                //let the user know the config was problematic...
                Console.WriteLine("Can't set the configuration for the providers. There is an error with your config setup (did you remember to configure SubSonic in your config file?). '{0}'", x.Message);
            }
        }
        else {
            throw new Exception("There's no config file present at " + appConfigPath);
        }
    }
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
            sb.Append("Data Source=");
            sb.Append("tcp:");
            sb.Append(Dispatch3.Properties.Settings.Default.Server);
            sb.Append("\\sqlexpress;Initial Catalog=");
            sb.Append(Settings.Default.DB);
            sb.Append(";Uid=");
            sb.Append(Settings.Default.dbuser);
            sb.Append(";PWD=");
            sb.Append(Settings.Default.dbpw);
            sb.Append(";");
        }
        return sb.ToString();
    }
    
    
    //Public Sub InitializeApp()
    
    //    ''
    //    ''todo: add  some stuff which tests database connection and pops a message when no one is home
    //    ''
    
    //    Dim name As Integer
    //    name = ConfigurationManager.AppSettings.Get("Provider").IndexOf("connectionStringName")
    
    //    'name = ConfigurationManager.GetSection("SubSonicService.Providers(RossData).connectionStringName")
    //    Dim cs As String
    //    cs = System.Configuration.ConfigurationManager.ConnectionStrings(name).ConnectionString
    //    Dim dprovider As SubSonic.DataProvider
    //    dprovider.SetDefaultConnectionString(cs)
    
    
    
    
    
    
    
    
    //    '        private string _defaultConnectionString;
    //    'public string DefaultConnectionString
    //    '{
    //    '    get
    //    '    {
    //    '        if(String.IsNullOrEmpty(_defaultConnectionString) && !String.IsNullOrEmpty(connectionStringName))
    //    '        {
    //    '    Try
    //    '            {
    //    '                _defaultConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
    //    '                //_defaultConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
    //    '            }
    //    '    Catch
    //    '            {
    //    '                //swallow the exception, since the connection string will be set later possibly
    //    '                _defaultConnectionString = "NOT SET";
    //    '            }
    //    '        }
    //    '        return _defaultConnectionString;
    //    '    }
    //    '    set { _defaultConnectionString = value; }
    //    '}      <SubSonicService defaultProvider="RossData">
    //    '    <providers>
    //    '        <clear />
    //    '        <add name="RossData"
    //    '    Type = "SubSonic.SqlDataProvider, SubSonic"
    //    '    connectionStringName = "jake"
    //    '             generatedNamespace="RossData" />
    //    '    </providers>
    //    '</SubSonicService>
    
    
    //    'Dim name As String
    //    'name = ConfigurationManager.GetSection("SubSonicService.Providers(RossData).connectionStringName")
    //    'Dim cs As String
    //    'cs = System.Configuration.ConfigurationManager.ConnectionStrings(name).ConnectionString
    
    //    'Settings.RossData.r
    //    'Application.p()
    //    '  Dim s As System.Configuration.SettingsProviderCollection = New System.Configuration.SettingsProviderCollection()
    //    'No provider is defined with the name RossProvider
    //    'Until this next line does not throw an exception, 
    //    'we are NOT going to get anywhere!
    //    'Dim test As String = LoadConnStringFromIni()
    //    'Try
    //    '    Dim RouteCollection As CurrentDayRouteCollection = New CurrentDayRouteCollection
    
    //    'Catch ex As Exception
    //    '    MessageBox.Show(ex.Message)
    
    //    'End Try
    
    
    
    //    ' these are not used
    //    'Dim SQLserverString, ODBCString As String
    //    'SQLserverString = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=ross;Initial Catalog=dispatch_development;Data Source=jake\sqlexpress"
    //    'ODBCString = "Provider=MSDASQL;Persist Security Info=False;Extended Properties='DRIVER=SQL Server;SERVER=jake\sqlexpress;UID=ross;APP=Microsoft® Visual Studio .NET;WSID=ELWOOD;DATABASE=dispatch_development'"
    
    //    'strLocalConnection = LoadConnStringFromIni()
    //    'If (Not OdbcConnection1.State = ConnectionState.Open) Then
    //    'OdbcConnection1.ConnectionString = strLocalConnection
    //    'OdbcConnection2.ConnectionString = strLocalConnection
    //    ' ensure that a connection can be opened
    //    'Try
    //    '   OdbcConnection1.ConnectionTimeout = 2
    //    '  OdbcConnection1.Open()
    //    ' OdbcConnection2.ConnectionTimeout = 2
    //    'OdbcConnection2.Open()
    //    'Catch ex As Exception
    //    'MessageBox.Show("BeginOperations OdbcConnection1,2 OPEN Catch-22 rgk" + vbCrLf + "Stack: " + vbCrLf + ex.StackTrace)
    //    'MessageBox.Show("The database is missing. Please Contact the Administrator." + vbCrLf + "Msg: " + ex.Message)
    //    'MessageBox.Show("The database is missing. Please Contact the Administrator." + vbCrLf + "Connection String: " + strLocalConnection + vbCrLf + "msg: " + ex.Message)
    //    'End
    //    'End Try
    
    
    //    'OdbcConnection1.Close()
    //    'OdbcConnection2.Close()
    
    //    'OdbcConnection1.ConnectionTimeout = 15
    //    'OdbcConnection2.ConnectionTimeout = 15
    //    'End If
    
    
    //End Sub
    


    }
}
