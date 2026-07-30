import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Store } from '@ngrx/store';
import { Observable } from 'rxjs';

import { loadCourses } from '../../store/course.actions';
import { selectCourses } from '../../store/course.selectors';


@Component({
  selector: 'app-course-list',
  standalone: true,
  imports: [
    CommonModule
  ],
  templateUrl: './course-list.html',
  styleUrl: './course-list.css'
})
export class CourseList {

  courses$: Observable<any[]>;


  constructor(private store: Store) {

    this.courses$ = this.store.select(selectCourses);

    this.courses$.subscribe(data => {
      console.log(data);
    });

    this.store.dispatch(
      loadCourses()
    );

  }

}