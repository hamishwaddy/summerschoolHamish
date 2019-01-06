/*
Title:  Minimum and Maximum
Make sure you place relevant comments here and throughout your program
*/

//Comment
let numbers = []                                    //Comment
let message = "Enter 5 numbers.\nEnter number"      //Comment
let minNum                                          //Comment
let maxNum                                          //Comment


//Comment
console.log("\nNumbers displayed as entered:\n-----------------------------\n")


//LOOP 1 - "for"
//Comment (Get numbers from the user, put them in the array and display as entered)
for (let i = 0; i < 5; i++){
    numbers[i] = Number(prompt(`${message} ${i + 1} (Array Index ${i}): `))
    console.log(`Number ${i +1} (Array Index ${i}): ${numbers[i]}`)
}

console.log("")


//LOOP 2 - "for"
//Comment (Determine the min and max numbers)
for (let i = 0; i < 5; i++){
   if (i == 0){
        minNum = numbers[i]
        maxNum = numbers[i]
   }
   else {
       if (numbers[i] > maxNum) {
            maxNum = numbers[i]
       } else if (numbers[i] < minNum){
            minNum = numbers[i]
       }

   }
}

console.log("")


//Comment (Display the min and max numbers)
console.log(`The minimum number is: ${minNum}`)
console.log(`The maximum number is: ${maxNum}`)
