import { Component, OnInit ,Input,Output,EventEmitter} from '@angular/core';

@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css']
})
export class ChildComponent implements OnInit {

  //getting data from parent to child
   @Input() inputfromparent :string;
   
   //Passing data from  child to parent
   @Output() outputfromchild:EventEmitter<string>=new EventEmitter();

   
   outputtext:string="I am your child:Manoj"
  constructor() { }

  ngOnInit() {
    console.log(this.inputfromparent);
    
  }


  senddatatoparent()
  {
    this.outputfromchild.emit(this.outputtext);
  }

  //Eg 2 hobby
  @Output() sendvalue:EventEmitter<string>=new EventEmitter();
  gethobby(input:HTMLInputElement)
  {
     this.sendvalue.emit(input.value);
     console.log(this.sendvalue);
  }
  static get()
  {
    

  }
}
