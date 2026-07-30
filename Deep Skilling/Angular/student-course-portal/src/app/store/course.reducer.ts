import { createReducer, on } from '@ngrx/store';
import { loadCoursesSuccess } from './course.actions';


export interface CourseState {
    courses: any[];
}


export const initialState: CourseState = {

    courses: []

};


export const courseReducer = createReducer(

    initialState,

    on(loadCoursesSuccess, (state, { courses }) => ({
        ...state,
        courses
    }))

);