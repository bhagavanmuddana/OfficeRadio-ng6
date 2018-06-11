using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Core.Models;
using Core.Services.Services;
using Newtonsoft.Json;

namespace OfficeRadio.Controllers
{
    public class AudioController : ApiController
    {
        public AudioService AudioService { get; set; }

        public AudioController()
        {
            this.AudioService = new AudioService();
        }
        // GET api/audios
        [HttpGet]
        public IEnumerable<Audio> GetAllAudio()
        {
            return AudioService.GetAllAudio();
        }

        // GET api/values/id
        public Audio GetAudio(int id)
        {
            return AudioService.GetAudio(id);
        }

        [HttpGet]
        public IEnumerable<Audio> GetTopSongs()
        {
            return AudioService.GetTopSongs();
        }

        [HttpGet]
        public List<Audio> GetSongsByGenre(string genre)
        {
            return AudioService.GetSongsByGenre(genre);
        }
    }
}
