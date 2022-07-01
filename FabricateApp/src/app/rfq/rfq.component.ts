import { Component, OnInit } from '@angular/core';
import { RfqService } from '../rfq.service';

@Component({
  selector: 'app-rfq',
  templateUrl: './rfq.component.html',
  styleUrls: ['./rfq.component.css']
})
export class RfqComponent implements OnInit {

  constructor(private service: RfqService) { }
  rfqid: number = 0;
  ngOnInit(): void {
  }

  setRfq() {
    this.service.setRfqId(this.rfqid);
  }


}