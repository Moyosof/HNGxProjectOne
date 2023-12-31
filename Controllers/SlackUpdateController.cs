﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using System.Xml;

namespace HNGx.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlackUpdateController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetInformation([FromQuery] string slackName, string track)
        {
            try
            {
                var currentDayOfWeek = DateTime.UtcNow.DayOfWeek.ToString();

                var utcNow = DateTime.UtcNow;
                var isValidUtc = Math.Abs((utcNow - DateTime.UtcNow).TotalHours) <= 2;

                if (!isValidUtc)
                {
                    return BadRequest("UTC time is not within +/-2 hours.");
                }

                var assembly = System.Reflection.Assembly.GetExecutingAssembly();
                var codeFileUrl = "https://https://github.com/Moyosof/HNGxProjectOne/blob/main/Controllers/SlackUpdateController.cs";
                var sourceCodeUrl = "https://github.com/Moyosof/HNGxProjectOne";

                var response = new
                {
                    SlackName = slackName,
                    DayOfWeek = currentDayOfWeek,
                    UTCTime = utcNow,
                    Track = track,
                    CodeFileUrl = codeFileUrl,
                    SourceCodeUrl = sourceCodeUrl
                };

                return Ok(JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented));

            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }

    
}
