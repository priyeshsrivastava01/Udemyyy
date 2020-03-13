import { BrowserModule } from '@angular/platform-browser';
import { NgModule} from '@angular/core';
import { ReactiveFormsModule, FormsModule }    from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { fakeBackendProvider } from './_helpers';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { CarouselComponent } from './carousel/carousel.component';
import { AlertComponent } from './_components';
import { routing }        from './app-routing.module';
import { JwtInterceptor, ErrorInterceptor } from './_helpers';

import { FlexLayoutModule } from '@angular/flex-layout';

import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { HomeComponent } from './home/home.component';
import { CardComponent } from './card/card.component';
import { CoursesComponent } from './courses/courses.component';

import {CoursesService} from './_services/courses.service';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    CarouselComponent,
    LoginComponent,
    RegisterComponent,
    HomeComponent,
    AlertComponent,
    CardComponent,
    CoursesComponent
     
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule, 
    FlexLayoutModule,
    //CommonModule  ,
    ReactiveFormsModule,
    HttpClientModule,
    routing
    
  ],
  providers: [ { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true },

    // provider used to create fake backend
    fakeBackendProvider,
    CoursesService],
  bootstrap: [AppComponent],
 // schemas:[CUSTOM_ELEMENTS_SCHEMA]

})
export class AppModule { }
