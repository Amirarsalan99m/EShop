import { TestBed } from '@angular/core/testing';

import { CommentAggressionService } from './comment-aggression.service';

describe('CommentAggressionService', () => {
  let service: CommentAggressionService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CommentAggressionService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
