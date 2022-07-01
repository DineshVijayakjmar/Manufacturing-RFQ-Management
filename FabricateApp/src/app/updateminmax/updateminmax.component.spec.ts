import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateminmaxComponent } from './updateminmax.component';

describe('UpdateminmaxComponent', () => {
  let component: UpdateminmaxComponent;
  let fixture: ComponentFixture<UpdateminmaxComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UpdateminmaxComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UpdateminmaxComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
