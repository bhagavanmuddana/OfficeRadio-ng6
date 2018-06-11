import { Injectable } from "@angular/core";
import { Http } from "@angular/http";
import { Album } from '../models/Album';

@Injectable()
export class MovieService {

  constructor(private http: Http) {
  }

  GetallAlbums() {
    return this.http.get("api/Album/GetAlbums");
  }

  GetTopAlbums() {
    return this.http.get("api/Album/GetTopAlbums");
  }
}
