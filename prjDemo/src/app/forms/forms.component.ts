import { Component, OnInit, Output ,EventEmitter} from '@angular/core';

@Component({
  selector: 'app-forms',
  template: `<div> <form #myform="ngForm"> <input type="text" id="uname" name="username" [(ngModel)]="username" required/>  
  <input type="submit"  value="submit" (click)="getdata()" [disabled]="myform.invaild"/> </form>   </div>`,
  styles: ['']
})
export class FormsComponent implements OnInit {

  username:string;
  constructor() { }
  @Output() datafromchild :EventEmitter<string> =new EventEmitter();
  ngOnInit() {
  }
   
  getdata()
  {
     this.datafromchild.emit(this.username);
  }
}
