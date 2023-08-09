import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PropertyListRoutingModule } from './property-routing.module';

import { PropertiesListComponent } from './properties-list/properties-list.component';
import { CreateComponent } from './create/create.component';
import { CoreModule } from 'src/app/core/core.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    PropertiesListComponent,
    CreateComponent
  ],
  imports: [
    CommonModule,
    CoreModule,
    PropertyListRoutingModule,
    FormsModule,
    ReactiveFormsModule,
  ]
})
export class PropertyListModule { }
