import { Component, Inject, OnInit } from '@angular/core';
import { suppliers, SupplierService } from '../supplier.service';

@Component({
  selector: 'app-supplier',
  templateUrl: './supplier.component.html',
  styleUrls: ['./supplier.component.css']
})
export class SupplierComponent implements OnInit {
  suppliers: suppliers[] = []
  newdata: suppliers = { supplier_id: 0, name: "", email: "", phone: 0, location: "", feedback: 0 }
  addeddata: suppliers = { supplier_id: 0, name: "", email: "", phone: 0, location: "", feedback: 0 }
  update: boolean = false;
  updateFeedback: boolean = false;
  constructor(private service: SupplierService) { }


  ngOnInit(): void {
    // this.getSupplier()
  }

  addsupplier() {
    // alert("Called");
    if (this.newdata.name == "" || this.newdata.email == "" || this.newdata.phone == 0 || this.newdata.location == "" || this.newdata.feedback == 0) {
      alert("Add The Details")
      // location.reload()
    } else {
      // alert("Called");
      this.service.addSupplier(this.newdata).subscribe((data: suppliers[]) => {
        // this.addeddata=data;
        console.log("data", data);
        this.suppliers = data;
        // if (this.suppliers.length > 0) {
        //   this.update = true;
        // }
      })
      // location.reload()
      this.newdata.supplier_id = 0;
      this.newdata.name = "";
      this.newdata.email = "";
      this.newdata.phone = 0;
      this.newdata.location = "";
      this.newdata.feedback = 0;
    }
  }

  getSupplier() {
    this.service.getsupplier().subscribe((data: suppliers[]) => {

      this.suppliers = data;
    },
      error => {
        //error
        console.log(error);
      });
  }

  updating(supplier: suppliers) {
    this.update = true;
    this.newdata.supplier_id = supplier.supplier_id;
    this.newdata.name = supplier.name;
    this.newdata.email = supplier.email;
    this.newdata.phone = supplier.phone;
    this.newdata.location = supplier.location;
    this.newdata.feedback = supplier.feedback;
  }

  updateSupplier() {
    if (this.newdata.name == "" || this.newdata.email == "" || this.newdata.phone == 0 || this.newdata.location == "" || this.newdata.feedback == 0) {
      alert("Fill All the Details")
      // location.reload()
    } else {
      this.service.updatesupplier(this.newdata).subscribe((data: suppliers[]) => {
        // this.addeddata = data;
        console.log(data);
        this.suppliers = data;
      })
      // location.reload()
    }
  }

  updatingFeedback(supplier: suppliers) {
    this.updateFeedback = true;
    this.newdata.supplier_id = supplier.supplier_id;
    this.newdata.name = supplier.name;
    this.newdata.email = supplier.email;
    this.newdata.phone = supplier.phone;
    this.newdata.location = supplier.location;
    this.newdata.feedback = supplier.feedback;
  }

  updatefeedBack() {
    if (this.newdata.feedback == 0) {
      alert("Add the FeedBack")
      // location.reload()
    }
    this.service.updateFeedback(this.newdata).subscribe((data: suppliers[]) => {
      // this.addeddata = data;
      console.log(data);
      this.suppliers = data;
    })
    // location.reload()
  }

  reload() {
    location.reload()
  }


  // if (error.status = 401) {
  //   this.pageError = "Offer editing is denied"
  // }

}
