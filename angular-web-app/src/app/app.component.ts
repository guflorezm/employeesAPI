import { Component, OnInit } from '@angular/core';
import { AppService } from './app.service';
import { Employee } from './app.model';
import { FormBuilder, FormGroup, FormControl } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})

export class AppComponent implements OnInit {
  employees: Employee[] = [];
  searchId: number;
  searchForm: FormGroup;
  constructor(private service: AppService, private formBuilder: FormBuilder) {
    this.searchForm = this.formBuilder.group({
      searchId: ''
    })
  }

  ngOnInit(): void {
    this.getAllEmployees();
  }
  title = 'Employees WebApp';

  searchEmployee() {
    if (this.searchForm.value['searchId'] != '') {
      this.getEmployeeByID(this.searchForm.value['searchId']);
    } else {
      this.getAllEmployees();
    }
  }
  getEmployeeByID(id: number) {
    this.service.getEmployeeById(id).subscribe((res) => {
      this.employees = [];
      this.employees[0] = res;
      console.log(this.employees)
    })
  }

  getAllEmployees() {
    this.service.getEmployees().subscribe((res) => {
      this.employees = res;
    });
  }
}
