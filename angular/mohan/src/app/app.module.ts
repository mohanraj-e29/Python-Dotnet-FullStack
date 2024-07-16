import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';
import { StrinterpolationComponent } from './strinterpolation/strinterpolation.component';
import { PropertybindgComponent } from './propertybindg/propertybindg.component';
import { TwowybindgComponent } from './twowybindg/twowybindg.component';
import { StructdirectivesComponent } from './structdirectives/structdirectives.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    AboutComponent,
    StrinterpolationComponent,
    PropertybindgComponent,
    TwowybindgComponent,
    StructdirectivesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
