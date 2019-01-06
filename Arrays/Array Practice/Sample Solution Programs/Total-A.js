/*
Title:  Total A
        Uses two for loops.
        (WITHOUT using the "for...of" loop)

Make sure you place relevant comments here and throughout your program
*/

//Comment
let numbers = []                                    //Comment
let howMany                                         //Comment
let total = 0                                       //Comment
let string = ""                                     //Comment

howMany = Number(prompt("How many numbers do you want to store in the array?"))


//Comment
console.log("\nNumbers displayed as entered:\n-----------------------------\n")


//LOOP 1 - FOR
//Comment  (Get user input and display the input as it is entered)
for (let i = 0; i < howMany; i++){
    numbers[i] = Number(prompt(`Number ${i + 1} (Array Index ${i}): `))
    console.log(`Number ${i +1} (Array Index ${i}): ${numbers[i]}`)
}

//LOOP 2 - FOR
//Comment  (Generate the total and build the output string containing the array items)
for (let i = 0; i < howMany; i++){
    total = total + numbers[i]
    string = string + numbers[i] + ", "
}


console.log("")

//Comment  (Output the string containing the array items, output total)
console.log(`Array items entered        : ${string}\n`)
console.log(`Total of these array items = ${total}`)
