class Stud {
    rollno: number;
    name: string;
    course: string;

    constructor(rollno: number, name: string, course: string) {
        this.rollno = rollno;
        this.name = name;
        this.course = course;
    }

    displayDetails() {
        return `Roll Number: ${this.rollno}, Name: ${this.name}, Course: ${this.course}`;
    }
}


let studentMap = new Map<number, Stud>();


studentMap.set(101, new Stud(101, 'Sai', 'CSE'));
studentMap.set(102, new Stud(102, 'Sathwik', 'IT'));
studentMap.set(103, new Stud(103, 'Shivs', 'ECE'));


studentMap.forEach((student) => {
    console.log(student.displayDetails());
});


if (studentMap.has(101)) {
    console.log('Student with roll number 101 exists.');
} else {
    console.log('Student with roll number 101 does not exist.');
}

studentMap.delete(102);


console.log('Updated Student Map:');
studentMap.forEach((student) => {
    console.log(student.displayDetails());
});
