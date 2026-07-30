import { Injectable, inject } from '@angular/core';
import { Actions, createEffect, ofType } from '@ngrx/effects';
import { HttpClient } from '@angular/common/http';
import { catchError, map, mergeMap, of } from 'rxjs';

import {
    loadCourses,
    loadCoursesSuccess,
    loadCoursesFailure
} from './course.actions';


@Injectable()
export class CourseEffects {

    private actions$ = inject(Actions);
    private http = inject(HttpClient);


    loadCourses$ = createEffect(() =>
        this.actions$.pipe(

            ofType(loadCourses),

            mergeMap(() =>
                this.http.get<any[]>('http://localhost:3000/courses')
                    .pipe(

                        map(courses =>
                            loadCoursesSuccess({ courses })
                        ),

                        catchError(error =>
                            of(
                                loadCoursesFailure({
                                    error: error.message
                                })
                            )
                        )

                    )
            )

        )
    );

}