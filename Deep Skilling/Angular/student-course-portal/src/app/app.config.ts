import { ApplicationConfig } from '@angular/core';
import { provideRouter } from '@angular/router';
import { provideHttpClient, withInterceptors } from '@angular/common/http';

import { provideStore } from '@ngrx/store';
import { provideEffects } from '@ngrx/effects';

import { routes } from './app.routes';
import { errorInterceptor } from './interceptors/error-interceptor';

import { courseReducer } from './store/course.reducer';
import { CourseEffects } from './store/course.effects';


export const appConfig: ApplicationConfig = {
  providers: [

    provideRouter(routes),

    provideHttpClient(
      withInterceptors([
        errorInterceptor
      ])
    ),

    provideStore({
  courses: courseReducer
}),

provideEffects([
  CourseEffects
])

  ]
};