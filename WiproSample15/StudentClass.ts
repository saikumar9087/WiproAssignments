interface Student {
    rollNumber?: number; // optional property
    name: string;
    course: string;
}

function getStudent(student: Student) {
    return `${student.rollNumber} ${student.name} ${student.course}`;
}

let student1 = {
    rollNumber: 101,
    name: 'Sai',
    course: 'Computer Science'
};
console.log(getStudent(student1));



function getStudentObjDestruc({ name, course }: Student) {
    return `${name} ${course}`;
}

let student2 = {
    name: 'Sai',
    course: 'Computer Science'
};

console.log(getStudentObjDestruc(student2));
