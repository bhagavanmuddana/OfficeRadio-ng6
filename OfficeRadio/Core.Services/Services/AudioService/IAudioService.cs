using System;
using System.Collections.Generic;
using Core.Models;

namespace Core.Services.Services
{
    public interface IAudioService
    {
        IEnumerable<Audio> GetAllAudio();
        Audio GetAudio(int id);
        IEnumerable<Audio> GetTopSongs();
        List<Audio> GetSongsByGenre(string genreType);
    }
}