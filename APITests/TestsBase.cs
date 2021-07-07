using RestSharp;

namespace APITests
{
    public class TestsBase
    {
        private IRestClient _client;

        protected IRestClient Client
        {
            get
            {
                if (_client is null)
                {
                    _client = new RestClient("http://dummy.restapiexample.com/api/v1/");
                }

                return _client;
            }
        }
    }
}
