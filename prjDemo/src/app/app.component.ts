import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  template: `<h1>Parent Component</h1>  {{name}} <hr> 
   <h1>Child Component</h1> 
   <app-forms (datafromchild)="datafromchild($event)"></app-forms>`,
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'prjDemo';

   name:string;
  datafromchild(info:any)
  {
    this.name=info;
  }
}
