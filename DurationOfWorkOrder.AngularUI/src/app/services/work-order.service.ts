import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { WorkOrderModel } from '../models/workOrderModel';

@Injectable({
  providedIn: 'root',
})
export class WorkOrderService {
  apiUrl = 'http://localhost:56030/api/WorkOrder/';

  constructor(private httpClient: HttpClient) {}

  getWorkOrderWithDurations(): Observable<WorkOrderModel> {
    let newPath = this.apiUrl + 'GetWorkOrderWithDurations';
    return this.httpClient.get<WorkOrderModel>(newPath);
  }
}
