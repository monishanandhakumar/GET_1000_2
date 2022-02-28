import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RegisterformComponent } from './registerform/registerform.component';
import { ReactiveFormsModule } from '@angular/forms';
import { LoginComponent } from './login/login.component';
import { FormsModule } from '@angular/forms';
import { HomeComponent } from './home/home.component';
import { PagenotfoundComponent } from './pagenotfound/pagenotfound.component';
import { ProductdetailsComponent } from './productdetails/productdetails.component';
import { ProductService } from './Service/product.service';
import { ProductcrudComponent } from './productcrud/productcrud.component';
import { HttpClientModule } from '@angular/common/http';
import { ApidataComponent } from './apidata/apidata.component';
import { ApiService } from './Service/api.service';


@NgModule({
  declarations: [
    AppComponent,
    RegisterformComponent,
    LoginComponent,
    HomeComponent,
    PagenotfoundComponent,
    ProductdetailsComponent,
    ProductcrudComponent,
    ApidataComponent
   
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [ProductService,ApiService], //DI 
  bootstrap: [AppComponent]
})
export class AppModule { }
