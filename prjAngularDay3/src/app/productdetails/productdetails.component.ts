import { Component, OnInit } from '@angular/core';
import { Product } from '../Model/product.model';
import { ProductService } from '../Service/product.service';

@Component({
  selector: 'app-productdetails',
  templateUrl: './productdetails.component.html',
  styleUrls: ['./productdetails.component.css']
})
export class ProductdetailsComponent implements OnInit {
              //DI
  constructor(private pservice:ProductService ) { }

  ngOnInit() {
    this.getdetails();
  }

  prod:any=[];
  getdetails()
  {
    this.prod= this.pservice.getproductsfromservice();
  }

}
