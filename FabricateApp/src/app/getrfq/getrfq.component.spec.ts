import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GetrfqComponent } from './getrfq.component';

describe('GetrfqComponent', () => {
  let component: GetrfqComponent;
  let fixture: ComponentFixture<GetrfqComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GetrfqComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GetrfqComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
