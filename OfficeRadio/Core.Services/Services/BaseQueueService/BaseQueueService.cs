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
    public class BaseQueueService
    {
        public List<int> GetQueueSongs()
        {
            return JsonConvert.DeserializeObject<List<int>>(File.ReadAllText(@"C:\New folder\queued.json"));
        }
    }
}