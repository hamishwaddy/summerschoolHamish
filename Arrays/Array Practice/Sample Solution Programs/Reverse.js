/*
Title:  Reverse
Make sure you place relevant comments here and throughout your program
*/

//Comment
let numbers = []                                    //Comment
let message = "Enter 5 numbers.\nEnter number"      //Comment


//Comment
console.log("\nNumbers displayed as entered:\n-----------------------------\n")


//Comment
for (let i = 0; i < 5; i++){
    numbers[i] = Number(prompt(`${message} ${i + 1} (Array Index ${i}): `))
    console.log(`Number ${i +1} (Array Index ${i}): ${numbers[i]}`)
}

console.log("")

//Comment
console.log("\nNumbers displayed in reverse:\n-----------------------------\n")

//Comment
for (let i = 4; i >= 0; i--){
    console.log(`Number ${i +1} (Array Index ${i}): ${numbers[i]}`)
}
