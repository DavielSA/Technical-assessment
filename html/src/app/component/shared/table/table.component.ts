import { Component, OnInit, Input } from '@angular/core';
import { MatTableModule } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';

import { IHeaders } from './iHeaders';

@Component({
  selector: 'tableCustom',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.css']
})
export class TableComponent implements OnInit {

  private _columns: IHeaders[] = [];
  columnsKeys: string[] = [];

  @Input() dataSource: any;
  @Input() set Columns(value: IHeaders[]) {
    this._columns = value;
    this.columnsKeys = value.map((o: IHeaders) => o.key)
  }

  get Columns(): IHeaders[] {
    return this._columns;
  }


  fnRating(num: Number) {
    const numb: number[] = [];
    for (let i = 1; i <= num; i++) {
      numb.push(i)
    }
    return numb;
  }

  constructor() { }

  ngOnInit(): void {
  }

}
