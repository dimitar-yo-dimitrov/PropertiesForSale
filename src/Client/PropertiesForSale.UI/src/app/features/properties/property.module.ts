import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AllPropertiesRoutingModule } from './property-routing.module';

import { AllPropertiesComponent } from './all-properties/all-properties.component';
import { CreateComponent } from './create-property/create-property.component';
import { CoreModule } from 'src/app/core/core.module';
import { ReactiveFormsModule } from '@angular/forms';
import { MyPropertiesComponent } from './my-properties/my-properties.component';

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
