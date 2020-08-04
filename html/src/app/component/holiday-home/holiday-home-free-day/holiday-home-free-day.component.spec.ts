import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { HolidayHomeFreeDayComponent } from './holiday-home-free-day.component';

describe('HolidayHomeFreeDayComponent', () => {
  let component: HolidayHomeFreeDayComponent;
  let fixture: ComponentFixture<HolidayHomeFreeDayComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ HolidayHomeFreeDayComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(HolidayHomeFreeDayComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
