//l

// Task4 -1
// Create Class with methods
// Class Flower: Properties:
//  Type (like Rose), Color, Amount ( how many), inStore ( false/true)
// Methods:
// change Amount, change color, change is inStore false/True
// Change color, amount, instore
// OUTPUT: Original situation:
// Flower { Type: 'Rose', Color: 'Red', Amount: 5, inStore: Yes }
//       After changes:
// Flower { Type: Rose , Color: Yellow , Amount: 4 , inStore: No }

//assigning the constructor property to an object...??????
// what

//step 1 created a class Flower with a
// type property asking what type of flower
class Flower {
  constructor(type, color, amount, instore) {
    (this.type = type), //what is the type of flower?
      (this.color = color),
      (this.amount = amount),
      (this.instore = instore);
  }
}
const oldFlower = new Flower("Rose", "Red", 5, true);
const newFlower = new Flower(
  oldFlower.type,
  oldFlower.color, //oldflower become newflower
  oldFlower.amount,
  oldFlower.instore
);
// console.log(oldFlower);

//this is oldflower
if (oldFlower) {
  console.log("Original situation..");
  oldFlower.instore = "yes";
  console.log(oldFlower);
}

//changing the flower
newFlower.type = "Rose";
newFlower.color = "Yellow";
newFlower.amount = 4;
newFlower.instore = false;

//is still oldflower?
if (!newFlower.instore) {
  newFlower.instore = "no";
  console.log("yes data has been changed..");
  console.log(newFlower);
} else {
  console.log(oldFlower);
}
