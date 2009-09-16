using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Configuration.Provider;
using System.Configuration;
using System.IO;

using SubSonic;
using System.Xml;
using System.Text;
using System.Collections;
using BLL;
using DispatchAR;
using System.Xml.Linq;
using SubSonic.Repository;

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
        public static List<Route> RouteList             = new List<Route>();
        public static List<DRIVER> DriverList           = new List<DRIVER>();
        public static List<CurrentDayRoute>  CDRList    = new List<CurrentDayRoute>();
        public static List<CurrentDayPickup> CDPList    = new List<CurrentDayPickup>();
        public static List<Pickup>           PickupList = new List<Pickup>();
        public static List<DispatchAR.Posting>          PostingList= new List<DispatchAR.Posting>();
        public static List<ScreenDimension>  ScreenList = new List<ScreenDimension>();
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
            //File.Delete("scr.xml"); //' throws no exception if file does not exist
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
        /// <summary>
        /// one of these should go away
        /// move to BLL and springify
        /// this one does not use XMLReader (i hope)
        /// </summary>
        public static void LoadScreenListFromXml()
#if true        
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            XmlReader reader = default(XmlReader);
            settings.ConformanceLevel = ConformanceLevel.Fragment;
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;

            ////see Nunit test pp 99 
            ////this is what it used to be
            //// you have to test for scr.xml
            //// don't build for testing at the expense of needed functionality
            try
            {
                reader = XmlReader.Create(@"scr.xml");
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
                    case "Item":

                        var sd = new ScreenDimension();
                        var cvt = new System.ComponentModel.Int32Converter();

                        sd.WinTitle = reader.GetAttribute("Title");
                        sd.TopInt = (int)cvt.ConvertFromString(
                                reader.GetAttribute("Top"));
                        sd.LeftInt = (int)cvt.ConvertFromString(
                                reader.GetAttribute("Left"));
                        sd.WidthInt = (int)cvt.ConvertFromString(
                                reader.GetAttribute("Width"));
                        sd.HeightInt = (int)cvt.ConvertFromString(
                                reader.GetAttribute("Height"));

                        ScreenList.Add(sd);
                        continue;
                    default:
                        break;
                }
            }
            reader.Close();

        }
#else 
            // CANNOT GET q TO POPULATE have to use a reader and a switch stmnt ???
            XElement e = XElement.Load(@"scr.xml");
            var q = from y in e.Descendants()
                    where (y.FirstAttribute != null )
                    select new ScreenDimension( 
                            (string) y.Attribute("Title"),
                            (int)    y.Attribute("Top"),
                            (int)    y.Attribute("Left"),
                            (int)    y.Attribute("Height"),
                            (int)    y.Attribute("Width"));
            foreach (ScreenDimension sd in q)
            {
                ScreenList.Add(sd);
            }
        }
#endif 
        /// <summary>
        /// one of these should go away
        /// move to BLL and springify
        /// </summary>
        public static void LoadScreenListFromXml(Stream stream)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            XmlReader reader = default(XmlReader);
            settings.ConformanceLevel = ConformanceLevel.Fragment;
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;

            ////see Nunit test pp 99 
            ////this is what it used to be
            //// you have to test for scr.xml
            //// don't build for testing at the expense of needed functionality
            try
            {
                reader = XmlReader.Create(@"scr.xml");
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
                    case "Item":

                        var sd = new ScreenDimension();
                        var cvt = new System.ComponentModel.Int32Converter();

                        sd.WinTitle = reader.GetAttribute("Title");
                        sd.TopInt = (int)cvt.ConvertFromString(
                                reader.GetAttribute("Top"));
                        sd.LeftInt = (int)cvt.ConvertFromString(
                                reader.GetAttribute("Left"));
                        sd.WidthInt = (int)cvt.ConvertFromString(
                                reader.GetAttribute("Width"));
                        sd.HeightInt = (int)cvt.ConvertFromString(
                                reader.GetAttribute("Height"));

                        ScreenList.Add(sd);
                        continue;
                    default:
                        break;
                }
            }
            reader.Close();

        }
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
            try
            {
                var dvr =  (BLL.DriverBLL)WinClient.ApplicationContext["DriverBLL"];
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
                return false;
            }
            return true;
        }
        // to add many records, use SimpleRepository.AddMany<T>
    //    public void AddMany<T>(System.Collections.Generic.IEnumerable<T> items)
    //where T : new(), class
    //Member of SubSonic.Repository.SimpleRepository

        internal static List<CurrentDayRoute> GetCDRCollection()
        {
            var bll = (BLL.CurrentDay.CurrentDayRouteBLL)WinClient.ApplicationContext["CDRBLL"];
            CDRList.AddRange(bll.GetAll());
            return CDRList;
        }
        internal static List<DRIVER> GetDriverCollection()
        {
            var bll = (DriverBLL) WinClient.ApplicationContext["DriverBLL"];
            DriverList.AddRange(bll.GetAll());
            return DriverList;
        }
        internal static List<DispatchAR.Posting> GetPostingCollection()
        {
            var bll = (PostingBLL)WinClient.ApplicationContext["PostingBLL"];
            PostingList.AddRange(bll.GetAll());
            return PostingList;
        }
        internal static int GetCDRCount()
        {
            if (CDRList.Count == 0)
            {
                var cdrBLL = (BLL.CurrentDay.CurrentDayRouteBLL)WinClient.ApplicationContext["CDRBLL"];
                var tmplist= cdrBLL.GetAll();
                CDRList = tmplist.ToList<CurrentDayRoute>(); 
            }
            return CDRList.Count;
        }
        internal static int GetCDPCount()
        {
            if (CDPList.Count == 0)
            {
                var cdpBLL = (BLL.CurrentDay.CurrentDayPickupBLL)WinClient.ApplicationContext["CDPBLL"];
                var tmplist= cdpBLL.GetAll();
                CDPList = tmplist.ToList<CurrentDayPickup>(); 
            }
            return CDPList.Count;
        }

        internal static List<Pickup> GetPickupCollection()
        {
            var pu = (List<Pickup>)WinClient.ApplicationContext["PickupBLL"];
            return pu;
        }
        internal static List<Route> GetRouteCollection()
        {
            if (RouteList.Count == 0)
            {
                var routeBLL = (BLL.RouteBLL)WinClient.ApplicationContext["RouteBLL"];
                var tmplist = routeBLL.GetAll();
                RouteList = tmplist.ToList<Route>();
            }
            return RouteList;
        }
        internal static int GetPickupCount()
        {
            if (PickupList.Count == 0)
            {
                var cdpBLL = (BLL.PickupBLL)WinClient.ApplicationContext["PickupBLL"];
                var tmplist= cdpBLL.GetAll();
                PickupList = tmplist.ToList<Pickup>(); 
            }
            return PickupList.Count;
            
        }

        internal static int GetPostingCount()
        {
            if (PostingList.Count == 0)
            {
                var postingBLL = (PostingBLL)WinClient.ApplicationContext["PostingBLL"];
                var tmplist= postingBLL.GetAll();
                PostingList.AddRange(tmplist);
            }
            return PostingList.Count;

        }
        #endregion static methods
    }
}