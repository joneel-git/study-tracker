// Task4-2

// (first DOM)

// Create JavaScript code to add text to an HTML. Add the text to main section. Text is "Ad astra per aspera".

// Copy the html code on the right side into your own index.html.

let maincontent = document.querySelector(".maincontent");
console.log(maincontent);

let html = (maincontent.innerHTML += "<h1>Ad astra per aspera</h1>");
