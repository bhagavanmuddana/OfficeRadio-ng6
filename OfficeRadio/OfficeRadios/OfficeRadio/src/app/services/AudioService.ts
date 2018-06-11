import { Injectable } from "@angular/core";
import { Http } from "@angular/http";
import { Album } from '../models/Album';

@Injectable()
export class MovieService {

  constructor(private http: Http) {
  }

  GetAllAudio() {
    return this.http.get("api/Audio/GetAllAudio");
  }

  GetTopSongs() {
    return this.http.get("api/Audio/GetTopSongs");
  }

  GetSongsByGenre(genre: string) {
    return this.http.get("api/Audio/GetSongsByGenre/" + genre);
  }
}
