var ContactManager = /** @class */ (function () {
    function ContactManager() {
        this.contacts = [];
    }
    ContactManager.prototype.addContact = function (contact) {
        this.contacts.push(contact);
        console.log("Contact added successfully.");
        this.updateContactList();
    };
    ContactManager.prototype.viewContacts = function () {
        return this.contacts;
    };
    ContactManager.prototype.modifyContact = function (id, updatedContact) {
        var contact = this.contacts.find(function (c) { return c.id === id; });
        if (!contact) {
            alert("Error: Contact not found.");
            return;
        }
        Object.assign(contact, updatedContact);
        alert("Contact modified successfully.");
        this.updateContactList();
    };
    ContactManager.prototype.deleteContact = function (id) {
        var index = this.contacts.findIndex(function (c) { return c.id === id; });
        if (index === -1) {
            alert("Error: Contact not found.");
            return;
        }
        this.contacts.splice(index, 1);
        alert("Contact deleted successfully.");
        this.updateContactList();
    };
    ContactManager.prototype.updateContactList = function () {
        var _this = this;
        var contactList = document.getElementById("contactList");
        contactList.innerHTML = "";
        this.contacts.forEach(function (contact) {
            var contactDiv = document.createElement("div");
            contactDiv.textContent = "".concat(contact.name, " - ").concat(contact.email, " - ").concat(contact.phone, " ");
            // **Delete Button**
            var deleteBtn = document.createElement("button");
            deleteBtn.textContent = "Delete";
            deleteBtn.onclick = function () { return _this.deleteContact(contact.id); };
            // **Update Button**
            var updateBtn = document.createElement("button");
            updateBtn.textContent = "Update";
            updateBtn.onclick = function () { return _this.populateUpdateForm(contact); };
            contactDiv.appendChild(updateBtn);
            contactDiv.appendChild(deleteBtn);
            contactList.appendChild(contactDiv);
        });
    };
    ContactManager.prototype.populateUpdateForm = function (contact) {
        document.getElementById("updateId").value = contact.id.toString();
        document.getElementById("updateName").value = contact.name;
        document.getElementById("updateEmail").value = contact.email;
        document.getElementById("updatePhone").value = contact.phone;
    };
    return ContactManager;
}());
var manager = new ContactManager();
document.addEventListener("DOMContentLoaded", function () {
    var form = document.getElementById("contactForm");
    var updateForm = document.getElementById("updateForm");
    form.addEventListener("submit", function (event) {
        event.preventDefault();
        var name = document.getElementById("name").value;
        var email = document.getElementById("email").value;
        var phone = document.getElementById("phone").value;
        var newContact = {
            id: Date.now(),
            name: name,
            email: email,
            phone: phone,
        };
        manager.addContact(newContact);
        form.reset();
    });
    updateForm.addEventListener("submit", function (event) {
        event.preventDefault();
        var id = parseInt(document.getElementById("updateId").value);
        var name = document.getElementById("updateName").value;
        var email = document.getElementById("updateEmail").value;
        var phone = document.getElementById("updatePhone").value;
        manager.modifyContact(id, { name: name, email: email, phone: phone });
        updateForm.reset();
    });
});
