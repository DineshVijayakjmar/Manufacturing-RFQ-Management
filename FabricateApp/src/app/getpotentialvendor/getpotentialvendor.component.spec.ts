import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GetpotentialvendorComponent } from './getpotentialvendor.component';

describe('GetpotentialvendorComponent', () => {
  let component: GetpotentialvendorComponent;
  let fixture: ComponentFixture<GetpotentialvendorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GetpotentialvendorComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GetpotentialvendorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
