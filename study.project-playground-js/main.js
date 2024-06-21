// l
if (/Edge/.test(navigator.userAgent)) {
  // Code specific to Microsoft Edge
}

const toggleButton = document.getElementsByClassName('toggle-button')[0];
const navbarLinks = document.getElementsByClassName('navbar-links')[0];

toggleButton.addEventListener('click', () => {
  navbarLinks.classList.toggle('active');
});
//------------------------------------------//

//  toggle text function
function fun1() {
  var x = document.getElementById('swappDemo');
  if (x.innerText === 'hello demo') {
    //then
    x.innerText = 'Swapped text'; //set it to this
  } else {
    x.innerText = 'hello demo'; //turn it back to default
  }
}

//--------interactive age validation function //----------//

function fun2() {
  let a = parseInt(prompt('Enter your age: 18 || 20 || 22 ', 18));
  let i = 2;
  while (i < 1) {
    switch (true) {
      case a !== 20 && a > 22:
        a = parseInt(prompt('Please enter another age : ', 18));
        continue;

      case a === 18:
        confirm('Young : ' + a);
        break;

      case a < 18:
        confirm('You are too young: ' + a);
        a = parseInt(prompt('Please enter another age : ', 18));
        continue;

      case a > 18 && a < 22:
        confirm('You are middle age : ' + a);
        break;

      case a === 22:
        confirm('You are Old : ' + a);
        break;

      case a > 22:
        a = parseInt(prompt('Please enter another age : ', 18));
        continue;

      default:
        break;
    }
    i++;
  }
}
//-----------------------------------------//
