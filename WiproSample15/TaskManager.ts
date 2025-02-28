
interface Task {
    id: number;
    title: string;
    description: string;
    completed: boolean;
}


class TaskManager {
    private tasks: Task[] = [];

    addTask(task: Task): void {
        this.tasks.push(task);
        console.log(`Task added: ${task.title}`);
    }

    viewTasks(): Task[] {
        return this.tasks;
    }

    modifyTask(id: number, updatedTask: Partial<Task>): void {
        const task = this.tasks.find(t => t.id === id);
        if (!task) {
            console.log(`Error: Task with ID ${id} does not exist.`);
            return;
        }
        Object.assign(task, updatedTask);
        console.log(`Task modified: ${task.title}`);
    }

    deleteTask(id: number): void {
        const index = this.tasks.findIndex(t => t.id === id);
        if (index === -1) {
            console.log(`Error: Task with ID ${id} does not exist.`);
            return;
        }
        this.tasks.splice(index, 1);
        console.log(`Task deleted.`);
    }
}


const manager = new TaskManager();


manager.addTask({ id: 1, title: "C# topics", description: "Revise C# topics", completed: false });
manager.addTask({ id: 2, title: "GyM", description: "Leg's workout today", completed: false });


console.log("Tasks:", manager.viewTasks());
manager.modifyTask(1, { completed: true });
manager.deleteTask(2);
manager.deleteTask(3);