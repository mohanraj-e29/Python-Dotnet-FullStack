import { Component } from '@angular/core';
import { CrudService } from '../crud.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-edit-user',
  templateUrl: './edit-user.component.html',
  styleUrls: ['./edit-user.component.css']
})
export class EditUserComponent {

ulist:any=[];
eid:number=this.act.snapshot.params['id'];

constructor(public cs:CrudService,
            public act:ActivatedRoute,
            public rt:Router) {}

ngOnInit()
{
  this.fetchSingleUser(this.eid);
}

fetchSingleUser(i:number)
{
  this.cs.getSingleUser(i).subscribe(res => {
    this.ulist=res;
  });
}

updateInfo(i:number,d:any)
{
  this.cs.updateUser(i,d).subscribe();
  this.rt.navigate(['list']);
}

}
