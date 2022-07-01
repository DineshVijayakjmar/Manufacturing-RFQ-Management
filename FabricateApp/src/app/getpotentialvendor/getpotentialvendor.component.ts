import { Component, OnInit } from '@angular/core';
import { Part } from '../plant.service';
import { rfq, RfqService } from '../rfq.service';
import { suppliers } from '../supplier.service';

@Component({
  selector: 'app-getpotentialvendor',
  templateUrl: './getpotentialvendor.component.html',
  styleUrls: ['./getpotentialvendor.component.css']
})
export class GetpotentialvendorComponent implements OnInit {

  vendors: suppliers[] = []
  constructor(private service: RfqService) { }

  ngOnInit(): void {
    this.showVendors()
  }
  rfqid: number = this.service.getRfqId();
  showVendors() {
    this.service.getSuppliers(this.rfqid).subscribe((data: any) => {
      this.vendors = data;
    },
      (error: any) => {
        //error
        console.log(error);
      });

  }
}
