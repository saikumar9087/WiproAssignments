var TaskManager = /** @class */ (function () {
    function TaskManager() {
        this.tasks = [];
    }
    TaskManager.prototype.addTask = function (task) {
        this.tasks.push(task);
        console.log("Task added: ".concat(task.title));
    };
    TaskManager.prototype.viewTasks = function () {
        return this.tasks;
    };
    TaskManager.prototype.modifyTask = function (id, updatedTask) {
        var task = this.tasks.find(function (t) { return t.id === id; });
        if (!task) {
            console.log("Error: Task with ID ".concat(id, " does not exist."));
            return;
        }
        Object.assign(task, updatedTask);
        console.log("Task modified: ".concat(task.title));
    };
    TaskManager.prototype.deleteTask = function (id) {
        var index = this.tasks.findIndex(function (t) { return t.id === id; });
        if (index === -1) {
            console.log("Error: Task with ID ".concat(id, " does not exist."));
            return;
        }
        this.tasks.splice(index, 1);
        console.log("Task deleted.");
    };
    return TaskManager;
}());
var manager = new TaskManager();
manager.addTask({ id: 1, title: "C# topics", description: "Revise C# topics", completed: false });
manager.addTask({ id: 2, title: "GyM", description: "Leg's workout today", completed: false });
console.log("Tasks:", manager.viewTasks());
manager.modifyTask(1, { completed: true });
manager.deleteTask(2);
manager.deleteTask(3);
