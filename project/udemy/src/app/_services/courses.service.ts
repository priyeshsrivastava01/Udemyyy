import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class CoursesService {
uri = 'http://localhost:44380/api';

  constructor(private http: HttpClient) { }
  getCourses(){
    return this.http.get(`${this.uri}/courses`);
  }
  getCoursesById(CourseId){
    return this.http.get(`${this.uri}/courses/${CourseId}`);
  }
  addCourses(CourseId,Name,Price){
    const Course ={
      CourseId : CourseId,
      Name : Name,
      Price : Price
    };
    return this.http.post(`${this.uri}/courses/add` , Course) ;
    }
    updateCourses(CourseId,Name,Price,status){
      const Course ={
        CourseId : CourseId,
        Name : Name,
        Price : Price,
        status : status
      };
      return this.http.post(`${this.uri}/courses/update/${CourseId}` , Course) ;
      }
      deleteCourses(CourseId){
        return this.http.get(`${this.uri}/courses/delete/${CourseId}`);
      }
}
