class employee
{
    eid:number;
    ename:String;
    constructor(i:number,n:String)
    {
        this.eid=i;
        this.ename=n;
    }
    display()
    {
        console.log(this.eid,this.ename);
    }
}
let emp=new employee(101,"sathish");
emp.display();