using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Dynamic;
using System.Net;
using System.Collections;
using System.Data.Common;
using Core.Models;
using Newtonsoft.Json;
using System.IO;

namespace Core.Services.Services
{
    public class AudioService : IAudioService
    {
        public List<Audio> Audios { get; set; }

        public AudioService()
        {
            this.Audios = new BaseAudioService().GetAudios();
        }
        
        public IEnumerable<Audio> GetAllAudio()
        {
            return this.Audios;
        }

        public Audio GetAudio(int id)
        {
            return this.Audios.FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<Audio> GetTopSongs()
        {
            List<Audio> audios = new List<Audio>();
            return this.Audios.OrderBy(audio => audio.NoOfRequests).Take(100).ToList();
        }

        public List<Audio> GetSongsByGenre(string genreType)
        {
            List<Audio> audio = new List<Audio>();
            return this.Audios.FindAll(audioo => audioo.Genre == genreType).ToList();
        }        
    }
}