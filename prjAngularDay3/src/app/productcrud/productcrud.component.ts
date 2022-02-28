import { Component, OnInit } from '@angular/core';
import { Product } from '../Model/product.model';
import { ProductService } from '../Service/product.service';

@Component({
  selector: 'app-productcrud',
  templateUrl: './productcrud.component.html',
  styleUrls: ['./productcrud.component.css']
})
export class ProductcrudComponent implements OnInit {

  constructor( private proservice:ProductService) { }

  ngOnInit() {
  }
//object of product
  productinsert:Product={};

  addproduct()
  {
    debugger;
    this.proservice.addproductinservice(this.productinsert);

  }
}
