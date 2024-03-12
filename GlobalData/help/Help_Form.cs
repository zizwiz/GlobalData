using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using assembly_info;
using GlobalData;
using GlobalData.Properties;


namespace help_about
{
    public partial class Help_Form : Form
    {
        public Help_Form()
        {
            InitializeComponent();
        }

        private void Help_Form_Load(object sender, EventArgs e)
        {
            this.CenterToParent();



            byte[] MHT = Resources.Help1;

            MemoryStream ms = new MemoryStream(MHT);

            //Create PDF File From Binary of resources folders 
            FileStream f = new FileStream("Help.mht", FileMode.OpenOrCreate);

            //Write Bytes into Our Created helpFile.mht
            ms.WriteTo(f);
            f.Close();
            ms.Close();

            wbrHelp.Navigate(Path.GetFullPath(Path.Combine(Application.StartupPath, ".\\Help.mht")));
           
            // Get the AssemblyInfo class.
            AssemblyInfo info = new AssemblyInfo();


            // Display the values.
            Text = "Help About : v" + Assembly.GetExecutingAssembly().GetName().Version; //info.Title; //put in title.
            descriptionTextBox.Text = info.Description;
            companyTextBox.Text = info.Company;
            productTextBox.Text = info.Product;
            copyrightTextBox.Text = info.Copyright;
            trademarkTextBox.Text = info.Trademark;
            assemblyVersionTextBox.Text = info.AssemblyVersion;
            fileVersionTextBox.Text = info.FileVersion;
            guidTextBox.Text = info.Guid;
            neutralLanguageTextBox.Text = info.NeutralLanguage;
            comVisibleTextBox.Text = info.IsComVisible.ToString();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            wbrHelp.Dispose();
            Dispose();
            Close();
        }

        private void wbrHelp_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (IsHorizontalScrollbarPresent)
            {
                wbrHelp.Size = new Size(wbrHelp.Document.Body.ScrollRectangle.Width, wbrHelp.Document.Body.ScrollRectangle.Height);
                Form1.ActiveForm.Size = new Size(wbrHelp.Document.Body.ScrollRectangle.Width, wbrHelp.Document.Body.ScrollRectangle.Height);
            }
        }
        public bool IsHorizontalScrollbarPresent
        {
            get
            {
                var widthofScrollableArea = wbrHelp.Document.Body.ScrollRectangle.Width;
                var widthofControl = wbrHelp.Document.Window.Size.Width;

                return widthofScrollableArea > widthofControl;
            }
        }

       
    }
}
