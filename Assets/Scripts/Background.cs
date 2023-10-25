using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Background : MonoBehaviour
{
    private Color[] colors = {    
        new Color(0.7f, 0.0f, 0.0f), // Dark Red
        new Color(0.0f, 0.7f, 0.0f), // Dark Green
        new Color(0.0f, 0.0f, 0.7f), // Dark Blue
        new Color(0.7f, 0.7f, 0.0f), // Dark Yellow
        new Color(0.0f, 0.7f, 0.7f), // Dark Cyan
        new Color(0.7f, 0.0f, 0.7f)  // Dark Magenta
        };

    private Camera mainCamera;
    public Image borderImage;


    private void Start()
    {
        mainCamera = Camera.main;
        borderImage = GetComponentInChildren<Image>();
        ChangeColor();
    }

  private void Update()
    {
        // Check for user input (e.g., pressing the spacebar) to change the background color
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeColor();
        }
    }
    private void ChangeColor()
    {
        int randomIndex = Random.Range(0, colors.Length);
        Color selectedColor = colors[randomIndex];

        mainCamera.backgroundColor = selectedColor;
        borderImage.color = selectedColor;
    }
}