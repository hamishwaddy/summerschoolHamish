/*
Title:  Two Arrays
Make sure you place relevant comments here and throughout your program
*/

//Comment
let firstArray = []                                                     //Comment
let secondArray = []                                                    //Comment
let message = "Enter 5 numbers into the first array.\nEnter number"     //Comment
let string = ""                                                         //Comment


//Comment
console.log("\nNumbers displayed when input and entered into the first array:\n--------------------------------------------------------------\n")

 
//LOOP 1
//Comment  (Get user input and display the input as it is entered)
for (let i = 0; i < 5; i++){
    firstArray[i] = Number(prompt(`${message} ${i + 1} (Array Index ${i}): `))
    console.log(`Number ${i +1} (Array Index ${i}): ${firstArray[i]}`)
}

console.log("")


//LOOP 2
//Comment (Copy items from first array to second array)
for (let i = 0; i < 5; i++){
    secondArray[i] = firstArray[i]
}

//Message to indicate the copy between arrays has occurred 
console.log("Items have been copied from the first array to the second array.\n\n")

//LOOP 3 - FOR...OF
//Comment  (Build the output string containing the items in the second array)
for (let x of secondArray){
    string = string + x + "  "
}


//Comment  (Output the string containing the items in the second array)
console.log(`Second array items      : ${string}\n`)