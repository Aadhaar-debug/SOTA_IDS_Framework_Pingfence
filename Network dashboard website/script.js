function pingHost() {
    const host = document.getElementById("ping-host").value;
    const xhr = new XMLHttpRequest();
    xhr.open("GET", "https://" + host, true);
    xhr.timeout = 10000;
    xhr.onload = function () 
    {
        const pingTime = new Date() - startTime;
        const pingResult = document.getElementById("ping-result");
        pingResult.innerHTML = "Ping time: " + pingTime + "ms";
        pingResult.classList.add("slide-in");
    };
    xhr.onerror = function () 
    {
        document.getElementById("ping-result").innerHTML = "Ping failed";
    };
    const startTime = new Date();
    xhr.send();
    }

    function measureNetworkSpeed() 
    {
        const startTime = performance.now();
        const fileSize = 1; // 5MB file size for testing
        fetch('https://example.com/file.bin', {
          method: 'GET',
          cache: 'no-cache',
          headers: {
            'Content-Type': 'application/octet-stream',
            'Content-Length': `${fileSize}`
          }
        }).then(response => {
          const endTime = performance.now();
          const duration = (endTime - startTime) / 1000; // convert to seconds
          const speedMbps = (fileSize / duration / 1024 / 1024 * 8).toFixed(2); // calculate Mbps
          document.getElementById("download-speed").innerHTML = speedMbps + " Mbps";
        }).catch(error => {
          console.log(error);
        });
      }
      

    function checkNetworkStatus() {
    const statusIcon = document.getElementById("network-status-icon");
    const statusText = document.getElementById("network-status-text");
    if (navigator.onLine) {
        statusIcon.innerHTML = "&#x2714";
        statusIcon.style.color = "#1abc9c";
    statusText.innerHTML = "Online";
    } else {
    statusIcon.innerHTML = "&#x2716;";
    statusIcon.style.color = "#e74c3c";
    statusText.innerHTML = "Offline";
    }
}



// IP
var xhr = new XMLHttpRequest();
xhr.open('GET', 'https://api.ipify.org', true);
xhr.onload = function() {
    if (this.status === 200) {
        document.getElementById('ip').innerHTML = this.responseText;
    }
};
xhr.send();

// ISP
var xhr2 = new XMLHttpRequest();
xhr2.open('GET', 'https://api.ipify.org/?format=json', true);
xhr2.onload = function() {
    if (this.status === 200) {
        var data = JSON.parse(this.responseText);
        var ip = data.ip;
        var xhr3 = new XMLHttpRequest();
        xhr3.open('GET', 'https://ipwhois.app/json/' + ip, true);
        xhr3.onload = function() {
            if (this.status === 200) {
                var data2 = JSON.parse(this.responseText);
                document.getElementById('isp').innerHTML = data2.isp;
            }
        };
        xhr3.send();
    }
};
xhr2.send();


// Router
document.getElementById('router').innerHTML = location.hostname;

// DNS
var dns = 'example.com';
var xhr = new XMLHttpRequest();
xhr.open('GET', 'https://dns.google/resolve?name=' + dns, true);
xhr.onload = function() {
if (this.status === 200) {
    var data = JSON.parse(this.responseText);
    var ipAddress = data.Answer[0].data;
    console.log('DNS: ' + ipAddress);
    document.getElementById('dns').innerHTML = ipAddress;
}
};
xhr.send();


//speed
// Speed test
function measureNetworkSpeed() {
const startTime = Date.now();
const fileSize = 1024 * 1024 * 10; // 10 MB
const url = "https://speed.hetzner.de/10GB.bin"; // replace with your preferred file URL
const xhr = new XMLHttpRequest();
xhr.open("GET", url + "?r=" + Math.random(), true);
xhr.responseType = "arraybuffer";

xhr.onload = function(e) {
  const endTime = Date.now();
  const duration = (endTime - startTime) / 1000;
  const bitsLoaded = fileSize * 8;
  const speedBps = bitsLoaded / duration;
  const speedMbps = (speedBps / (1024 * 1024)).toFixed(2);
  console.log("Download speed: " + speedMbps + " Mbps");
  document.getElementById("speed").innerHTML = speedMbps;
};

xhr.onerror = function(e) {
  console.error("Error fetching file", e);
};

xhr.send();
}

  

//latency
var xhr = new XMLHttpRequest();
var startTime, latency;

xhr.onreadystatechange = function() {
if (this.readyState === 4) {
    var endTime = new Date().getTime();
    latency = endTime - startTime;
    console.log("Latency: " + latency + "ms");
    document.getElementById("latency").innerHTML = latency + "ms";
}
};

startTime = new Date().getTime();
xhr.open("HEAD", "https://www.google.com", true);
xhr.send();

// Initialize widgets on page load
measureNetworkSpeed();
checkNetworkStatus();