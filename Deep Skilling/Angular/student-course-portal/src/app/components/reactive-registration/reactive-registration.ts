import { Component } from '@angular/core';
import { ReactiveFormsModule, FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-reactive-registration',
  standalone: true,
  imports: [ReactiveFormsModule],
  templateUrl: './reactive-registration.html',
  styleUrl: './reactive-registration.css'
})
export class ReactiveRegistration {

  studentForm;

  constructor(private fb: FormBuilder) {

    this.studentForm = this.fb.group({

      name: ['', Validators.required],

      email: ['', [Validators.required, Validators.email]],

      course: ['', Validators.required]

    });

  }


  submitForm() {

    console.log(this.studentForm.value);

  }

}