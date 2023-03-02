import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { WorkOrderComponent } from './components/work-order/work-order.component';

const routes: Routes = [
  { path: '', pathMatch: 'full', component: WorkOrderComponent },
  { path: 'workOrders', component: WorkOrderComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
