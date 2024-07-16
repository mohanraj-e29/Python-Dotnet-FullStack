import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PropertybindgComponent } from './propertybindg.component';

describe('PropertybindgComponent', () => {
  let component: PropertybindgComponent;
  let fixture: ComponentFixture<PropertybindgComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [PropertybindgComponent]
    });
    fixture = TestBed.createComponent(PropertybindgComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
