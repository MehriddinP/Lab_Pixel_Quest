using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public Transform respawPoint;
    private int _health = 3;
    private int _maxHealth = 3;
    public string nextLevel = "GeoLevel2";
    private int coinCounter = 0;
  private void OnTriggerEnter2D(Collider2D collision)
  {
    switch (collision.tag)
    {
        case "Death":
            {
              
                    _health--;
                    if (_health < 0)
                    {
                        string thisLevel = SceneManager.GetActiveScene().name;
                        SceneManager.LoadScene(thisLevel);
                    }
                    else
                    {
                        transform.position = respawPoint.position;
                    }
                        break;


            }
        case "Coin":
                {
                    coinCounter++;
                    Destroy(collision.gameObject);
                    break;
                }

        case "Finish":
            {
                    string nextLevel = collision.transform.GetComponent<LevelGoal>().nextLevel;
                SceneManager.LoadScene(nextLevel);
                break;
            }
        case "Health":
                {
                    _health++;
                    Destroy(collision.gameObject);
                    if (_health < _maxHealth)

                    {
                        Destroy(collision.gameObject);
                    }
                    break;

                }
    }
  }
}
