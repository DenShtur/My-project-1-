using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    private int V = 35;
    public static int ballCountManager = 1;
    public static int ballCountmin = 5;


    public static int yourScore = 0;

    public static bool showScreenLoseGame = false;
    public string labelText = "Launch the Dogs to catch the balls! Good luck and remember you only have 3 dogs!";

    public int Game
    {
        get { return ballCountmin; }
        set
        {
            ballCountmin = value;

            if (ballCountmin < 5)
            {
                labelText = "You miss " + ballCountManager + " balls ";

                if (ballCountmin == 0)
                {
                    showScreenLoseGame = true;
                    Time.timeScale = 0f;
                    labelText = "";
                }
            }
           
        }
    }

    

    public void Update()
    {
        Debug.Log(ballCountmin);
    }
    private void OnGUI()
    {

       GUIStyle style = new GUIStyle(GUI.skin.label);
        style.fontSize = V;


        GUIStyle style1 = new GUIStyle(GUI.skin.label);
        style1.fontSize = 35;


        GUIStyle style2 = new GUIStyle(GUI.skin.label);
        style2.fontSize = 40;


        GUI.Label(new Rect(Screen.width / 2 - 600, Screen.height - 90,
          30000, 5000), labelText, style);

        GUI.Box(new Rect(20, 20, 300, 50), "Player Health:" + ballCountmin, style);
        GUI.Box(new Rect(20, 60, 300, 50), "Player Score:" + yourScore, style);

        if (showScreenLoseGame)
        {
            GUI.Box(new Rect(Screen.width / 2 - 100,Screen.height / 2 - 150, 20000, 100), "YOU LOSE!", style1);
            GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 250, 2000, 100), "SCORE "+ yourScore, style2);


            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 100), "RESTART"))
            {  // 3
                SceneManager.LoadScene(0);
                // 4
                Time.timeScale = 1.0f;

                ballCountManager = 1;
                ballCountmin = 5;
                 PlayerControllerX.dogCount = 3;
                yourScore = 0;
                showScreenLoseGame = false;

            }
        }
    }
}
