/*
Title:   Calculate BMI
Author:  Stefan
Date:    March 2018
Purpose: Given a person's weight (kg) and height (cm), calculate the person's Body Mass Index (BMI). 
         From the BMI determine the BMI category - either Obese, Overweight, Normal Weight or Underweight.
          NOTE: A function is used to calculate the BMI.
                Another function is used to determine the BMI category.
*/

//Declare Functions

//Function Name: calcBMI
//Parameters:    Person's weight (in kg) and height (in cm)
//Purpose:       Calculates and returns the Body Mass Index (BMI)
let calcBMI = (weight, height) => {
    return weight / (height / 100) ** 2          //height in cm, needs to be divided by 100 to convert to metres
}

//Function Name: bmiCategory
//Parameters:    The body mass index
//Purpose:       Determines and returns the Body Mass Index (BMI) Category
let bmiCategory = (bmi) => {
    //Determine the BMI Category from the calculated Body Mass Index
    if (bmi > 30) {
        return "Obese"                                              //BMI >= 30, category is Obese
    } else if (bmi > 25 && bmi <= 30) {
        return "Overweight"                                         //25 <= BMI < 30, category is Overweight
    } else if (bmi > 18.5 && bmi <= 25) {
        return "Normal Weight"                                      //18.5 <= BMI < 25, category is Normal Weight
    } else {
        return "Underweight"                                        //If none of the above, BMI category must be Underweight
    }
}


//Declare variables
let inputWeight                  //Weight of person in kg (user input)
let inputHeight                  //Height of person in cm (user input)
let bodyMassIndex                //Calculated Body Mass Index (output)
let category                     //BMI Category (output)             


//Prompt for and get input from user
inputWeight = Number(prompt("Body Mass Index (BMI) Calculator.\nEnter the person's weight (kg):"))       //Person's weight (kg)
inputHeight = Number(prompt("Body Mass Index (BMI) Calculator.\nEnter the person's height (cm):"))       //Person's height (cm)


//Use the "calcBMI" function to determine the BMI
bodyMassIndex = calcBMI(inputWeight, inputHeight)

//Use the "bmiCategory" function to determine the BMI Category
category = bmiCategory(bodyMassIndex)



//Display heading
console.log("")
console.log("Body Mass Index Calculator")
console.log("--------------------------")
console.log("")


//Display the input weight and height and the BMI results 
console.log(`Person's weight : ${inputWeight} kg`)                       //Display person's weight
console.log(`Person's height : ${inputHeight} cm`)                       //Display person's height

console.log(`Body Mass Index : ${bodyMassIndex.toFixed(1)}`)             //Display Body Mass Index
console.log("------------------------")
console.log(`BMI Category    : ${category}`)                             //Display BMI category                        
console.log("")