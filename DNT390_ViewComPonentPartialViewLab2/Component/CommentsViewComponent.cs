using DNT390_ViewComPonentPartialViewLab2.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;

namespace DNT390_ViewComPonentPartialViewLab2.Component
{
    public class CommentsViewComponent:ViewComponent
    {
        
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
           List<CommentViewModel> comments = new List<CommentViewModel>();
            HttpClient webClient = new HttpClient();
            webClient.BaseAddress =  new Uri(" https://jsonplaceholder.typicode.com/");
            HttpResponseMessage response = await webClient.GetAsync("/comments/?id=" + id);

            string apiresponse= await response.Content.ReadAsStringAsync();
            comments =JsonConvert.DeserializeObject<List<CommentViewModel>>(apiresponse);
            return View("~/Views/Components/_Comments.cshtml", comments);
        }
    }
}
