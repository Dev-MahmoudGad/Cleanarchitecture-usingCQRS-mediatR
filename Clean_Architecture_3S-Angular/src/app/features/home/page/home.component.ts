import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormArray, Validators, AbstractControl, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { governoratDto } from '../../../../core/Dto/loookup/governoratDto/governoratDto';
import { cityDto } from '../../../../core/Dto/loookup/cityDto/cityDto';
import { registrationservice } from '../../../../core/services/users/registrationservice';
import { cityservice } from '../../../../core/services/lookup/city/citeservices';
import { governoratservices } from '../../../../core/services/lookup/governorat/governoratservices';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RouterOutlet } from '@angular/router';
import { NgFor, NgIf } from '@angular/common';
import { SharedModule } from '../../../../shared/shared.module';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [
    NgFor,
    NgIf,
    FormsModule,
    ReactiveFormsModule,
    SharedModule
  ],
  templateUrl: './home.component.html',
  styleUrl: './home.component.scss'
})

export class HomeComponent {
  registrationForm: FormGroup;
  governates: governoratDto[]; // Replace with actual data from DB
  cities: cityDto[]; // Replace with actual data from DB
  currentAdd: FormGroup;

  constructor(private fb: FormBuilder, private registrationService: registrationservice,
    private cityservices: cityservice,
    private governorateservices: governoratservices
  ) {} // Inject the service

  ngOnInit(): void {
    this.registrationForm = this.fb.group({
      firstName: ['', [Validators.required, Validators.maxLength(20), Validators.pattern(/^[\u0621-\u064A\u0660-\u0669A-Za-z ]+$/)]],
      middleName: ['', [Validators.maxLength(40), Validators.pattern(/^[\u0621-\u064A\u0660-\u0669A-Za-z ]+$/)]],
      lastName: ['', [Validators.required, Validators.maxLength(20), Validators.pattern(/^[\u0621-\u064A\u0660-\u0669A-Za-z ]+$/)]],
      birthDate: ['', [Validators.required, this.minAgeValidator(20)]],
      mobileNumber: ['', [Validators.required, Validators.pattern(/^\+021\d{9,13}$/)]],
      email: ['', [Validators.required, Validators.email]],
      addresses: this.fb.array([])
    });

    this.getgovernorates();
    this.getetallcities()
    this.currentAdd = this.createAddress({});
  }

  getgovernorates() {

    this.governorateservices.getallgovernorates().subscribe(obj => {
      debugger
      this.governates = obj;
    });
  }
  currentcities: cityDto[] = []
  getetallcitiesbygovernorateid(e) {
    if (!this.cities) return;
    this.currentcities = this.cities.filter(a => a.governorateId == e.target.value);
    return;

  }
  getetallcities() {
    debugger
    this.cityservices.getallcities().subscribe(obj => {
      this.cities = obj;
    });
  }



  createAddress(addressData: any): FormGroup {
    return this.fb.group({
      governate: [addressData ? addressData.governate : '', Validators.required],
      cityId: [addressData ? addressData.cityId : '', Validators.required],
      street: [addressData ? addressData.street : '', Validators.required],
      buildingNumber: [addressData ? addressData.buildingNumber : '', Validators.required],
      flatNumber: [addressData ? addressData.flatNumber : '', Validators.required]
    });
  }

  addAddress(): void {
    this.addresses.push(this.createAddress(this.currentAdd.value));
    this.currentAdd.reset();
  }



  getGovernorateName(id) {
    if (!id) return '';
    return this.governates.filter(a => a.id == id)[0].name;
  }
  setCityName(e) {
    // let cityName = this.cities.filter(a => a.id == e.target.value)[0].name;
    // this.currentAdd.get('cityName').setValue(cityName)
  }
  getCityName(id) {
    if (!id) return '';
    let obj = this.cities.filter(a => a.id == id)[0];
    if (!obj)
      return ''
    return obj.name;
  }

  removeAddress(index: number): void {
    this.addresses.removeAt(index);
  }

  get addresses(): FormArray {
    return this.registrationForm.get('addresses') as FormArray;
  }

  get firstName(): AbstractControl {
    return this.registrationForm.get('firstName');
  }

  get middleName(): AbstractControl {
    return this.registrationForm.get('middleName');
  }

  get lastName(): AbstractControl {
    return this.registrationForm.get('lastName');
  }

  get birthDate(): AbstractControl {
    return this.registrationForm.get('birthDate');
  }

  get mobileNumber(): AbstractControl {
    return this.registrationForm.get('mobileNumber');
  }

  get email(): AbstractControl {
    return this.registrationForm.get('email');
  }

  minAgeValidator(minAge: number): Validators {
    return (control: AbstractControl): { [key: string]: any } | null => {
      const birthDate = new Date(control.value);
      const age = new Date().getFullYear() - birthDate.getFullYear();
      if (age < minAge) {
        return { minAge: { requiredAge: minAge, actualAge: age } };
      }
      return null;
    };
  }

  onSubmit(): void {
    debugger;
    if (this.registrationForm.valid) {
      this.registrationService.submitRegistration(this.registrationForm.value).subscribe(
        response => {
          console.log('Registration successful', response);
        },
        error => {
          console.error('Registration failed', error);
        }
      );
    } else {
      console.log('Form is invalid');
    }
  }
}