import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PropertyListRoutingModule } from './property-routing.module';

import { PropertiesListComponent } from './properties-list/properties-list.component';
import { CreateComponent } from './create/create.component';



@NgModule({
  declarations: [
    PropertiesListComponent,
    CreateComponent
  ],
  imports: [
    CommonModule,
    PropertyListRoutingModule,
  ]
})
export class PropertyListModule { }
