import { Injectable } from '@angular/core';

@Injectable()
export class NoAuthGuard {
  canActivate(): boolean {
    return true;
  }
}
