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
    public class QueueService : IQueueService
    {
        public List<int> QueuedSongs { get; set; }
        public QueueService()
        {
            this.QueuedSongs = new BaseQueueService().GetQueueSongs();
        }

        public List<Audio> GetQueueSongs()
        {
            return new List<Audio>();
        }

        public void AddSongToQueue(int audioId)
        {
            this.QueuedSongs.Add(audioId);
        }

        public List<int> RefreshQueue()
        {
            return this.QueuedSongs;
        }
    }
}