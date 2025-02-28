class Book {
    private isbn: number;
    title: string;
    author: string;
    readonly pages: number;

    constructor(isbn: number, title: string, author: string, pages: number) {
        this.isbn = isbn;
        this.title = title;
        this.author = author;
        this.pages = pages;
    }

    displayDetails() {
        return `${this.isbn} ${this.title} by ${this.author}, ${this.pages} pages`;
    }
}

let book1 = new Book(9780131103627, 'The C# Programming', 'Sai', 274);
console.log(book1.displayDetails());
