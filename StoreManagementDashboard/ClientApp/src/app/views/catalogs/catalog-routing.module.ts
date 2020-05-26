import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CatalogsComponent } from './catalogs.component';
import { AddCatalogComponent } from './addcatalog.component';

const routes: Routes =  [
  {
    path: '',
    data: {
      title: 'All Catalogs'
    },
    children: [
      {
        path: '',
        redirectTo: 'allcatalogs'
      },
      {
        path: 'allcatalogs',
        component: CatalogsComponent,
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
export class CatalogRoutingModule {}
