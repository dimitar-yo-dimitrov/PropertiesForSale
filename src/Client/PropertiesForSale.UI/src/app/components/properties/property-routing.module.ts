import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { PropertiesListComponent } from './all-properties/all-properties.component';
import { CreateComponent } from './create-property/create-property.component';

const routes: Routes = [
  { path: '', pathMatch: 'full', component: PropertiesListComponent },
  { path: 'properties', pathMatch: 'full', component: PropertiesListComponent },
  { path: 'properties/create-property', component: CreateComponent, title: 'Add Property' },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class PropertyListRoutingModule {}
