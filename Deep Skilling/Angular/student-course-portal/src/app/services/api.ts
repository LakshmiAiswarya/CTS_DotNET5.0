import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ApiService {


  url = "http://localhost:3000/courses";


  constructor(private http: HttpClient) { }


  getCourses() {

    return this.http.get<any[]>(this.url);

  }


}