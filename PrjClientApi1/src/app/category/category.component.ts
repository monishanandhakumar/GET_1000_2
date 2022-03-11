import { Component, OnInit } from '@angular/core';

import { CategoryService } from 'src/Service/category.service';

@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.css']
})
export class CategoryComponent implements OnInit {

  constructor(private catservice:CategoryService) { }

  ngOnInit() {
    this. fetchCategory();
  }
   
  categoryinfo?:any;
  fetchCategory()
  {
       this.catservice.getCategory().subscribe((data)=>{this.categoryinfo=data;console.table(this.categoryinfo)});
  }

}
