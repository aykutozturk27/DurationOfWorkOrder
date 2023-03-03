import { WorkOrder } from "./workOrder";

export class WorkOrderModel{
    workOrders : WorkOrder[] = [];
    durations : number[] = [];
    totalDurations : number[] = [];
    generalTotalDuration : number = 0;
}