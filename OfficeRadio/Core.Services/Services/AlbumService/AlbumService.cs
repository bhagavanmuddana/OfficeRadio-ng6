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
    public class AlbumService : IAlbumService
    {
        public List<Audio> Audios { get; set; }
        public AlbumService()
        {
            this.Audios = new BaseAudioService().GetAudios();
        }

        public List<Album> GetAlbums()
        {
            int id = 1;
            List<Album> albums = new List<Album>();

            this.Audios.ForEach(audio =>
            {
                if (string.IsNullOrEmpty(audio.Album))
                {
                    audio.Album = "Default";
                }
            });

            var groupByAlbum = this.Audios.GroupBy(audio => audio.Album);
            foreach (var group in groupByAlbum)
            {
                albums.Add(new Album
                {
                    Audios = group.ToList(),
                    Name = group.Key,
                    Id = id++
                });
            }

            return albums;
        }

        public List<Album> GetTopAlbums()
        {
            List<Album> albums = this.GetAlbums();
            return albums.OrderBy(album => album.Audios.Sum(audio => audio.NoOfRequests)).Take(10).ToList();
        }
    }
}