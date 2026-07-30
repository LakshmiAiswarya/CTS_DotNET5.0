import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { StudentCard } from '../../components/student-card/student-card';
import { StudentRegistration } from '../../components/student-registration/student-registration';
import { ReactiveRegistration } from '../../components/reactive-registration/reactive-registration';


@Component({
  selector: 'app-home',
  standalone: true,
  imports: [
    FormsModule,
    StudentCard,
    StudentRegistration,
    ReactiveRegistration,
  ],
  templateUrl: './home.html',
  styleUrl: './home.css'
})
export class Home {

  studentName = "Aishwarya";

  course = "Angular";

  message = "";


  showMessage() {

    this.message = "Welcome to Angular!";

  }

}