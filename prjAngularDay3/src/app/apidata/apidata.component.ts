import { Component, OnInit } from '@angular/core';
import { ApiService } from '../Service/api.service';

@Component({
  selector: 'app-apidata',
  templateUrl: './apidata.component.html',
  styleUrls: ['./apidata.component.css']
})
export class ApidataComponent implements OnInit {

  constructor(private aservice:ApiService) { }

  ngOnInit() {
    //this.getdatafromapiservice();
  }

  getdatafromapiservice()
  {
    this.aservice.togetdata();
  }

}
