/*
Title:  CrankWorx
Make sure you place relevant comments here and throughout your program
*/

//
let medals = []

let title = "*******************************************************\n" + 
            "***   Welcome to the CrankWorx Medal Awards   ***\n" + 
            "*******************************************************\n" + 
            "\n"

let question =  "Which medal holder would you like to see dsplayed?" + "\n"
                "1. GOLD" + "\n" +
                "2. SILVER" + "\n" +
                "3. BRONZE" + "\n" +
                "\n" +
                "Enter option 1, 2 or 3:"

let answer

//Get user input
medals[0] = prompt (`${title}Enter the name of the GOLD medal winner: `)
medals[1] = prompt (`${title}Enter the name of the SILVER medal winner: `)
medals[2] = prompt (`${title}Enter the name of the BRONZE medal winner: `)

//Get user's answer/response to the question
answer = Number(prompt(question))

//Display name of medal winner
confirm (`That medal winner is: ${medals[answer - 1]}`)
