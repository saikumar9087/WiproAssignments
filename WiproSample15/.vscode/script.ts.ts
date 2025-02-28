interface Contact {
  id: number;
  name: string;
  email: string;
  phone: string;
}

class ContactManager {
  private contacts: Contact[] = [];

  addContact(contact: Contact): void {
    this.contacts.push(contact);
    console.log("Contact added successfully.");
    this.updateContactList();
  }

  viewContacts(): Contact[] {
    return this.contacts;
  }

  modifyContact(id: number, updatedContact: Partial<Contact>): void {
    const contact = this.contacts.find(c => c.id === id);
    if (!contact) {
      alert("Error: Contact not found.");
      return;
    }
    Object.assign(contact, updatedContact);
    alert("Contact modified successfully.");
    this.updateContactList();
  }

  deleteContact(id: number): void {
    const index = this.contacts.findIndex(c => c.id === id);
    if (index === -1) {
      alert("Error: Contact not found.");
      return;
    }
    this.contacts.splice(index, 1);
    alert("Contact deleted successfully.");
    this.updateContactList();
  }

  private updateContactList(): void {
    const contactList = document.getElementById("contactList") as HTMLDivElement;
    contactList.innerHTML = "";

    this.contacts.forEach(contact => {
      const contactDiv = document.createElement("div");
      contactDiv.textContent = `${contact.name} - ${contact.email} - ${contact.phone} `;
      
    
      const deleteBtn = document.createElement("button");
      deleteBtn.textContent = "Delete";
      deleteBtn.onclick = () => this.deleteContact(contact.id);

   
      const updateBtn = document.createElement("button");
      updateBtn.textContent = "Update";
      updateBtn.onclick = () => this.populateUpdateForm(contact);

      contactDiv.appendChild(updateBtn);
      contactDiv.appendChild(deleteBtn);
      contactList.appendChild(contactDiv);
    });
  }

  private populateUpdateForm(contact: Contact): void {
    (document.getElementById("updateId") as HTMLInputElement).value = contact.id.toString();
    (document.getElementById("updateName") as HTMLInputElement).value = contact.name;
    (document.getElementById("updateEmail") as HTMLInputElement).value = contact.email;
    (document.getElementById("updatePhone") as HTMLInputElement).value = contact.phone;
  }
}

const manager = new ContactManager();

document.addEventListener("DOMContentLoaded", () => {
  const form = document.getElementById("contactForm") as HTMLFormElement;
  const updateForm = document.getElementById("updateForm") as HTMLFormElement;

  form.addEventListener("submit", (event) => {
    event.preventDefault();
    const name = (document.getElementById("name") as HTMLInputElement).value;
    const email = (document.getElementById("email") as HTMLInputElement).value;
    const phone = (document.getElementById("phone") as HTMLInputElement).value;
    
    const newContact: Contact = {
      id: Date.now(),
      name,
      email,
      phone,
    };

    manager.addContact(newContact);
    form.reset();
  });

  updateForm.addEventListener("submit", (event) => {
    event.preventDefault();
    const id = parseInt((document.getElementById("updateId") as HTMLInputElement).value);
    const name = (document.getElementById("updateName") as HTMLInputElement).value;
    const email = (document.getElementById("updateEmail") as HTMLInputElement).value;
    const phone = (document.getElementById("updatePhone") as HTMLInputElement).value;

    manager.modifyContact(id, { name, email, phone });
    updateForm.reset();
  });
});
