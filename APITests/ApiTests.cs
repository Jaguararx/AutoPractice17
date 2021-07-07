using AutoPractice17.Services.Endpoints.Employee;
using AutoPractice17.Services.Extentions;
using AutoPractice17.Services.Models;
using NUnit.Framework;

namespace APITests
{
    public class ApiTests : TestsBase
    {
        [Test]
        [Category("API")]
        [Category("Employee")]
        [Category("Smoke")]
        public void GetEmployeeTest1()
        {
            var response = Client.Execute(EmployeeEndpoint.GetEmployee()).EnsureSuccess().As<Response>();
            Assert.That(response.Data.Count, Is.EqualTo(24));
        }
    }
}
