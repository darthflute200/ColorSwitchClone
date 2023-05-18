using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rhodos.Toolkit;

public class Ball : MonoBehaviour
{
    public List<Color> Renkler;
    public int Colorindex;
    public Colors colours;
    public obstacle Obstacle;
    public bool nextLevel = true;
    public LevelManager levelmanager;
    private Rigidbody2D rb;
    public SpriteRenderer sr;
    public Colors CurrentColor;
    
    [SerializeField] private float Jump;

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
        {
        if ( != Obstacle.colors)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (collision.CompareTag("Next Level"))
        {
            nextLevel = true;
            levelmanager.GetLevel();

        }
        
    }
    private void SetRandomColor()
    {
        int index = Random.Range(0, 4);
        CurrentColor = (Colors)index;
        sr.color = Renkler[index];
        
    }

    
}
public enum Colors
{
    Cyan,
    Pink,
    Purple,
    Yellow
}