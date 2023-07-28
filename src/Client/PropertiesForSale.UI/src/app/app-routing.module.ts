import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PropertiesListComponent } from './components/properties/properties-list/properties-list.component';

const routes: Routes = [
  {
    path: '',
    component: PropertiesListComponent,
  },
  {
    path: 'properties',
    component: PropertiesListComponent,
  },
  { path: 'property-list', loadChildren: () => import('./components/properties/property.module')
  .then(m => m.PropertyListModule) },
  { path: 'property-list', loadChildren: () => import('./components/properties/property.module')
  .then(m => m.PropertyListModule) },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
