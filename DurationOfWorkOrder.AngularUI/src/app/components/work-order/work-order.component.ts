import { Component, OnInit } from '@angular/core';
import { WorkOrder } from 'src/app/models/workOrder';
import { WorkOrderService } from 'src/app/services/work-order.service';

@Component({
  selector: 'app-work-order',
  templateUrl: './work-order.component.html',
  styleUrls: ['./work-order.component.css']
})
export class WorkOrderComponent implements OnInit {
  workOrders : WorkOrder[] = [];
  durations : number[] = [];
  totalDurations : number[] = [];
  workOrderCodes : string[] = []; 
  generalTotalDurations : number = 0;
  
  constructor(
    private workOrderService : WorkOrderService
  ) { }

  ngOnInit() {
    this.getWorkOrderWithDurations();
  }

  async getWorkOrderWithDurations(){
    this.workOrderService.getWorkOrderWithDurations().subscribe((response) => {
      this.workOrders = response.workOrders;
      this.durations = response.durations;
      this.totalDurations = response.totalDurations;
      this.generalTotalDurations = response.generalTotalDuration;
      this.workOrderCodes = [...new Set(this.workOrders.map((item) => item.workOrderCode))];
    })
  }
}
