import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { PropertiesListComponent } from '../components/properties/properties-list/properties-list.component';
import { CreateComponent } from '../components/properties/create/create.component';

@NgModule({
  declarations: [],
  imports: [CommonModule, RouterModule],
  exports: [HttpClientModule],
})
export class CoreModule {}
