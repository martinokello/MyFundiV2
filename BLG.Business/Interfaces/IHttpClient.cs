using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

//Interface contract to create calls to other Apis using HTTPClient
namespace BLG.Business.Interfaces
{
    public interface IHttpClient
    {
        HttpClient HttpRequestClient { get; set; }
    }
}
