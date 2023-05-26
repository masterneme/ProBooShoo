using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private void Awake() 
    { 
        // If there is an instance, and it's not me, delete myself.
        
        if (Instance != null && Instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } 
    }
    // Start is called before the first frame update
    private void Start()
    {
        LoadMain();
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.Log("Update from GameManager");
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Input from GameManager");
        }
    }
    private void LoadMain()
    {
        SceneManager.LoadScene("main");
    }
}