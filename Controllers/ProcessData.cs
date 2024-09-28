using Microsoft.AspNetCore.Mvc;


namespace WebHookExampleB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProcessData : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> processingData([FromBody] TransactionRequest request) {
            HttpClient client = new HttpClient();

            //Thread.Sleep(1000);

            var response = new TransactionResponse
            {
                Date = DateTime.Now,
                State = "success"
            };

            var json = JsonContent.Create(response)

            var result = await client.PostAsync(request.CallBackURL,json);

            Console.WriteLine("Transacción -------");
            Console.WriteLine(result.StatusCode);
            return Ok(result);
        }
    }
}
