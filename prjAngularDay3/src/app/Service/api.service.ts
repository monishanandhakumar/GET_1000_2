import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";

@Injectable()
export class  ApiService{

   constructor(private http:HttpClient)
    {

    }

    private readonly url="https://jsonplaceholder.typicode.com/posts";

    //feteching the data from api
 togetdata()
 {
     return this.http.get(this.url);
     debugger;
     console.log("fetching data from uri");
 }

}