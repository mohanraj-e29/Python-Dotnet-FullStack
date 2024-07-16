import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TwowybindgComponent } from './twowybindg.component';

describe('TwowybindgComponent', () => {
  let component: TwowybindgComponent;
  let fixture: ComponentFixture<TwowybindgComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [TwowybindgComponent]
    });
    fixture = TestBed.createComponent(TwowybindgComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
