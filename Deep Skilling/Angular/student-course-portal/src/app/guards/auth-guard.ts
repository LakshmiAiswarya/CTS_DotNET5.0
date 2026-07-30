import { CanActivateFn } from '@angular/router';

export const authGuard: CanActivateFn = (route, state) => {

  const loggedIn = true;

  if (loggedIn) {
    return true;
  }

  return false;
};