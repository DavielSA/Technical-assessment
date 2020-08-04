import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { MatTableModule } from '@angular/material/table';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ServiceWorkerModule } from '@angular/service-worker';
import { environment } from '../environments/environment';
import { AppRoutingModule } from './app-routing.module';
import { OwnersComponent } from './component/owners/owners.component';
import { LangsComponent } from './component/langs/langs.component';
import { MenuComponent } from './component/menu/menu.component';
import { HolidayHomeComponent } from './component/holiday-home/holiday-home.component';
import { HolidayHomeLangComponent } from './component/holiday-home/holiday-home-lang/holiday-home-lang.component';
import { HolidayHomeFreeDayComponent } from './component/holiday-home/holiday-home-free-day/holiday-home-free-day.component';
import { TableComponent } from './component/shared/table/table.component';
import { MatMenuModule } from '@angular/material/menu';
import { MatIconModule } from '@angular/material/icon';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatToolbarModule } from '@angular/material/toolbar';



@NgModule({
  declarations: [
    AppComponent,
    OwnersComponent,
    LangsComponent,
    MenuComponent,
    HolidayHomeComponent,
    HolidayHomeLangComponent,
    HolidayHomeFreeDayComponent,
    TableComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    BrowserAnimationsModule,
    ServiceWorkerModule.register('ngsw-worker.js', { enabled: environment.production }),
    AppRoutingModule,
    MatTableModule,
    MatMenuModule,
    MatIconModule,
    MatGridListModule,
    MatToolbarModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
