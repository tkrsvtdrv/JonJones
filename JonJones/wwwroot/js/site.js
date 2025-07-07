function showQuote() {
    const quotes = [
        "Hard work beats talent when talent doesn't work hard.",
        "You have to believe in yourself when no one else does.",
        "Bones never breaks.",
        "I’m not the best because I talk the best — I am the best because I fight the best."
    ]

    const random = quotes[Math.floor(Math.random() * quotes.length)]
    document.getElementById("quoteArea").innerText = random
}
