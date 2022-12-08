using System.Text;
using MagicVilla_Utility;
using MagicVilla_Web.Models;
using MagicVilla_Web.Services.IServices;
using Newtonsoft.Json;


//Make API request and Fetch the response
namespace MagicVilla_Web.Services
{
    public class BaseService : IBaseService
    {

        public APIResponse responseModel { get; set; } //Response model
        public IHttpClientFactory httpClient { get; set; } //Actually call API. Dependency Injection

        
        public BaseService(IHttpClientFactory httpClient)
        {
            this.responseModel = new();
            this.httpClient = httpClient;
        }

        //Receive the response
        public async Task<T> SendAsync<T>(APIRequest apiRequest)
        {
            try
            {
                var client = httpClient.CreateClient("MagicAPI"); //path the name
                HttpRequestMessage message = new HttpRequestMessage(); // call http message
                message.Headers.Add("Accecpt", "application/json"); //Add Headers
                message.RequestUri = new Uri(apiRequest.Url);

                if (apiRequest.Data != null)
                {
                    //serialize object, API request
                    message.Content = new StringContent(JsonConvert.SerializeObject(apiRequest.Data),
                        Encoding.UTF8, "application/json");
                }
                switch (apiRequest.ApiType)
                {
                    case SD.ApiType.POST:
                        message.Method = HttpMethod.Post;
                        break;

                    case SD.ApiType.PUT:
                        message.Method = HttpMethod.Put;
                        break;

                    case SD.ApiType.DELETE:
                        message.Method = HttpMethod.Delete;
                        break;

                    default:
                        message.Method = HttpMethod.Get;
                        break;

                }

                //reqeust configure
                HttpResponseMessage apiResponse = null;

                //call the API end point
                apiResponse = await client.SendAsync(message);

                //extract the API conteent
                var apiContent = await apiResponse.Content.ReadAsStringAsync();

                //Desiallize object
                var APIResponse = JsonConvert.DeserializeObject<T>(apiContent);

                //call the variable as API response
                return APIResponse;
            }
            catch(Exception e)
            {
                var dto = new APIResponse
                {
                    ErrorMessages = new List<string> { Convert.ToString(e.Message) },
                    IsSuccess = false
                };
                var res = JsonConvert.SerializeObject(dto);
                var APIResponse = JsonConvert.DeserializeObject<T>(res);
                return APIResponse;
            }
        }
    }
}

