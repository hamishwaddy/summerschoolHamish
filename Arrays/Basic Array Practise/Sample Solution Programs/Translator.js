/*
Title:  Translator
Make sure you place relevant comments here and throughout your program
*/

//
let helloArray = ["Kia ora", "Kon'nichiwa", "Namaste", "Bonjour", "Talofa"]

let message =   "I can traslate 'hello' in 5 different languages:\n" +
                "1. Maori\n" +
                "2. Japanese\n" +
                "3. Hindi\n" +
                "4. French\n" +
                "5. Samoan\n\n" +
                "Which langauage translation do you wish to see (1 to 5)?"

//Get user input
answer = Number(prompt(`${message}`))

//Output 
confirm(`Your selected translation: ${answer}\n` + 
        `Hello is translated as      : ${helloArray[answer - 1]}`)


