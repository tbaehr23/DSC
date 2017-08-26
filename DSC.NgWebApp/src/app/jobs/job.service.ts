import { Injectable } from '@angular/core';
import { Http } from '@angular/http';

import 'rxjs/add/operator/toPromise';
import 'rxjs/add/operator/map';

import { Job } from './job'

@Injectable()
export class JobService {

   constructor( private _http: Http){}

   
    private jobsUrl: string = 'http://localhost:59700/api/job';

    getJobs(): Promise<Job[]>{
        return this._http.get(this.jobsUrl)
                .map(response => response.json())
                .toPromise()
                .catch(this.handleError);
    }
 
   
    private handleError(error: any): Promise<any> {
        console.error('An error occurred', error); // for demo purposes only
        return Promise.reject(error.message || error);
    }
}
