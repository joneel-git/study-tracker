

// l

// -------------------Task2-------------------------;
// OUTPUT:    18 : Young
//            20 : Middle age
//           22 : Old
//                                        // Tips: Ask input age as long as
//                                         SWITCH

//             first tried with while loop
//             try again with do-While

let age;

do {
  let age = parseInt(prompt('What is your age? '));

  switch (true) {
    case age == 18:
      confirm('Young');
      break;

    case age == 22:
      confirm('Old');
      break;

    case age > 18 && age < 22:
      confirm('Middle');12
      break;

    default:
    case age < 18 || age > 22:
      age = parseInt(prompt('enter another age 18 / 22 ', 18));
  }
} while (age < 18 || age > 22);

//good to keep in mind 

// Just call the function that your switch block 
// code is in again for case default.

// For example:

// function askForLetter() {
//     var anyLetter; 
//     anyLetter = prompt("Enter one of the following letters (b, o, or h): "); 

//     switch(anyLetter){
//         case "b": 
//         case "B": 
//             //code if user enters b or B
//         break; 
//         case "o": 
//         case "O": 
//             //code 
//         break; 
//         case "h": 
//         case "H": 
//             //code
//         break; 
//         default:
//             askForLetter();  
//     }
// }

// While all the answers above are correct, 
// I need to point out one will need additional modification 
// of the conditions when you need to include new option 
// and second will have hard time retrieving the letter 
// itself in this state which is easily fixable, however 
// because of its recursive nature it might lead to 
// stack overflow (note the irony) in some extreme scenarios. 
// Here is my version of the code:

// var anyLetter = ''; 
// while (anyLetter == '')
// {
//     anyLetter = getMyLetter();
// }
// console.log("MyLetter:", anyLetter);

// function getMyLetter()
// {
//     var letter = prompt("Enter one of the following letters (b, o, or h): "); 
//     switch(letter)
//     {
//         case "b": 
//         case "B": 
//         {
//             //code if user enters b or B
//             break; 
//         }
//         case "o": 
//         case "O": 
//         {
//             //code 
//             break; 
//         }
//         case "h": 
//         case "H": 
//         {
//             //code
//             break; 
//         }

//         default: 
//         {
//             letter = '';
//         }

//     }
//     return letter;
// }