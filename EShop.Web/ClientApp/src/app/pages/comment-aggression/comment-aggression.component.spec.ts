import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CommentAggressionComponent } from './comment-aggression.component';

describe('CommentAggressionComponent', () => {
  let component: CommentAggressionComponent;
  let fixture: ComponentFixture<CommentAggressionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CommentAggressionComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CommentAggressionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
