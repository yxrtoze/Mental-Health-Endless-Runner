using UnityEngine;
using UnityEngine.SceneManagement;

public class CharMovement : MonoBehaviour
{
    private readonly float[] lanes = { -3f, 0f, 3f };
    private int currentLane = 1;

    private Animator animator;

    public float laneSwitchSpeed = 5f; // Speed for lane transitions
    public PositivityMeterManager positivityMeterManager;

    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("isRunning", true);

        if (positivityMeterManager == null)
        {
            Debug.LogError("PositivityMeterManager is not assigned!");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) && currentLane > 0) currentLane--;
        if (Input.GetKeyDown(KeyCode.A) && currentLane < lanes.Length - 1) currentLane++;
        MoveToLane();
    }

    private void MoveToLane()
    {
        Vector3 targetPosition = new Vector3(lanes[currentLane], transform.position.y, transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, laneSwitchSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "PositiveCoin":
                positivityMeterManager.IncreasePositivity();
                Destroy(other.gameObject);
                break;

            case "NegativeCoin":
                positivityMeterManager.DecreasePositivity();
                Destroy(other.gameObject);
                break;

            case "Obstacle":
                Debug.Log("Hit an obstacle! Switching to NegativeScene...");
                SceneManager.LoadScene("NegativeScene");
                break;

            default:
                Debug.LogWarning("Unhandled collision with tag: " + other.tag);
                break;
        }
    }
}
