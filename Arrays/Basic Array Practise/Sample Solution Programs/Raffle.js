/*
Title:  Raffle
Make sure you place relevant comments here and throughout your program
*/

//
let tickets =   ["Wiremu", "Hemi", "Alex", "Kahu", "Karamjeet",
                "Ngaire", "Prabjot", "Janet", "Kim", "Hinewai",
                "Henare", "Vikram", "David", "Hohepa", "Arnav",
                "Chloe", "Sharon", "Saanvi", "Zoya", "Pounamu"]

let winner

//Heading
console.log("")
console.log("The 20 raffle tickets:")

//Display the 0 names of the raffle ticket holders
for (let i = 0; i < 20; i++){
    console.log(`Ticket ${i + 1}: ${tickets[i]}`)
}

console.log("")

//Generate a random number between 0 and 19
winner = Math.floor(Math.random() * 20)

//Display the winning ticket number (1 to 20)
console.log(`The winning ticket number is: ${winner + 1}`)

console.log("")

//Display the name of the winner
console.log (`***************************************************\n` +
             `The winner of $1,000,000 is ${tickets[winner]} \n` +
             `***************************************************\n`)
