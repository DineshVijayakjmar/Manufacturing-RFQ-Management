import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PartreorderdetailsComponent } from './partreorderdetails.component';

describe('PartreorderdetailsComponent', () => {
  let component: PartreorderdetailsComponent;
  let fixture: ComponentFixture<PartreorderdetailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PartreorderdetailsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PartreorderdetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
