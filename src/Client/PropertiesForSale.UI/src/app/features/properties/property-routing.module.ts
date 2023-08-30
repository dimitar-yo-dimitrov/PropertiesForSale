import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { AllPropertiesComponent } from './all-properties/all-properties.component';
import { CreateComponent } from './create-property/create-property.component';
import { MyPropertiesComponent } from './my-properties/my-properties.component';

const routes: Routes = [
  {
    path: '',
    component: AllPropertiesComponent,
  },
  { 
    path: 'properties', 
    component: AllPropertiesComponent 
  },
  {
    path: 'create-property',
    component: CreateComponent,
  },
  { 
    path: 'my-properties', 
    component: MyPropertiesComponent 
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class AllPropertiesRoutingModule {}
