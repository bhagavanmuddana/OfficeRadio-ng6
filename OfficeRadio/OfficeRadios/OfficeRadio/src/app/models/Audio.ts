
export class Audio {
  id: number;
  artist: string;
  album: string;
  duration: string;
  genre: string;
  imageUrl: string;
  name: string;
  noOfRequests: number;
  emotions: number[];
  path: string;
  constructor(args: Audio) {
    this.id = args.id;
    this.artist = args.artist;
    this.album = args.album;
    this.duration = args.duration;
    this.genre = args.genre;
    this.imageUrl = args.imageUrl;
    this.name = args.name;
    this.noOfRequests = args.noOfRequests;
    this.emotions = args.emotions;
    this.path = args.path;
  }
}
