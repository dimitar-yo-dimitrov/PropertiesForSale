import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PropertyListRoutingModule } from './property-routing.module';

import { PropertiesListComponent } from './all-properties/all-properties.component';
import { CreateComponent } from './create-property/create-property.component';
import { CoreModule } from 'src/app/core/core.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MyPropertyComponent } from './my-property/my-property.component';

@NgModule({
  declarations: [
    PropertiesListComponent,
    CreateComponent,
    MyPropertyComponent
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
