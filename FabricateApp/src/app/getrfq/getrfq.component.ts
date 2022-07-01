import { Component, OnInit } from '@angular/core';
import { rfq, RfqService } from '../rfq.service';

@Component({
  selector: 'app-getrfq',
  templateUrl: './getrfq.component.html',
  styleUrls: ['./getrfq.component.css']
})
export class GetrfqComponent implements OnInit {

  constructor(private service: RfqService) { }
  rfqdetails: rfq[] = []
  ngOnInit(): void {
    this.showRfqDetails()
  }

  showRfqDetails() {
    this.service.getRFQDetails().subscribe((data: any) => {
      this.rfqdetails = data;
    },
      (error: any) => {
        //error
        console.log(error);
      });

  }
}