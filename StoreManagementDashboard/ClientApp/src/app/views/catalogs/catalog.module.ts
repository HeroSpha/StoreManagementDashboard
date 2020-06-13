import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ChartsModule } from 'ng2-charts';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { ButtonsModule } from 'ngx-bootstrap/buttons';
import { CatalogsComponent } from './catalogs.component';
import { CatalogRoutingModule } from './catalog-routing.module';
import { AddCatalogComponent } from './addcatalog.component';

@NgModule({
  imports: [
    FormsModule,
    CatalogRoutingModule,
    ChartsModule,
    BsDropdownModule,
    ButtonsModule.forRoot()
  ],
  declarations: [ CatalogsComponent, AddCatalogComponent]
})
export class CatalogModule { }
