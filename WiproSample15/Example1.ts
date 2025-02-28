function sum(x: number = 10, y?: number): number {
    if (typeof y !== 'undefined') {
        return x + y;
    }
    return x + x;
}

console.log(sum(20, 30));
console.log(sum(30));     
console.log(sum()); 


function getAverage(...numbers: number[]): number {
    let total = 0;
    numbers.forEach((num) => total += num); 
    if (numbers.length === 0) {
        return 0; 
    }
    return total / numbers.length;
}

console.log(getAverage(10, 40, 60, 70, 70));
console.log(getAverage(10, 40));            
console.log(getAverage());                  
