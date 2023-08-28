import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';

import { AllPropertiesRoutingModule } from './property-routing.module';

import { AllPropertiesComponent } from './all-properties/all-properties.component';
import { CreateComponent } from './create-property/create-property.component';
import { MyPropertiesComponent } from './my-properties/my-properties.component';

import { CoreModule } from 'src/app/core/core.module';

@NgModule({
  declarations: [
    AllPropertiesComponent,
    CreateComponent,
    MyPropertiesComponent
  ],
  imports: [
    CommonModule,
    CoreModule,
    AllPropertiesRoutingModule,
    ReactiveFormsModule,
  ]
})
export class AllPropertyModule { }
