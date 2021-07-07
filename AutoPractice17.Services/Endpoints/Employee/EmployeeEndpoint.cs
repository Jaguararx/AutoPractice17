using RestSharp;

namespace AutoPractice17.Services.Endpoints.Employee
{
    public static class EmployeeEndpoint
    {
        public static RestRequest GetEmployee()
        {
            return new RestRequest("employees", Method.GET);
        }
    }
}
