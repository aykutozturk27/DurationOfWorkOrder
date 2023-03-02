import { WorkOrder } from "./workOrder";

export class WorkOrderModel{
    WorkOrders : WorkOrder[] = [];
    Durations : number[] = [];
    TotalDurations : number[] = [];
    GeneralTotalDuration : number = 0;
}