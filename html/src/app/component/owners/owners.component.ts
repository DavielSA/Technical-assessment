import { Component, OnInit } from '@angular/core';
import { IHeaders, TableFormat } from './../shared/table/iHeaders';

@Component({
  selector: 'app-owners',
  templateUrl: './owners.component.html',
  styleUrls: ['./owners.component.css']
})
export class OwnersComponent implements OnInit {

  Headers:IHeaders[]=[
    {
      key:"Id",
      label:"#"
    },
    {
      key:"Name",
      label:"Name"
    },
    {
      key:"Rating",
      label:"Rating",
      format:TableFormat.Rating
    }
  ];
  dataSource:any[] = [
    {
      Id:1,
      Name:"Daviel",
      Rating:1
    },
    {
      Id:2,
      Name:"Ramon",
      Rating:3
    }
  ];

  constructor() { }

  ngOnInit(): void {
  }

}
