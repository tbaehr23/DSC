import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpModule } from '@angular/http';

// Imports for loading & configuring the in-memory web api
import { InMemoryWebApiModule } from 'angular-in-memory-web-api';
import { InMemoryDataService }  from './jobs/in-memory-data.service';


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
    InMemoryWebApiModule.forRoot(InMemoryDataService),
    ],
  providers: [JobService],
  bootstrap: [AppComponent]
})
export class AppModule { }
