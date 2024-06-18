using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace HDBPredict
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked)
                panelPredict.Visible = true;
            else
                panelPredict.Visible = false;
        }

        private async void btnPredict_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                var scoreRequest = new
                {
                    Inputs = new Dictionary<string, List<Dictionary<string, string>>>()
                    {
                        {
                            "input1", new List<Dictionary<string, string>>()
                            {
                                new Dictionary<string, string>()
                                {
                                    {"town", txtTown.Text},
                                    {"flat_type", txtFlatType.Text},
                                    {"storey_range", txtStoreyRange.Text},
                                    {"floor_area_sqm", txtFloorArea.Text},
                                    {"flat_model", txtFlatModel.Text},
                                    {"lease_commence_date", txtLeaseCommence.Text},
                                    {"resale_price", "0"}
                                }
                            }
                        },
                    },
                    GlobalParameters = new Dictionary<string, string>()
                    { }
                };
                const string apiKey = "";
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
                client.BaseAddress = new
                    Uri("https://ussouthcentral.services.azureml.net/workspaces/414f08c7e73e4e93899448a0164041ef/services/4e9fa8a045d742b58608624d230c05e5/execute?api-version=2.0&format=swagger");
                HttpResponseMessage response = await client.PostAsJsonAsync("", scoreRequest);
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    JObject data = (JObject)JsonConvert.DeserializeObject(result);
                    string strTemp = data["Results"]["output1"][0]["Scored Labels"].ToString(); lblPredict.Text = "Predicted Price: " + strTemp;
                    Console.WriteLine("Result: {0}", result);
                }
                else
                {
                    lblPredict.Text = "Predicted Price: Error";
                    Console.WriteLine(response.Headers.ToString());

                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseContent);
                }

            }
        }

    }
}

