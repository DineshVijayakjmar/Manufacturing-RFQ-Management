import { Component, OnInit } from '@angular/core';
import { Part, PlantService } from '../plant.service';

@Component({
  selector: 'app-partreorderdetails',
  templateUrl: './partreorderdetails.component.html',
  styleUrls: ['./partreorderdetails.component.css']
})
export class PartreorderdetailsComponent implements OnInit {

  constructor(private plantService:PlantService) { }
  partdetails:Part[]=[]
  ngOnInit(): void {
    this.getPartReoderDetail()

  }

  getPartReoderDetail(){
      this.plantService.getPartReorderDetails().subscribe((data:Part[])=>{
          this.partdetails=data;
        },
        error=>{
          //error
          console.log(error);
        });
      }
  }