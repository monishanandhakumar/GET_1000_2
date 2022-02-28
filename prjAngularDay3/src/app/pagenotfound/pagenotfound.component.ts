import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-pagenotfound',
  template: '<p> 404 : Page Not found </p> <h1> Hi all </h1>',
  styles:  ['p { font-size: 30px;color:red },']
})
export class PagenotfoundComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}
