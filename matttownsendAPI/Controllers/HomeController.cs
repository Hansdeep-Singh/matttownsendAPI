using matttownsendAPI.Helper;
using matttownsendAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace matttownsendAPI.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    [Produces("application/json")]
    public class HomeController : Controller
    {
        readonly IConfiguration configuration;
        public HomeController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        [HttpGet("Login")]
        public IActionResult Index()
        {
            return Ok("This");
        }
        [HttpPost("Login")]
        public IActionResult Login(LoginModel lm)
        {
            return Ok("Testing Login API");
        }
        [HttpPost("PreConsultForm")]
        public async Task<IActionResult> PreConsultForm(PreConsultForm pcf)
        {
            var apiKey = configuration["SendGrid:SecretKey"];
            var client = new SendGridClient(apiKey);
            var subject = "Pre-Consult Form";
            var from = new EmailAddress("hans.profession@gmail.com","Pre-consult Form");
            var to = new EmailAddress("matt.townsend.pt@gmail.com;hansdeep.singh@hotmail.com", "PreConsult Form");
            var plainTextContent = "";
            var htmlContent = HtmlBuilder.ModelToHtml(pcf);
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
            return Ok(response.IsSuccessStatusCode);
        }
    }
}
