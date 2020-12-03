using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Linq;

namespace ReceptivitiAPI
{
    internal partial class SettingsForm_ReceptivitiAPI : Form
    {


        #region Get and Set Options

        public string APIkey { get; set; }
        public string APIsecretkey { get; set; }

       #endregion



        public SettingsForm_ReceptivitiAPI(string key, string secretkey)
        {
            InitializeComponent();

            keytextbox.Text = key;
            secretkeytextbox.Text = secretkey;


        }



       

        private void OKButton_Click(object sender, System.EventArgs e)
        {
            APIkey = keytextbox.Text;
            APIsecretkey = secretkeytextbox.Text;
            this.DialogResult = DialogResult.OK;
        }



        private void LoadFileButton_Click(object sender, System.EventArgs e)
        {

            using (var dialog = new OpenFileDialog())
            {
                dialog.Multiselect = false;
                dialog.CheckFileExists = true;
                dialog.CheckPathExists = true;
                dialog.ValidateNames = true;
                dialog.Title = "Please choose the CSV file that you would like to read";
                dialog.FileName = "access.csv";
                dialog.Filter = "Comma-Separated Values (CSV) File (*.csv)|*.csv";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                                        try
                    {
                        using (var stream = File.OpenRead(dialog.FileName))
                        using (var reader = new StreamReader(stream, encoding: Encoding.GetEncoding("utf-8")))
                        {
                            var data = CsvParser.ParseHeadAndTail(reader, ',', '"');

                            var header = data.Item1;
                            var lines = data.Item2;

                            string[] keys = lines.First().ToArray<string>();
                            keytextbox.Text = keys[0];
                            secretkeytextbox.Text = keys[1];
                            

                        }

                    }
                    catch
                    {
                        keytextbox.Text = "";
                        secretkeytextbox.Text = "";
                        MessageBox.Show("There was an error while trying to read your Receptiviti access key file. You may need to download a fresh copy from Receptiviti.", "Error reading file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                }
            }


        }



    }
}
