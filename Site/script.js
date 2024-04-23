var numberElement = document.getElementById("number");
var limit = 330;
var duration = 5000; // 3 seconds
var increment = limit / duration;
var startTime = null;
function updateNumber(timestamp) {
    if (!startTime) startTime = timestamp;
    var elapsedTime = timestamp - startTime;
    var currentValue = Math.min(Math.floor(increment * elapsedTime), limit);
    numberElement.textContent = currentValue;
    if (currentValue < limit) {
        requestAnimationFrame(updateNumber);
    }
}
requestAnimationFrame(updateNumber);


// For number2
var numberElement2 = document.getElementById("number2");
var limit2 = 972;
var duration2 = 5000; // 2 seconds
var increment2 = limit2 / duration2;
var startTime2 = null;

function updateNumber2(timestamp) {
    if (!startTime2) startTime2 = timestamp;
    var elapsedTime2 = timestamp - startTime2;
    var currentValue2 = Math.min(Math.floor(increment2 * elapsedTime2), limit2);
    numberElement2.textContent = currentValue2;
    if (currentValue2 < limit2) {
        requestAnimationFrame(updateNumber2);
    }
}

requestAnimationFrame(updateNumber2);

// For number3
var numberElement3 = document.getElementById("number3");
var limit3 = 40;
var duration3 = 5000; // 2 seconds
var increment3 = limit3 / duration3;
var startTime3 = null;

function updateNumber3(timestamp) {
    if (!startTime3) startTime3 = timestamp;
    var elapsedTime3 = timestamp - startTime3;
    var currentValue3 = Math.min(Math.floor(increment3 * elapsedTime3), limit3);
    numberElement3.textContent = currentValue3;
    if (currentValue3 < limit3) {
        requestAnimationFrame(updateNumber3);
    }
}

requestAnimationFrame(updateNumber3);

document.addEventListener('DOMContentLoaded', function() {
    const carouselSlide = document.querySelector('.carousel-slide');
    const reviews = document.querySelectorAll('.review');
  
    let counter = 0;
    const size = reviews[0].clientWidth;
    const visibleReviews = 3;
  
    function nextSlide() {
      if (counter >= reviews.length - visibleReviews) {
        counter = 0; // Reset counter to loop back to the first review
      } else {
        counter++;
      }
      carouselSlide.style.transform = `translateX(${-size * counter}px)`;
    }
  
    function autoScroll() {
      setInterval(() => {
        nextSlide();
      }, 2000); // Change the interval (in milliseconds) here as needed
    }
  
    autoScroll();
  });
  