import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PropertyListRoutingModule } from './property-routing.module';

import { PropertiesListComponent } from './properties-list/properties-list.component';
import { CreateComponent } from './create/create.component';
import { CoreModule } from 'src/app/core/core.module';



@NgModule({
  declarations: [
    PropertiesListComponent,
    CreateComponent
  ],
  imports: [
    CommonModule,
    CoreModule,
    PropertyListRoutingModule,
  ]
})
export class PropertyListModule { }
