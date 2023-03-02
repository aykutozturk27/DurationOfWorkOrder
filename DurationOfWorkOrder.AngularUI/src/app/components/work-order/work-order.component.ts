import { Component, OnInit } from '@angular/core';
import { WorkOrderModel } from 'src/app/models/workOrderModel';
import { WorkOrderService } from 'src/app/services/work-order.service';

@Component({
  selector: 'app-work-order',
  templateUrl: './work-order.component.html',
  styleUrls: ['./work-order.component.css']
})
export class WorkOrderComponent implements OnInit {
  workOrders : any;
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
      this.workOrders = response.WorkOrders;
      this.durations = response.Durations;
      this.totalDurations = response.TotalDurations;
      this.generalTotalDurations = response.GeneralTotalDuration;
      //this.workOrderCodes = [... new Set(this.workOrders.map(x=>x.workOrderCode))];
      // this.durations = [... new Set(this.workOrders.map(x=>x.durations))];
      // this.totalDurations = [... new Set(this.workOrders.map(x=>x.totalDurations))];
      console.log(response);
    })
  }
}
