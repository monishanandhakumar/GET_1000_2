import { Component, OnInit } from '@angular/core';
import { AbstractControl } from '@angular/forms';

@Component({
  selector: 'app-reactiveform',
  templateUrl: './reactiveform.component.html',
  styleUrls: ['./reactiveform.component.css']
})
export class ReactiveformComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

   static charonly(control:AbstractControl)
   {
     let pattern=/^[a-zA-Z]+$/;
     if(!control.value.match(pattern))
     {
       return {'cusvalidation':true}
     }
      return null;
   }
}
