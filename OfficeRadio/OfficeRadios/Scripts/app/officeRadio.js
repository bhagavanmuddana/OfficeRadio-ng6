$(document).ready(function () {
    getAllAudio();
    getTopSongs();
    GetSongsByGenre();
    getAlbums();
    getTopAlbums();    
});

function getAllAudio() {
    $.ajax({
        method: 'GET',
        url: 'api/Audio/GetAllAudio',
        dataType: 'json',
        success: function (response) {
            console.log(response);
        },
        error: function (e) {
            console.log(e);
        }
    });
}

function getTopSongs() {
    $.ajax({
        method: 'GET',
        url: 'api/Audio/GetTopSongs',
        dataType: 'json',
        success: function (response) {
            console.log(response);
        },
        error: function () {
            alert('error');
        }
    });
}

function GetSongsByGenre() {
    var genre = "Party"
    $.ajax({
        method: 'GET',
        url: 'api/Audio/GetSongsByGenre/' + genre,
        dataType: 'json',
        data: { genre: genre },
        success: function (response) {
            console.log(response);
        },
        error: function () {
            alert('error');
        }
    });
}

function getAlbums() {
    $.ajax({
        method: 'GET',
        url: 'api/Album/GetAlbums',
        dataType: 'json',
        success: function (response) {
            console.log(response);
        },
        error: function () {
            alert('error');
        }
    });
}

function getTopAlbums() {
    $.ajax({
        method: 'GET',
        url: 'api/Album/GetTopAlbums',
        dataType: 'json',
        success: function (response) {
            console.log(response);
        },
        error: function () {
            alert('error');
        }
    });
}
