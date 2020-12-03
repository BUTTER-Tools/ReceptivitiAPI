using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using PluginContracts;
using OutputHelperLib;
using RestSharp;
using QuickType;

namespace ReceptivitiAPI
{
    public partial class ReceptivitiAPI : Plugin
    {


        public string[] InputType { get; } = { "String" };
        public string OutputType { get; } = "OutputArray";

        public Dictionary<int, string> OutputHeaderData { get; set; } = CreateHeader();
        public bool InheritHeader { get; } = false;

        #region Plugin Details and Info

        public string PluginName { get; } = "Receptiviti API";
        public string PluginType { get; } = "Web/API";
        public string PluginVersion { get; } = "1.0.2";
        public string PluginAuthor { get; } = "Ryan L. Boyd (ryan@ryanboyd.io)";
        public string PluginDescription { get; } = "Processes text through the Receptiviti web API (v3). Note that, at the time of this writing (2019-03-24), the Receptiviti API does not allow requests > 10,000 words long. As such, if you know that some of your texts are long (or, if you are not sure), you should first process your texts through the " + 
            "\"Segment Text into Chunks\" plugin with \"Desired Segment Size\" option set to something *just under* 10,000 (e.g., 9950, to be safe). Otherwise, texts longer than 10,000 words will not be processed by the API (which may be desirable if you need to conserve your API requests)." + Environment.NewLine + Environment.NewLine +
            "Note that the Receptiviti API is *not* free to use; all charges resulting from your use of the Receptiviti API are your responsiblility. Note also that this plugin is under development and, as such, it may not work perfectly. Nevertheless, you are still responsible for all charges incurred as a result of your use of the Receptiviti API." + Environment.NewLine + Environment.NewLine +
            "To use this plugin, you must have an active account with Receptiviti, and you must download your credential file by clicking on the \"Generate API Key\" link on the following page:" + Environment.NewLine + Environment.NewLine +
            "https://api-v3.receptiviti.com/" + Environment.NewLine + Environment.NewLine;
        public bool TopLevel { get; } = false;
        public string PluginTutorial { get; } = "Coming Soon";

        private string APIkey { get; set; } = "";
        private string APIsecret { get; set; } = "";
        private static string baseurl { get; } = "https://api-v3.receptiviti.com/v3/api/content";

        private RestClient client = new RestClient();




        public Icon GetPluginIcon
        {
            get
            {
                return Properties.Resources.icon;
            }
        }

        #endregion



        public void ChangeSettings()
        {
            using (var form = new SettingsForm_ReceptivitiAPI(APIkey, APIsecret))
            {


                form.Icon = Properties.Resources.icon;
                form.Text = PluginName;

                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    APIkey = form.APIkey;
                    APIsecret = form.APIsecretkey;
                }
            }

        }





        public Payload RunPlugin(Payload Input)
        {



            Payload pData = new Payload();
            pData.FileID = Input.FileID;
            pData.SegmentID = Input.SegmentID;


            for (int i = 0; i < Input.StringList.Count; i++)
            {
                //ReceptivitiPayload data = new ReceptivitiPayload(Input.StringList[i]);
                string data = Input.StringList[i];

                if (data.Trim().Length > 0) { 
                    IRestResponse resp = PostData(data);

                    if (resp.IsSuccessful)
                    {

                        ReceptivitiOutput Output = ReceptivitiOutput.FromJson(resp.Content);
                        string[] outputData = FlattenOutput(Output);
                        pData.StringArrayList.Add(outputData);
                        pData.SegmentNumber.Add(Input.SegmentNumber[i]);

                    }
                    else
                    {
                        string[] outputData = new string[231];
                        outputData[218] = resp.Content;
                        pData.StringArrayList.Add(outputData);
                        pData.SegmentNumber.Add(Input.SegmentNumber[i]);
                    }

                    
                }
            }

            return (pData);

        }



        public void Initialize()
        {

            //https://docs.microsoft.com/en-us/aspnet/web-api/overview/advanced/calling-a-web-api-from-a-net-client
            //https://stackoverflow.com/questions/50818608/python-code-to-c-sharp-net-for-http-post-to-api
            //https://stackoverflow.com/a/17459045
            client = new RestClient(baseurl);
            
        }



        public bool InspectSettings()
        {

            if (string.IsNullOrEmpty(APIkey) || string.IsNullOrEmpty(APIsecret))
            {
                return false;
            }


            client = new RestClient("https://api-v3.receptiviti.com/v3/api/ping");
            RestRequest req = new RestRequest(Method.GET);
            req.AddHeader("accept", "application / json");
            req.AddHeader("X-API-KEY", APIkey);
            req.AddHeader("X-API-SECRET-KEY", APIsecret);
            IRestResponse resp = client.Execute(req);

            if (resp.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                MessageBox.Show("Your authorization credentials for the Receptiviti API do not appear to be valid.", "401: Unauthorize", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (resp.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("There appears to be a problem connecting to the Receptiviti API. Upon trying to ping the API with your credentials, you received the following error:" + Environment.NewLine + Environment.NewLine +
                    resp.StatusDescription, "Receptiviti API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



                return true;

        }



        public Payload FinishUp(Payload Input)
        {
            return (Input);
        }



        private IRestResponse PostData(string data)
        {

            RestRequest req = new RestRequest(Method.POST);
            req.RequestFormat = DataFormat.Json;
            req.AddHeader("accept", "application / json");
            req.AddHeader("X-API-KEY", APIkey);
            req.AddHeader("X-API-SECRET-KEY", APIsecret);
            req.AddJsonBody(new {
                content_source = 0,
                language_content = data });


            IRestResponse resp = client.Execute(req);

            return (resp);
        }






        #region Import/Export Settings
        public void ImportSettings(Dictionary<string, string> SettingsDict)
        {
            APIkey = SettingsDict["APIkey"];
            APIsecret = SettingsDict["APIsecret"];
        }

        public Dictionary<string, string> ExportSettings(bool suppressWarnings)
        {
            Dictionary<string, string> SettingsDict = new Dictionary<string, string>();
            SettingsDict.Add("APIkey", APIkey);
            SettingsDict.Add("APIsecret", APIsecret);
            return (SettingsDict);
        }
        #endregion




    }
}
