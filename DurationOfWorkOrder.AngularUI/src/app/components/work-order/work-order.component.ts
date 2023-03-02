import { Component, OnInit } from '@angular/core';
import { WorkOrder } from 'src/app/models/workOrder';
import { WorkOrderModel } from 'src/app/models/workOrderModel';
import { WorkOrderService } from 'src/app/services/work-order.service';

@Component({
  selector: 'app-work-order',
  templateUrl: './work-order.component.html',
  styleUrls: ['./work-order.component.css']
})
export class WorkOrderComponent implements OnInit {
  workOrders : WorkOrderModel[] = [];
  durations : number[] = [];
  totalDurations : number[] = []; 
  
  constructor(
    private workOrderService : WorkOrderService
  ) { }

  ngOnInit() {
    this.getWorkOrderWithDurations();
  }

  getWorkOrderWithDurations(){
    this.workOrderService.getWorkOrderWithDurations().subscribe((response) => {
      this.workOrders.forEach(workOrder => {
        workOrders = response
      })
    })
  }
}
