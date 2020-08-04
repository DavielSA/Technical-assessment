import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { MenuComponent } from './component/menu/menu.component';
import { LangsComponent } from './component/langs/langs.component';
import { HolidayHomeComponent } from './component/holiday-home/holiday-home.component';
import { OwnersComponent } from './component/owners/owners.component';
import { HolidayHomeLangComponent } from './component/holiday-home/holiday-home-lang/holiday-home-lang.component';
import { HolidayHomeFreeDayComponent } from './component/holiday-home/holiday-home-free-day/holiday-home-free-day.component';

import { TableComponent } from './component/shared/table/table.component';


const routes: Routes = [
  { path: '', component: HolidayHomeComponent },
  { path: 'holidayhome', component: HolidayHomeComponent },
  { path: 'langs', component: LangsComponent },
  { path: 'owner', component: OwnersComponent},
  { path: 'holidayhomelang', component: HolidayHomeLangComponent },
  { path: 'holidayhomefreeday', component: HolidayHomeFreeDayComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }