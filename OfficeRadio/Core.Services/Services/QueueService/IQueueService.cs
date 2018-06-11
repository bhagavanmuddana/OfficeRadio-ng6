using System;
using System.Collections.Generic;
using Core.Models;

namespace Core.Services.Services
{
    public interface IQueueService
    {
        List<Audio> GetQueueSongs();
        void AddSongToQueue(int audioId);
    }
}