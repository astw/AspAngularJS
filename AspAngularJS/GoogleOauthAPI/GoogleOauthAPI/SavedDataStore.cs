/* 
Copyright 2014 Daimto
Licensed under the Apache License, Version 2.0 (the "License"); 
you may not use this file except in compliance with the License. 
You may obtain a copy of the License at
    http://www.apache.org/licenses/LICENSE-2.0
Unless required by applicable law or agreed to in writing, software 
distributed under the License is distributed on an "AS IS" BASIS, 
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
See the License for the specific language governing permissions and 
limitations under the License. 
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Google.Apis.Util.Store;
using System.Threading.Tasks;
using Google.Apis.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GoogleOauthAPI
{
    public class StoredResponse
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public long? expires_in { get; set; }
        public string refresh_token { get; set; }
        public string Issued { get; set; }


        public StoredResponse(string pRefreshToken)
        {
            //this.access_token = pAccessToken;
            // this.token_type = pTokenType;
            //this.expires_in = pExpiresIn;
            this.refresh_token = pRefreshToken;
            //this.Issued = pIssued;
            this.Issued = DateTime.MinValue.ToString();
        }
        public StoredResponse()
        {
            this.Issued = DateTime.MinValue.ToString();
        }


    }

    /// <summary>
    /// Saved data store that implements <seealso cref="IDataStore"/>. 
    /// This Saved data store stores a StoredResponse object.
    /// </summary>
    class SavedDataStore : IDataStore
    {

        public StoredResponse _storedResponse { get; set; }

        /// <summary>
        /// Constructs Load perviously saved StoredResponse.
        /// </summary>
        /// <param name="StoredResponse">Stored response</param>

        public SavedDataStore(StoredResponse pResponse)
        {
            this._storedResponse = pResponse;
        }
        public SavedDataStore()
        {
            this._storedResponse = new StoredResponse();
        }
        /// <summary>
        /// Stores the given value. into storedResponse
        /// <see cref="FolderPath"/>.
        /// </summary>
        /// <typeparam name="T">The type to store in the data store</typeparam>
        /// <param name="key">The key</param>
        /// <param name="value">The value to store in the data store</param>
        public Task StoreAsync<T>(string key, T value)
        {

            var serialized = NewtonsoftJsonSerializer.Instance.Serialize(value);

            JObject jObject = JObject.Parse(serialized);

            // storing access token
            var test = jObject.SelectToken("access_token");
            if (test != null)
            {
                this._storedResponse.access_token = (string)test;
            }
            // storing token type
            test = jObject.SelectToken("token_type");
            if (test != null)
            {
                this._storedResponse.token_type = (string)test;
            }
            test = jObject.SelectToken("expires_in");
            if (test != null)
            {
                this._storedResponse.expires_in = (long?)test;
            }
            test = jObject.SelectToken("refresh_token");
            if (test != null)
            {
                this._storedResponse.refresh_token = (string)test;
            }
            test = jObject.SelectToken("Issued");
            if (test != null)
            {
                this._storedResponse.Issued = (string)test;
            }



            return TaskEx.Delay(0);
        }

        /// <summary>
        /// Deletes StoredResponse.
        /// </summary>
        /// <param name="key">The key to delete from the data store</param>
        public Task DeleteAsync<T>(string key)
        {
            this._storedResponse = new StoredResponse();

            return TaskEx.Delay(0);
        }

        /// <summary>
        /// Returns the stored value for_storedResponse      
        /// <typeparam name="T">The type to retrieve</typeparam>
        /// <param name="key">The key to retrieve from the data store</param>
        /// <returns>The stored object</returns>
        public Task<T> GetAsync<T>(string key)
        {
            TaskCompletionSource<T> tcs = new TaskCompletionSource<T>();
            try
            {

                string JsonData = Newtonsoft.Json.JsonConvert.SerializeObject(this._storedResponse);

                tcs.SetResult(Google.Apis.Json.NewtonsoftJsonSerializer.Instance.Deserialize<T>(JsonData));
            }
            catch (Exception ex)
            {
                tcs.SetException(ex);
            }

            return tcs.Task;
        }

        /// <summary>
        /// Clears all values in the data store. 
        /// </summary>
        public Task ClearAsync()
        {
            this._storedResponse = new StoredResponse();
            return TaskEx.Delay(0);
        }

        ///// <summary>Creates a unique stored key based on the key and the class type.</summary>
        ///// <param name="key">The object key</param>
        ///// <param name="t">The type to store or retrieve</param>
        //public static string GenerateStoredKey(string key, Type t)
        //{
        //    return string.Format("{0}-{1}", t.FullName, key);
        //}
    }
}
