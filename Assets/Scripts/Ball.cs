using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    public int levelpoint = 0;
    public LevelManager levelmanager;
    private Rigidbody2D rb;
    public SpriteRenderer sr;
    private string CurrentColor;
    [SerializeField] private float Jump;
    public Color ColorCyan;
    public Color ColorPink;
    public Color ColorYellow;
    public Color ColorPurple;
    private void Zip()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0f, Jump), ForceMode2D.Impulse);
        }
        
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        SetRandomColor();
        


    }
    private void Update()
    {
        Zip();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ColorChanger"))
        {
            SetRandomColor();
            Destroy(collision.gameObject);
            return;
        }
        if (collision.tag != CurrentColor)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (collision.CompareTag("Next Level"))
        {
            levelpoint = 1;
            levelmanager.GetLevel();

        }
        
    }
    private void SetRandomColor()
    {
        int index = Random.Range(0, 4);
        switch (index)
        {
            case 0:
                CurrentColor = "Cyan";
                sr.color = ColorCyan;
                break;
            case 1:
                CurrentColor = "Purple";
                sr.color = ColorPurple;
                break;
            case 2:
                CurrentColor = "Yellow";
                sr.color = ColorYellow;
                break;
            case 3:
                CurrentColor = "Pink";
                sr.color = ColorPink;
                break;

        }
    }


}
