import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewstockComponent } from './viewstock.component';

describe('ViewstockComponent', () => {
  let component: ViewstockComponent;
  let fixture: ComponentFixture<ViewstockComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ViewstockComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ViewstockComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
