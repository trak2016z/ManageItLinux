import { Component } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from "@angular/forms";
import { Http, Headers } from "@angular/http";

@Component({
    selector: 'home',
    templateUrl: './home.component.html'
})
export class HomeComponent {

    private newBoardForm: FormGroup;
    private boards: any;

    constructor(private formBuilder: FormBuilder, private http: Http) {
        this.newBoardForm = formBuilder.group({
            name: [''],
            description: ['']
        });

        this.getBoards();
    }

    public onSubmit(): void {
        this.http.post('/api/Board/CreateNewBoard', {
            name: this.newBoardForm.value.name,
            description: this.newBoardForm.value.description
        }).subscribe(result => {
            this.getBoards();
        });
    }

    public getBoards() {
        this.http.get('/api/Board/GetAllBoards').subscribe(result => {
            this.boards = result.json();
        });
    }

}