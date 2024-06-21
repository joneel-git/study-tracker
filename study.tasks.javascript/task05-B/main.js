// l

var ImageList = document.getElementById("ImageList");
var imageArea = document.getElementById("imageArea");
var displayText = document.getElementById("displayText");
// Set the content of the image area to the selected value from the dropdown
function displaySelectedValue() {
  imageArea.src = ImageList.value;
}
console.log(ImageList);
console.log(imageArea);
//simulate clicking on image with text function
function text() {
  var text = "No need to click picture \n";
  displayText.innerText += text;
}

imageArea.addEventListener("mouseover", function () {
  displayText.style.marginTop = "50px";
  displayText.style.display = "block";
});
imageArea.addEventListener("mouseleave", function () {
  displayText.style.display = "none";
  displayText.innerText = "";
});
