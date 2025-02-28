"use strict";
function getStudent(student) {
    return `${student.rollNumber} ${student.name} ${student.course}`;
}
let student1 = {
    rollNumber: 101,
    name: 'Sai',
    course: 'Computer Science'
};
console.log(getStudent(student1));
function getStudentObjDestruc({ name, course }) {
    return `${name} ${course}`;
}
let student2 = {
    name: 'Sai',
    course: 'Computer Science'
};
console.log(getStudentObjDestruc(student2));
