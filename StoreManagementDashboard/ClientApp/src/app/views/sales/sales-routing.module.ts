import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SalesComponent } from './sales.component';

const routes: Routes =  [
  {
    path: '',
    data: {
      title: 'All Sales'
    },
    children: [
      {
        path: '',
        redirectTo: 'allsales'
      },
      {
        path: 'allsales',
        component: SalesComponent,
        data: {
          title: 'All Sales'
        }
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SalesRoutingModule {}
