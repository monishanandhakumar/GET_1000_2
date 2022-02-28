import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { RegisterformComponent } from './registerform/registerform.component';
import { LoginComponent } from './login/login.component';
import { HomeComponent } from './home/home.component';
import { PagenotfoundComponent } from './pagenotfound/pagenotfound.component';
import { ProductdetailsComponent } from './productdetails/productdetails.component';
import { ProductcrudComponent } from './productcrud/productcrud.component';
import { ApidataComponent } from './apidata/apidata.component';
const routes: Routes = [
  //default page
  {path:'',redirectTo:'/home',pathMatch:'full'},
  {path:"home",component:HomeComponent},
  {path:"register",component:RegisterformComponent},
  {path:"login",component:LoginComponent},
  {path:"productdetails",component:ProductdetailsComponent},
  {path:"pcrud",component:ProductcrudComponent},
  {path:"api",component:ApidataComponent},
  {path:"**",component:PagenotfoundComponent},
 

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
