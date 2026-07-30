import { Component, Input, Output, EventEmitter, OnInit, OnChanges, OnDestroy } from '@angular/core';

@Component({
  selector: 'app-student-card',
  imports: [],
  templateUrl: './student-card.html',
  styleUrl: './student-card.css'
})
export class StudentCard implements OnInit, OnChanges, OnDestroy {

  @Input() studentName = '';
  @Input() course = '';

  @Output() studentSelected = new EventEmitter<string>();

  ngOnInit() {
    console.log("Student Card Initialized");
  }

  ngOnChanges() {
    console.log("Student Data Changed");
  }

  selectStudent() {
    this.studentSelected.emit(this.studentName);
  }

  ngOnDestroy() {
    console.log("Student Card Destroyed");
  }

}