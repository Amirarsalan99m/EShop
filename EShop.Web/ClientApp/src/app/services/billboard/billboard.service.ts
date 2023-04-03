import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { arch } from 'process';
import { BehaviorSubject, Observable } from 'rxjs';
import { Billboard } from '../../DTOs/billboard/Billboard';
import { BillboardResponse } from '../../DTOs/billboard/BillboardResponse';

@Injectable({
  providedIn: 'root'
})
export class BillboardService {

  private billboardItems: BehaviorSubject<Billboard[]> = new BehaviorSubject<Billboard[]>(new Array)

  constructor(private http: HttpClient) { }

  public GetBillboardItems(): Observable< BillboardResponse > {
    return this.http.get<BillboardResponse>('api/billboard/getbillboarditems');
  }

  public getCurrentBillboardItems(): Observable<Billboard[]> {
    return this.billboardItems;
  }

  public setCurrentBillboardItems(billboardItems: Billboard[]) {
    this.billboardItems.next(billboardItems);
  }
}
