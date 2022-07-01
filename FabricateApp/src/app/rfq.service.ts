import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { LoginService } from './login.service';
import { Part } from './plant.service';
import { suppliers } from './supplier.service';

export interface rfq {
  rfqId: number,
  demandid: number,
  partId: number,
  quantity: number,
  partName: string,
  timetoSupply: number,
  specification: string

}


@Injectable({
  providedIn: 'root'
})
export class RfqService {

  constructor(private http: HttpClient, private loginService: LoginService) { }

  token = this.loginService.getToken()
  rfqId: number = 0;
  setRfqId(id: number) {
    this.rfqId = id;
  }

  getRfqId() {
    return this.rfqId;
  }

  getRFQDetails(): Observable<rfq> {
    return this.http.get<rfq>("https://localhost:44314/api/rfq/GetRFQ",
      {
        headers: new HttpHeaders({ 'Content-Type': 'application/json', 'Authorization': 'Bearer ' + this.token })
      });
  }

  getSuppliers(rfqid: number): Observable<suppliers> {
    return this.http.get<suppliers>("https://localhost:7288/api/Supplier/GetSupplierOfPart?id=" + rfqid,
      {
        headers: new HttpHeaders({ 'Content-Type': 'application/json', 'Authorization': 'Bearer ' + this.token })
      });
  }
}
