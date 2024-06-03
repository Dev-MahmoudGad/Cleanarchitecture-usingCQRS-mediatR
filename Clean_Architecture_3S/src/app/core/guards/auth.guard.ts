import { Injectable } from '@angular/core';

@Injectable()
export class AuthGuard  {
  canActivate(): boolean {
    return true;
  }
}
