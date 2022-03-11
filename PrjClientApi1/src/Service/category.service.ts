import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";

@Injectable()
export class CategoryService
{

    constructor(private http:HttpClient)
    {

    }
  //.net core prjwebapi1 url
    readonly uri="http://localhost:26212/api/Category";

    getCategory()
    {
        return this.http.get(this.uri);
    }
}