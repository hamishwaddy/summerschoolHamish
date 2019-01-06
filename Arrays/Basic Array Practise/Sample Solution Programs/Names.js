/*
Title:  Names
Make sure you place relevant comments here and throughout your program
*/

//
let names = []

let message = "Enter 5 names.\nEnter name"

//
for (let i = 0; i < 5; i++){
    names[i] = prompt(`${message} ${i + 1}: `)
    console.log(`${i + 1}. ${names[i]}`)
}

console.log("")

//
console.log(`The first name entered is : ${names[0]}`)
console.log(`The last  name entered is : ${names[4]}`)