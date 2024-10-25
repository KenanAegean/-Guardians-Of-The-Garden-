using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{
    [SerializeField] int baseStars = 300;
    float stars;
    Text starText;
    
    // Start is called before the first frame update
    void Start()
    {
        stars = baseStars - (50 * PlayerPrefsController.getDifficulty());
        starText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        starText.text = stars.ToString();
    }

    public bool HaveEnoughStars(int amount)
    {
        return amount <= stars;
    }

    public void AddStars(int amount)
    {
        stars += amount;
        UpdateDisplay();
    }

    public void SpendStars(int amount)
    {
        if (stars >= amount)
        {
            stars -= amount;
            UpdateDisplay();
        }
        
    }
}
