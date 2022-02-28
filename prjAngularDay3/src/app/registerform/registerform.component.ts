import { Component, OnInit } from '@angular/core';
import { FormGroup,FormControl,Validator,FormBuilder, Validators, AbstractControl } from '@angular/forms';

@Component({
  selector: 'app-registerform',
  templateUrl: './registerform.component.html',
  styleUrls: ['./registerform.component.css']
})
export class RegisterformComponent implements OnInit {
  //form builder object
  constructor( private fb:FormBuilder) { }
  ngOnInit() {
  }
    //way 1
  //user defined name  --FormGroup,FormControl
  /* registrationform=new FormGroup(
     {
       uname:new FormControl(),
       age:new FormControl(),
       email:new FormControl(),
       password:new FormControl(),
       confirmpassword:new FormControl(),    
     }
   );*/
   //way2-Formbuilder

   registrationform=this.fb.group({
    uname:['',[Validators.required,Validators.minLength(3)]],
    age:['',this.ageRangeValidatior],
    email:['',[Validators.required,Validators.email]],
    password:[''],
    confirmpassword:['']});


   doregister()
   {
     console.log(this.registrationform.value);
   }

   //Custom validation or user defined validation
   ageRangeValidatior(control:AbstractControl):{[key:string]:boolean} |null
   {
   
     if(control.value!==undefined && (isNaN(control.value)|| control.value<18 ||control.value>45))
     {
       return {'ageRange':true}
     }
     return null;
   }
}
