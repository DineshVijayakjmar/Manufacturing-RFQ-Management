import { Component, OnInit } from '@angular/core';
import { PlantService, Result } from '../plant.service';

@Component({
  selector: 'app-updateminmax',
  templateUrl: './updateminmax.component.html',
  styleUrls: ['./updateminmax.component.css']
})
export class UpdateminmaxComponent implements OnInit {

  partId:number=0;
  minq:number=0;
  maxq:number=0;
  result:Result={result:""};
  constructor(private service:PlantService) { }

  ngOnInit(): void {
  }

  updateMinMax(){
    alert("Updated");
    this.service.updateMinAndMax(this.partId,this.minq,this.maxq).subscribe((data:any)=>{
      this.result=data;
      console.log(data);
      
      
      
    },
    (error:any)=>{
      //error
      console.log(error);
    });
  }
  
}
