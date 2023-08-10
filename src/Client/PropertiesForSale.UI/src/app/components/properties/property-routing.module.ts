import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { AllPropertiesComponent } from './all-properties/all-properties.component';
import { CreateComponent } from './create-property/create-property.component';
import { MyPropertiesComponent } from './my-properties/my-properties.component';

const routes: Routes = [
  { path: '', pathMatch: 'full', component: AllPropertiesComponent },
  { path: 'properties/my-properties', pathMatch: 'full', component: MyPropertiesComponent },
  { path: 'properties', pathMatch: 'full', component: AllPropertiesComponent },
  { path: 'properties/create-property', component: CreateComponent, title: 'Add Property for sale:' },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class AllPropertiesRoutingModule {}
