import { Component, OnInit } from '@angular/core';

import { Job } from './job';
import { JobService } from './job.service';


@Component({
    selector: 'job-list',
    templateUrl: './job-list.component.html'
})
export class JobListComponent implements OnInit{

    constructor(private _jobService: JobService){}

    pageTitle: string = "Job List";
    jobs: Job[];
    error: any;

    ngOnInit(){
        this.getJobs();
    }

    getJobs(){
       this._jobService.getJobs()
                       .then(data => this.jobs = data)
                       .catch(error => this.error = error);
    }

}
