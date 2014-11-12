using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleDriverOAuth_Example
{
    using System.Threading;

    using Google.Apis.Auth.OAuth2;
    using Google.Apis.Drive.v2;
    using Google.Apis.Util.Store;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserCredential credential;
            credential =
                GoogleWebAuthorizationBroker.AuthorizeAsync(
                    new ClientSecrets
                        {
                            ClientId = "1089632013491-1ap1gckvhagh3sjtvh705j6dag9j3ko2.apps.googleusercontent.com",
                            ClientSecret = "J_RyGmZshVR_1Tx6Yi3dUW84"
                        },
                    new[]
                        {
                            DriveService.Scope.Drive, 
                            DriveService.Scope.DriveFile
                        },
                    "wshuhao@gmail.com",
                    CancellationToken.None,
                    new FileDataStore("Drive.Auth.Store")).Result;
        }
    }
}
