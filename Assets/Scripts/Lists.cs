using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public Player(string Name, int Health = 100)
    {
        this.Name = Name;
        this.Health = Health;
    }
    public int Health { get; set; }
    public string Name { get; set; }

}
public class Lists : MonoBehaviour
{
    //Declare a list of type Player
    List<Player> players;

    // Start is called before the first frame update
    void Start()
    {
        //Initialise the list
        players = new List<Player>();
        //Add players
        players.Add(new Player("One"));
        players.Add(new Player("Two", 50));
        players.ForEach(x =>
        {
            if (x.Health < 0)
            {
                Debug.Log(x.Name + " died");
                players.Remove(x);
            }
            else
            {
                x.Health--;
            }
        });

        Dictionary<int, Player> dict = new Dictionary<int, Player>();
        dict.Add(0, players[0]);
        dict.Add(1, players[1]);
        Debug.Log(dict);
    }
    

    
}
