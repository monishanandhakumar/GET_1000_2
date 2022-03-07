import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'prjAngularday4';
  username:string='I am data from parent component : SAI -Parent ';

  //receiving from child
  mychildname:any;
   
  receivechilddata(info)
  {
    this.mychildname=info;
    console.log(info);
  }

  myhobby:string="";
  receivehobby(hobbyname:string)
  {
     console.log(hobbyname);
     this.myhobby=hobbyname;
  }
}
