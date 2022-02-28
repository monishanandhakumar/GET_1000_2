import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor() { }
  username:string;
  pwd:string;

  ngOnInit() {
  }

  dologin(lform:NgForm)
  {
    console.log(this.username);
    console.log(this.pwd);
    console.log(lform.value);
  }
}
