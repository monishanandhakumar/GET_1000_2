import { Injectable } from "@angular/core";
import { Product } from "../Model/product.model";

//decorator
@Injectable()
export class ProductService
{
    product:Product[];

    constructor()
    {
        this.product=[
            {pid:101,pname:'Bag-Model1',price:1050,quantity:10,image:'assets/image/laptopbagmodel1.jpeg'},
            {pid:102,pname:'Bag-Model2',price:1150,quantity:15,image:'assets/image/laptopbagmodel2.jpeg'},
            {pid:103,pname:'Chocolate',price:150,quantity:100,image:'assets/image/chocolate.jpeg'}
        ]
    }

    //fetch all product

    getproductsfromservice()
    {
        return this.product;
    }

    //Adding new product

    addproductinservice(prod:Product)
    {
        debugger;
         this.product.push(prod);
    }
}