// Task3

// Create Array “Dog”,”Horse”,”Cow”
// a) PrintOut Array,
// OUTPUT:         Dog
//                 Horse
//                 Cow

// b) Copy Array to new Array  ( use Map )
// Add to new Array new columns “Cat”, “Sheep”
// OUTPUT: New array:  [ 'Dog', 'Horse', 'Cow', 'Cat', 'Sheep' ]

// c) 1) Search “Cow” from new Array.  2) Search "Co".
// OUTPUT:    Search result:  Cow, Founded
//                     Search result:  Co,  Not found

const animalsArray = ['Dog', 'Horse', 'Cow'];
let newArray = animalsArray.map(function (animal) {
  return animal;
});
console.log(newArray);

newArray.push('Cat', 'Sheep');
console.log(newArray);

//cow exsists in array?
const searchItem = 'Cow';
 
if (animalsArray.includes(searchItem)) {
    console.log('Item found');
} else {
    console.log('Item not found');
}



