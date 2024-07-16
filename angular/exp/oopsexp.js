var employee = /** @class */ (function () {
    function employee(i, n) {
        this.eid = i;
        this.ename = n;
    }
    employee.prototype.display = function () {
        console.log(this.eid, this.ename);
    };
    return employee;
}());
var emp = new employee(101, "sathish");
emp.display();
