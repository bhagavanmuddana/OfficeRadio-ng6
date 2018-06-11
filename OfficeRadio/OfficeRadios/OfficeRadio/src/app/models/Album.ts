export class Album {
  id: number;
  name: string;
  audios: Audio[];
  constructor(args: Album) {
    this.id = args.id;
    this.name = args.name;
    this.audios = args.audios;
  }
}
