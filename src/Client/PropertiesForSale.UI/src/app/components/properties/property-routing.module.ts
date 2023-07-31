import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { PropertiesListComponent } from './properties-list/properties-list.component';
import { CreateComponent } from './create/create.component';

const routes: Routes = [
  { path: '', pathMatch: 'full', component: PropertiesListComponent },
  { path: 'properties', pathMatch: 'full', component: PropertiesListComponent },
  { path: 'properties/create', component: CreateComponent, title: 'Add Property' },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class PropertyListRoutingModule {}
