using System;
using System.Collections.Generic;
using Core.Models;

namespace Core.Services.Services
{
    public interface IAlbumService
    {
        List<Album> GetAlbums();
        List<Album> GetTopAlbums();
    }
}