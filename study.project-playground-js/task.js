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
