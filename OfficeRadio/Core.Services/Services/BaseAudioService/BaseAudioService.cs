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
    public class BaseAudioService
    {
        public List<Audio> GetAudios()
        {
            return JsonConvert.DeserializeObject<List<Audio>>(File.ReadAllText(@"C:\New folder\latest-data.json"));
        }
    }
}