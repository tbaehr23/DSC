import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';

import 'rxjs/add/operator/toPromise';

import { Job } from './job'

@Injectable()
export class JobService {

    constructor( private _http: Http){}

    
    private jobsUrl = 'api/jobs';  // URL to angular-in-memory-web-api

    getJobs(): Promise<Job[]> {
        
        return this._http.get(this.jobsUrl)
                .toPromise()
                .then(response => response.json().data as Job[])
                .catch(this.handleError);
    }

    private handleError(error: any): Promise<any> {
        console.error('An error occurred', error); // for demo purposes only
        return Promise.reject(error.message || error);
    }


}
