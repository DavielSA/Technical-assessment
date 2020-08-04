import { Component, OnInit } from '@angular/core';

import { IHeaders } from './../shared/table/iHeaders';

@Component({
  selector: 'app-holiday-home',
  templateUrl: './holiday-home.component.html',
  styleUrls: ['./holiday-home.component.css']
})
export class HolidayHomeComponent implements OnInit {

  Headers:IHeaders[]=[
    {
      key:"Id",
      label:"#"
    },
    {
      key:"Owner",
      label:"Owner"
    },
    {
      key:"Alias",
      label:"Alias"
    }
  ];
  dataSource:any[] = [
    {
      Id:1,
      Owner:"Daviel",
      Alias:"micasaMataCartama"
    },
    {
      Id:2,
      Owner:"Ramon",
      Alias:"DuplexTrianaLasPalmas"
    }
  ];

  constructor() { 
  }

  ngOnInit(): void {
  }

}
