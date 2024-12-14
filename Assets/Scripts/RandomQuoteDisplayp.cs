using UnityEngine;
using TMPro; // Import the TextMeshPro namespace

public class RandomQuoteDisplayp : MonoBehaviour
{
    // UI TextMeshProUGUI component to display the quote
    public TextMeshProUGUI quoteText; // Change this to TextMeshProUGUI

    // List of positive and motivational quotes
    private string[] quotes = {
    "YAY! YOU DID IT, YOU'RE AMAZING!",
    "KEEP UP THE GREAT WORK, YOU'RE UNSTOPPABLE!",
    "YOU'RE ON FIRE! KEEP GOING!",
    "AWESOME JOB, YOU ARE INCREDIBLE!",
    "YOU DID IT! NEVER STOP BELIEVING!",
    "YOU'RE A ROCKSTAR! KEEP SHINING!",
    "SUCCESS IS YOURS! KEEP PUSHING FORWARD!",
    "YOU ARE CAPABLE OF AMAZING THINGS!",
    "YOU JUST TOOK ONE STEP CLOSER TO YOUR GOALS!",
    "YOU'RE DOING AN AMAZING JOB, STAY STRONG!",
    "YOUR EFFORT IS PAYING OFF, KEEP IT UP!",
    "GREAT THINGS ARE COMING YOUR WAY!",
    "THE SKY'S THE LIMIT, KEEP REACHING!",
    "BELIEVE IN YOURSELF, YOU'RE ALREADY A WINNER!",
    "YOU'RE THE BEST! KEEP IT UP, CHAMPION!",
    "SUCCESS IS NOT A DESTINATION, IT'S A JOURNEY. KEEP GOING!",
    "YOU ARE ONE STEP CLOSER TO YOUR DREAMS, KEEP MOVING!",
    "KEEP SMILING, KEEP WINNING, YOU'RE UNSTOPPABLE!",
    "YOU'RE NOT JUST GOOD, YOU'RE AMAZING!",
    "STAY POSITIVE, STAY MOTIVATED, YOU'VE GOT THIS!"
};


    void Start()
    {
        // Display a random positive quote when the scene starts
        DisplayRandomQuote();
    }

    void DisplayRandomQuote()
    {
        // Pick a random index from the quotes array
        int randomIndex = Random.Range(0, quotes.Length);
        string randomQuote = quotes[randomIndex];

        // Display the selected quote on the UI TextMeshProUGUI component
        if (quoteText != null)
        {
            quoteText.text = randomQuote;
        }
        else
        {
            Debug.LogError("Quote TextMeshProUGUI component is not assigned!");
        }
    }
}
