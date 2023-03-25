import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ClientHolderComponent } from './client-holder.component';

describe('ClientHolderComponent', () => {
  let component: ClientHolderComponent;
  let fixture: ComponentFixture<ClientHolderComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ClientHolderComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ClientHolderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
