import { TestBed } from '@angular/core/testing';

import { RfqService } from './rfq.service';

describe('RfqService', () => {
  let service: RfqService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(RfqService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
