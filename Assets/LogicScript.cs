using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class LogicScript : MonoBehaviour
{

    public AudioSource pointa;
  
    //audio
    public GameObject S2;
    public GameObject S3;
    public GameObject S4;
    //gameover
    public GameObject game_over;
    //life
    Life life_logic;
    
    //point and name
    public Text pointtext;
    int point=0;
    string username = ButtonScript.name;
    private void Update()
    {
        if (life_logic.curensprite > 3)
        {
            GameOver();
          
        }
        if (point==5) {
            S2.SetActive(true);
        }
        if(point==20)
        {
            S3.SetActive(true);
        }   
        if(point==40)
        {
            S4.SetActive(true);
        }
       
    }
    public void Mainmenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
       
    }
    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       
    }

    void Start()
    {
   

        life_logic = GameObject.FindGameObjectWithTag("life").GetComponent<Life>();
    }

  
    public void GameOver()
    {
     
        game_over.SetActive(true);

    }

    
    public void SubLife()
    {
        
        life_logic.lifecondition();
        
    }
    public void AddPoint()
    {
        pointa.Play();
        point += 1;
        pointtext.text = point.ToString();
    }

  
       // string connectionString = "server=yourServer;database=yourDatabase;user=yourUser;password=yourPassword";
       //   MySqlConnection connection = new MySqlConnection(connectionString);
       // connection.Open();

       // int score = 100; 
       // string playerName = "Tên người chơi"; 

       // string query = "INSERT INTO high_scores (player_name, score) VALUES (@playerName, @score)";
       // MySqlCommand cmd = new MySqlCommand(query, connection);
       //cmd.Parameters.AddWithValue("@playerName", playerName);
       //cmd.Parameters.AddWithValue("@score", score);
       //cmd.ExecuteNonQuery();

       // connection.Close();

    


}
