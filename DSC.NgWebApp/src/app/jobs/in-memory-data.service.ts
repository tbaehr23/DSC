import { InMemoryDbService } from 'angular-in-memory-web-api';

export class InMemoryDataService implements InMemoryDbService {

  createDb() {
      const jobs = [
        { id: 0,  name: 'Job Zero', isCompleted: true },
        { id: 11, name: 'Job 11', isCompleted: false },
        { id: 12, name: 'Job 12', isCompleted: true },
        { id: 13, name: 'Job 13', isCompleted: false },
        { id: 14, name: 'Job 14', isCompleted: true },
        { id: 15, name: 'Job 15', isCompleted: false },
        { id: 16, name: 'Job 16', isCompleted: true },
        { id: 17, name: 'Job 17', isCompleted: false },
        { id: 18, name: 'Job 18', isCompleted: true },
        { id: 19, name: 'Job 19', isCompleted: false },
        { id: 20, name: 'Job 20', isCompleted: true }
    ];
    return {jobs};
  }
}
