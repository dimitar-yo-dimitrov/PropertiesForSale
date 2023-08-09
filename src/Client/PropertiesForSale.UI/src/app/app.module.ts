import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';

import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { PropertyListModule } from './components/properties/property.module';
import { CoreModule } from './core/core.module';
import { ComponentModule } from './components/component.module';

@NgModule({
  declarations: [AppComponent],
  providers: [],
  bootstrap: [AppComponent],
  imports: [
    BrowserModule,
    CoreModule,
    PropertyListModule,
    AppRoutingModule,
    ComponentModule,
  ],
})
export class AppModule {}
