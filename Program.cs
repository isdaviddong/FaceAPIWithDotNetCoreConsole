using System;
using System.Net.Http;

namespace faceapi
{
    class Program
    {
        static string key = "________your____key_______";
        static void Main(string[] args)
        {
            var json = "{\"url\":\"https://img-s-msn-com.akamaized.net/tenant/amp/entityid/BB14Qb6l.img?h=523&w=799&m=6&q=60&o=f&l=f&x=549&y=195\"}";
            System.Net.Http.HttpContent content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", key);
            var ret = client.PostAsync(
                "https://testfaceapi2020.cognitiveservices.azure.com/face/v1.0/detect?returnFaceAttributes=age,gender"
            , content).Result;

            Console.WriteLine(ret.Content.ReadAsStringAsync().Result);
        }
    }
}
