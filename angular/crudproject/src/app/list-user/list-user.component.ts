import { Component } from '@angular/core';
import { CrudService } from '../crud.service';

@Component({
  selector: 'app-list-user',
  templateUrl: './list-user.component.html',
  styleUrls: ['./list-user.component.css']
})
export class ListUserComponent {

constructor(public cs:CrudService) {}

ulist:any=[];

ngOnInit()
{
  this.fetchAllUsers();
}

fetchAllUsers()
{
  this.cs.getAllUsers().subscribe(res => {
    this.ulist=res;
  });
}

deleteInfo(eid:number)
{
  if(confirm("Are you remove this user?"))
  {
    this.cs.deleteUser(eid).subscribe();
    this.fetchAllUsers();
  }
}

}