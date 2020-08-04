import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { HolidayHomeLangComponent } from './holiday-home-lang.component';

describe('HolidayHomeLangComponent', () => {
  let component: HolidayHomeLangComponent;
  let fixture: ComponentFixture<HolidayHomeLangComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ HolidayHomeLangComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(HolidayHomeLangComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
