using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebAPI.Controllers.Models;
using WebAPI.Controllers.Services;

namespace WebAPI.Controllers
{
    [Route("api/conferenceList")]
    [ApiController]
    public class ConferenceController : ControllerBase
    {
        private readonly IConferenceListService _conferenceListService;

        public ConferenceController(IConferenceListService conferenceListService)
        {
            _conferenceListService = conferenceListService;
        }

        [HttpGet]
        public IActionResult GetConferenceList()
        {
            var result = _conferenceListService.GetSessionsFromConferenceList();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddSessionToConferenceList([FromBody] ConferenceListModel conferenceList)
        {
            _conferenceListService.AddSessionToConferenceList(conferenceList);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteSessionFromConferenceList([FromBody] ConferenceListModel conferenceList)
        {
            _conferenceListService.RemoveSession(conferenceList.SessName);
            return Ok();
        }

    }
}