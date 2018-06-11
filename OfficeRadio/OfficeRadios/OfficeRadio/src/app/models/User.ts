export class Queue {
  id: number;
  regEmpNo: string;
  name: string;
  password: string;
  constructor(args: Queue) {
    this.id = args.id;
    this.regEmpNo = args.regEmpNo;
    this.name = args.name;
    this.password = args.password;
  }
}
