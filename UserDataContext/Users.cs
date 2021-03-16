using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using UserDataContext.ViewModels;
using UserModels;

namespace UserDataContext
{
    public class Users
    {
        public static Users Instance = new Users();
        private HttpClient httpClient;
        private Users()
        {
            httpClient = new HttpClient { BaseAddress = new Uri(Utilities.ReadConfig("APIURI")) };
            httpClient.DefaultRequestHeaders.Add("apitoken", Utilities.ReadConfig("APIToken"));
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<bool> AddAsync(User Model)
        {
            // Check if e-mail is unique
            var existing = await GetAllAsync(vm: new UserQueryVM { email = Model.Email });
            if (!existing.Any())
            {
                var response = await httpClient.PostAsJsonAsync("Users", Model);
                return response.IsSuccessStatusCode;
            }
            else return false;
        }

        public async Task<IEnumerable<User>> GetAllAsync(int? pageNumber = 0, UserQueryVM vm = null)
        {
            var response = await httpClient.GetAsync(ConstructQuery(pageNumber, vm));
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsAsync<UsersQueryResultVM>();
                return result.Data.ToArray();
            }
            return null;
        }
        public async Task<User> GetUserAsync(int Id) => (await GetAllAsync(vm: new UserQueryVM { id = Id }))?.FirstOrDefault();

        private string ConstructQuery(int? pageNumber = 0, UserQueryVM vm = null)
        {
            var queryParameters = new List<string>(6);

            if (pageNumber.HasValue) queryParameters.Add($"page={pageNumber}");
            if ((vm?.id).HasValue) queryParameters.Add($"id={vm.id.Value}");
             if (!string.IsNullOrEmpty(vm?.name)) queryParameters.Add($"name={vm.name}");
            if (!string.IsNullOrEmpty(vm?.email)) queryParameters.Add($"email={vm.email}");
            if (!string.IsNullOrEmpty(vm?.gender)) queryParameters.Add($"gender={vm.gender}");
            if (!string.IsNullOrEmpty(vm?.status)) queryParameters.Add($"status={vm.status}");

            return "users" +
                (pageNumber.HasValue || vm.HasParameterFilled ? "?" : string.Empty) +
                string.Join('&', queryParameters.ToArray());
        }
    }
}
