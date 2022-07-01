import { Component, OnInit } from '@angular/core';
import { PlantService } from '../plant.service';

@Component({
  selector: 'app-plant',
  templateUrl: './plant.component.html',
  styleUrls: ['./plant.component.css']
})
export class PlantComponent implements OnInit {

  id:number=0;
  constructor(private service:PlantService) { }

  ngOnInit(): void {
  }

  sendId(){
    this.service.setId(this.id);
  }

}
