var Stud = /** @class */ (function () {
    function Stud(rollno, name, course) {
        this.rollno = rollno;
        this.name = name;
        this.course = course;
    }
    Stud.prototype.displayDetails = function () {
        return "Roll Number: ".concat(this.rollno, ", Name: ").concat(this.name, ", Course: ").concat(this.course);
    };
    return Stud;
}());
var studentMap = new Map();
studentMap.set(101, new Stud(101, 'Sai', 'CSE'));
studentMap.set(102, new Stud(102, 'Sathwik', 'IT'));
studentMap.set(103, new Stud(103, 'Shivs', 'ECE'));
studentMap.forEach(function (student) {
    console.log(student.displayDetails());
});
if (studentMap.has(101)) {
    console.log('Student with roll number 101 exists.');
}
else {
    console.log('Student with roll number 101 does not exist.');
}
studentMap.delete(102);
console.log('Updated Student Map:');
studentMap.forEach(function (student) {
    console.log(student.displayDetails());
});
