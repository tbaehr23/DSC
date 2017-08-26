import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpModule } from '@angular/http';


import { AppComponent } from './app.component';
import { JobListComponent } from './jobs/job-list.component';
import { JobService } from './jobs/job.service';


@NgModule({
  declarations: [
    AppComponent,
    JobListComponent
  ],
  imports: [
    BrowserModule,
    HttpModule,
    ],
  providers: [JobService],
  bootstrap: [AppComponent]
})
export class AppModule { }
