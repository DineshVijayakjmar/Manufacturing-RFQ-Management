import { Component, OnInit } from '@angular/core';
import { Part, PlantService } from '../plant.service';

@Component({
  selector: 'app-viewstock',
  templateUrl: './viewstock.component.html',
  styleUrls: ['./viewstock.component.css']
})
export class ViewstockComponent implements OnInit {

  stock:Part={partId:0,
    partDescription:"",
    partSpecification:"",
    stockInHand:0}
  constructor(private service:PlantService) { }

  ngOnInit(): void {
    this.getStock()
  }

  getStock(){
    this.service.getStockDetails(this.service.id).subscribe((data:Part)=>{
      this.stock=data;
    },
    error=>{
      //error
      alert(error)
      console.log(error);
    });
  }

}
