import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from '../environments/environment';
import { Employee } from './app.model';

@Injectable()
export class AppService {
  constructor(private http: HttpClient) { }

  getEmployees(): Observable<Employee[]> {
    return this.http.get<Employee[]>(environment.apiURL + '/employees', {}).pipe(map((rs: Employee[]) => <Employee[]>rs))
  }

  getEmployeeById(id: number): Observable<Employee> {
    return this.http.get<Employee>(environment.apiURL + '/employees/' + id, {}).pipe(map((rs: Employee) => <Employee>rs))
  }
}
