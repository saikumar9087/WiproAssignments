import React, { Component } from "react";

class Student extends Component {
  constructor(props) {
    super(props);
   
    this.state = {
      name: "Sai Kumar",
      id: "CS101",
    };
  }

  render() {
    return (
      <div>
        <h2>Student Details</h2>
        <p><strong>Name:</strong> {this.state.name}</p>
        <p><strong>ID:</strong> {this.state.id}</p>
      </div>
    );
  }
}

export default Student;
