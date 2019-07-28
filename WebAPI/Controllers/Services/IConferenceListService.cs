using System.Collections.Generic;
using WebAPI.Controllers.Models;

namespace WebAPI.Controllers.Services
{
    public interface IConferenceListService
    {
        Dictionary<string, int> GetSessionsFromConferenceList();
        void AddSessionToConferenceList(ConferenceListModel conferenceList);
        void RemoveSession(string sessName);
    }
}