using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private float _jumpForce;
    [SerializeField] public Transform GroundCheck;
    [SerializeField] public LayerMask _groundMask;
    [SerializeField] private bool _groundCheck = false;
    [SerializeField] private float _radiusCheck;
    [SerializeField] private Recorder recorder;

    private Rigidbody2D playerRigidbody2D;
    private Animator playerAnimation;
    KeyCode key;
    private void Start()
    {
        playerRigidbody2D = GetComponent<Rigidbody2D>();
        playerAnimation = GetComponent<Animator>();
    }
    private void Update()
    {
        _groundCheck = Physics2D.OverlapCircle(GroundCheck.position, _radiusCheck, _groundMask);
        playerAnimation.SetBool("groundCheck", _groundCheck);
        if ((Input.GetKeyDown(KeyCode.W) == true || Input.GetKeyDown(KeyCode.UpArrow)) && _groundCheck == true)
        {
            Jump(_jumpForce);
        }
    }

    private void Jump(float jumpForce)
    {
        playerRigidbody2D.AddForce(transform.up * _jumpForce, ForceMode2D.Impulse);
        playerAnimation.SetTrigger("Jump");
    }
    private void OnDestroy()
    {;
        if (recorder._record > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", recorder._record);
            Debug.Log(recorder._record);
        }
        SceneManager.LoadScene("FailScene");
    }
}
