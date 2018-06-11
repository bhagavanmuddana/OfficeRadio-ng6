using Core.Models;
using Core.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OfficeRadio.Controllers
{
    public class AlbumController : ApiController
    {
        public AlbumService AlbumService { get; set; }

        public AlbumController()
        {
            this.AlbumService = new AlbumService();
        }

        [HttpGet]
        public List<Album> GetAlbums()
        {
            return AlbumService.GetAlbums();
        }

        [HttpGet]
        public List<Album> GetTopAlbums()
        {
            return AlbumService.GetTopAlbums();
        }
    }
}
