using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

    private static GameObject whoWinsTextShadow, player1MoveText; //player2MoveText

    private static GameObject player1; // player2;

    public static int diceSideThrown = 0;
    public static int player1StartWaypoint = 0;
    //public static int player2StartWaypoint = 0;
    public static int noPlayers;

    public static bool gameOver = false;

    // Use this for initialization
    void Start () {

        whoWinsTextShadow = GameObject.Find("WhoWinsText");
        player1MoveText = GameObject.Find("Player1MoveText");
      //  player2MoveText = GameObject.Find("Player2MoveText");

        player1 = GameObject.Find("Player1");
       // player2 = GameObject.Find("Player2");

        player1.GetComponent<FollowThePath>().moveAllowed = false;
       // player2.GetComponent<FollowThePath>().moveAllowed = false;

        whoWinsTextShadow.gameObject.SetActive(false);
        player1MoveText.gameObject.SetActive(true);
       // player2MoveText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (player1.GetComponent<FollowThePath>().waypointIndex > 
            player1StartWaypoint + diceSideThrown)

        {
        
            if(player1StartWaypoint+diceSideThrown == 6)
            {
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[35].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 35;
                player1.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(1);
            }
           if (player1StartWaypoint+diceSideThrown == 19)
            {
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[42].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 42;
                player1.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(1);
            }
           if (player1StartWaypoint + diceSideThrown == 23)
            {
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[56].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 56;
                player1.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(1);
            }

           if (player1StartWaypoint + diceSideThrown == 48)
            {
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[91].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 91;
                player1.GetComponent<FollowThePath>().waypointIndex  += 1;
                MovePlayer(1);
            }
           if (player1StartWaypoint + diceSideThrown == 52)
            {
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[74].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 74;
                player1.GetComponent<FollowThePath>().waypointIndex  += 1;
                MovePlayer(1);
            }
           if (player1StartWaypoint + diceSideThrown == 59)
            {
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[80].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 80;
                player1.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(1);
            }

            /* snake */
            if (player1StartWaypoint + diceSideThrown == 26)
            {
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[5].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 5;
                player1.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(1);
            }
            if (player1StartWaypoint + diceSideThrown == 36)
            {
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[15].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 15;
                player1.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(1);
            }

            if (player1StartWaypoint + diceSideThrown == 41)
            {
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[16].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 16;
                player1.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(1);
            }
            if (player1StartWaypoint + diceSideThrown == 45)
            {
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[24].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 24;
                player1.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(1);
            }
            if (player1StartWaypoint + diceSideThrown == 69)
            {
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[32].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 32;
                player1.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(1);
            }
            if (player1StartWaypoint + diceSideThrown == 78)
            {
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[40].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 40;
                player1.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(1);
            }
            if (player1StartWaypoint + diceSideThrown == 94)
            {
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[64].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 64;
                player1.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(1);
            }
            if (player1StartWaypoint + diceSideThrown == 97)
            {
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[80].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 54;
                player1.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(1);
            }





            player1.GetComponent<FollowThePath>().moveAllowed = false;
            player1MoveText.gameObject.SetActive(false);
         //   player2MoveText.gameObject.SetActive(true);
            player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex - 1;
        }

      /*  if (player2.GetComponent<FollowThePath>().waypointIndex >
            player2StartWaypoint + diceSideThrown)
        {

            if (player2StartWaypoint + diceSideThrown == 6)
            {
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[35].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 35;
                player2.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(2);
            }
            if (player2StartWaypoint + diceSideThrown == 19)
            {
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[42].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 42;
                player2.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(2);
            }
            if (player2StartWaypoint + diceSideThrown == 23)
            {
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[56].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 56;
                player1.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(1);
            }

            if (player2StartWaypoint + diceSideThrown == 48)
            {
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[91].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 91;
                player2.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(2);
            }
            if (player2StartWaypoint + diceSideThrown == 52)
            {
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[74].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 74;
                player2.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(2);
            }
            if (player2StartWaypoint + diceSideThrown == 59)
            {
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[80].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 80;
                player2.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(2);
            }    */
            //snake
           /* if (player2StartWaypoint + diceSideThrown == 26)
            {
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[5].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 5;
                player2.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(2);
            }
            if (player2StartWaypoint + diceSideThrown == 36)
            {
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[15].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 15;
                player2.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(2);
            }
            if (player2StartWaypoint + diceSideThrown == 41)
            {
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[16].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 16;
                player2.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(2);
            }
            if (player2StartWaypoint + diceSideThrown == 45)
            {
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[24].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 24;
                player2.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(2);
            }
            if (player2StartWaypoint + diceSideThrown == 69)
            {
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[32].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 32;
                player2.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(2);
            }
            if (player2StartWaypoint + diceSideThrown == 78)
            {
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[40].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 40;
                player2.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(2);
            }
            if (player2StartWaypoint + diceSideThrown == 94)
            {
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[64].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 64;
                player2.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(2);
            }
            if (player2StartWaypoint + diceSideThrown == 97)
            {
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[54].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 54;
                player2.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(2);
            }




            player2.GetComponent<FollowThePath>().moveAllowed = false;
            player2MoveText.gameObject.SetActive(false);
            player1MoveText.gameObject.SetActive(true);
            player2StartWaypoint = player2.GetComponent<FollowThePath>().waypointIndex - 1;
        }  */

        if (player1.GetComponent<FollowThePath>().waypointIndex == 
            player1.GetComponent<FollowThePath>().waypoints.Length)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            whoWinsTextShadow.GetComponent<Text>().text = "Player 1 Wins";
            gameOver = true;
        }

      /*  if (player2.GetComponent<FollowThePath>().waypointIndex ==
            player2.GetComponent<FollowThePath>().waypoints.Length)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(false);
            whoWinsTextShadow.GetComponent<Text>().text = "Player 2 Wins";
            gameOver = true;
        }
        //player1 Portal
        */

  
    }

    public static void MovePlayer(int playerToMove)
    {
        switch (playerToMove) { 
            case 1:
                player1.GetComponent<FollowThePath>().moveAllowed = true;
                break;

            /*case 2:
                player2.GetComponent<FollowThePath>().moveAllowed = true;
                break; */
        }
    }
}
