import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'mohan';


  info:string="accord";
  url:string=window.location.href;


  t:string="date";
  d:string="up";


  skills:string="";
  skl()
  {
    this.skills="angular";
  }

  infos:string="accord info matrix";
  remove()
  {
    this.infos="";
  }
  

  eng:number=75;
  mat:number=83;

  phy:number=0;
  soc:number=0;


  course:String[]=["angular","java",".net"];
  
  City:String[]=["chennai","cochin","mysore"];
  Selcity:String="";

  cssvalue:string="col size";

  col:string="";
  ff:string="";

   fonts:string[]=["Impact","Chiller"];
   selff:string="";

   profile=new Contact();

   constructor()
   {
    this.profile={
      user:'',
      email:'',
      phone:0,
      country:'',
      itoc:false,
    }
   }
   country:String[]=["India","England","Japan"];
   submitform(data:any)
   {
    console.log(data.value);
   }
   }
    class Contact
    {
    user!:String;
    email!:String;
    phone!:number;
    country!:String;
    itoc!:boolean;
    }

    

  






  

  
   

