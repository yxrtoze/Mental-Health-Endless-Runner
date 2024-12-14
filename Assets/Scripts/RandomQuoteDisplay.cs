using UnityEngine;
using TMPro; // Import the TextMeshPro namespace

public class RandomQuoteDisplay : MonoBehaviour
{
    // UI TextMeshProUGUI component to display the quote
    public TextMeshProUGUI quoteText; // Change this to TextMeshProUGUI

    // List of motivational quotes
    private string[] quotes = {
    "DON'T GIVE UP, TRY AGAIN!",
    "COME ON, LET'S PLAY AGAIN! WHAT IF YOU WIN THIS TIME?",
    "BELIEVE IN YOURSELF. YOU CAN DO IT!",
    "FAILURE IS THE KEY TO SUCCESS. TRY AGAIN!",
    "KEEP PUSHING. EVERY STEP FORWARD COUNTS.",
    "THE HARDER YOU WORK, THE LUCKIER YOU GET!",
    "DON'T STOP NOW, YOUR VICTORY IS NEAR!",
    "SUCCESS IS JUST ONE MORE TRY AWAY.",
    "YOU ARE STRONGER THAN YOU THINK.",
    "IT'S OKAY TO FAIL, IT'S PART OF THE JOURNEY.",
    "STAY POSITIVE AND KEEP MOVING FORWARD.",
    "IF YOU FALL, GET BACK UP AND TRY AGAIN.",
    "GREAT THINGS NEVER COME FROM COMFORT ZONES.",
    "SUCCESS IS NOT FINAL, FAILURE IS NOT FATAL. KEEP GOING!",
    "DON'T COUNT THE DAYS, MAKE THE DAYS COUNT."
};

    void Start()
    {
        // Display a random quote when the scene starts
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
