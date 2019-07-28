using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Controllers.Models;

namespace WebAPI.Controllers.Services
{
    public class ConferenceListService : IConferenceListService
    {
        private readonly Dictionary<string, int> _conferenceListStorage = new Dictionary<string, int>();

        public Dictionary<string, int> GetSessionsFromConferenceList()
        {
            return _conferenceListStorage;
        }

        public void AddSessionToConferenceList(ConferenceListModel conferenceList)
        {
            _conferenceListStorage.Add(conferenceList.SessName, conferenceList.SessDuration);
        }

        public void RemoveSession(string conferenceListName)
        {
            _conferenceListStorage.Remove(conferenceListName);
        }

    }
}
