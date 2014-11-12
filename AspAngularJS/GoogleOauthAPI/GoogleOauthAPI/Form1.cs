using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// Oauth2 usings
using Google.Apis;
using Google.Apis.Auth;
using Google.Apis.Auth.OAuth2;
// needed for FileStream
using System.IO;
// needed for scope
using Google.Apis.Drive.v2;
// needed for CancellationToken.None 
using System.Threading;
// needed for fileDataStore
using Google.Apis.Util.Store;
// needed for BaseClientService 
using Google.Apis.Services;
// needed for FileList
using Google.Apis.Drive.v2.Data;

///
/// Packages.
/// 1.pm> install-package google.apis -pre
/// 2.pm> install-package google.apis.drive.v2 -pre
/// Notes: Rember to set Client_secrets.json copy to output dir to copy if newer
///        Either Replace mine or copy yours in.
///        THIS WONT WORK WITH OUR YOUR COPY OF CLIENT SECRET.

/// if you see Error: invalid_client its becouse you havent set up the client_secret.json right

namespace GoogleOauthAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            btnLoadSavedData.Enabled = false;

        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            tbFileCount.Text = "0";
            UserCredential credential;

            //Rember to set Client_secrets.json copy to output dir to copy if newer


            using (var stream = new FileStream("client_secrets.json", FileMode.Open,
                                    FileAccess.Read))
            {
                GoogleWebAuthorizationBroker.Folder = "Tasks.Auth.Store";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                GoogleClientSecrets.Load(stream).Secrets,
                new[] { DriveService.Scope.Drive,
                DriveService.Scope.DriveFile },
                "user",
                CancellationToken.None,
                new FileDataStore("Drive.Auth.Store")).Result;
            }

            //notice that the directory name is the same name that you gave in the fileDataStore above.
            var fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Drive.Auth.Store\Google.Apis.Auth.OAuth2.Responses.TokenResponse-user");
            //Just for display
            textBox1.Text = System.IO.File.ReadAllText(fileName).Replace(",", ",\r\n");
            textBox4.Text = fileName;

            // saving the The inital data. You will probably want to save it to the database or something.
            tbAccessToken.Text = credential.Token.AccessToken;
            tbRefreshToken.Text = credential.Token.RefreshToken;
            tbTokenType.Text = credential.Token.TokenType;
            tbExpiresIn.Text = credential.Token.ExpiresInSeconds.ToString();
            tbIssued.Text = credential.Token.Issued.ToString();



            // This is how we connect to google drive.  Only puting this here so that you can see it is able to access
            // the google drive api.
            DriveService service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Drive API Sample",
            });
            FilesResource.ListRequest request = service.Files.List();
            FileList files = request.Execute();
            tbFileCount.Text = files.Items.Count().ToString();


            // FileDataStore handeles everthing for you. But you can see here
            // the values will change if you recieve a new access token becouse the one that 
            // was saved in the file is to old.
            
            // Just changing the color so you can see it was diffrent and you got a new one.
            // Run it again in an hour and you will see the change.
            if (tbAccessToken.Text != credential.Token.AccessToken) {

                tbAccessToken.BackColor = Color.Green;
            }
            tbAccessToken.Text = credential.Token.AccessToken;
            tbRefreshToken.Text = credential.Token.RefreshToken;
            tbTokenType.Text = credential.Token.TokenType;
            tbExpiresIn.Text = credential.Token.ExpiresInSeconds.ToString();
            tbIssued.Text = credential.Token.Issued.ToString();


        }

        /// <summary>
        /// If you dont have a refresh token for a user. A new browser window will pop up requesting permission.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStored_Click(object sender, EventArgs e)
        {
            tbFileCount.Text = "";
            // this is the first time the user has been in the system we dont have any auth for them.
            // Check: new SavedDataStore();
            UserCredential StoredCredential;
            using (var stream = new FileStream("client_secrets.json", FileMode.Open,
                                  FileAccess.Read))
            {
                GoogleWebAuthorizationBroker.Folder = "Tasks.Auth.Store";
                StoredCredential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                GoogleClientSecrets.Load(stream).Secrets,
                new[] { DriveService.Scope.Drive,
                DriveService.Scope.DriveFile },
                "user",
                CancellationToken.None,
                new SavedDataStore()).Result;
            }

            // saving the The inital data. You will probably want to save it to the database or something.
            // Note: The only thing you need to truly save is the refresh token.
            tbAccessToken.Text = StoredCredential.Token.AccessToken;
            tbRefreshToken.Text = StoredCredential.Token.RefreshToken;
            tbTokenType.Text = StoredCredential.Token.TokenType;
            tbExpiresIn.Text = StoredCredential.Token.ExpiresInSeconds.ToString();
            tbIssued.Text = StoredCredential.Token.Issued.ToString();
            textBox1.Visible = false;
            textBox4.Visible = false;
            label3.Visible = false;
            label7.Visible = false;
            btnLoadSavedData.Enabled = true;


            // This is how we connect to google drive.  Only puting this here so that you can see it is able to access
            // the google drive api.
            DriveService service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = StoredCredential,
                ApplicationName = "Drive API Sample",
            });
            FilesResource.ListRequest request = service.Files.List();
            FileList files = request.Execute();
            tbFileCount.Text = files.Items.Count().ToString();


        }

        /// <summary>
        /// This time you do have a refreshToken for the user stored in tbrefreshToken.  We will use that to request there data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadSavedData_Click(object sender, EventArgs e)
        {
            UserCredential StoredCredential;
            tbFileCount.Text = "0";

            //Now we load our saved refreshToken.
            StoredResponse myStoredResponse = new StoredResponse(tbRefreshToken.Text);

            // Now we pass a SavedDatastore with our StoredResponse.
            using (var stream = new FileStream("client_secrets.json", FileMode.Open,
                                   FileAccess.Read))
            {
                GoogleWebAuthorizationBroker.Folder = "Tasks.Auth.Store";
                StoredCredential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                GoogleClientSecrets.Load(stream).Secrets,
                new[] { DriveService.Scope.Drive,
                DriveService.Scope.DriveFile },
                "user",
                CancellationToken.None,
                new SavedDataStore(myStoredResponse)).Result;
            }

            // If you check StoredCredentail right now the values are what we passed to it.
            tbAccessToken.Text = StoredCredential.Token.AccessToken;
            tbRefreshToken.Text = StoredCredential.Token.RefreshToken;
            tbTokenType.Text = StoredCredential.Token.TokenType;
            tbExpiresIn.Text = StoredCredential.Token.ExpiresInSeconds.ToString();
            tbIssued.Text = StoredCredential.Token.Issued.ToString();

            // This is how we connect to google drive.  Only puting this here so that you can see it is able to access
            // the google drive api.
            DriveService service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = StoredCredential,
                ApplicationName = "Drive API Sample",
            });
            FilesResource.ListRequest request = service.Files.List();
            FileList files = request.Execute();
            tbFileCount.Text = files.Items.Count().ToString();

            // after you have made a request StoredCredentail will be filled out it will get a new access token 
            // for you based upon the refreshtoken you sent
            // You dont need to resave any of this.  The refresh token you already have is enough.
            tbAccessToken.Text = StoredCredential.Token.AccessToken; 
            tbRefreshToken.Text = StoredCredential.Token.RefreshToken;
            tbTokenType.Text = StoredCredential.Token.TokenType;
            tbExpiresIn.Text = StoredCredential.Token.ExpiresInSeconds.ToString();
            tbIssued.Text = StoredCredential.Token.Issued.ToString();

        }





    }
}
