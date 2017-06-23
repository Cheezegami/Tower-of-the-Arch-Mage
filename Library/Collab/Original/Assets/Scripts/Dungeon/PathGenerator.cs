using UnityEngine;
using System.Collections;

public class PathGenerator : MonoBehaviour
{
    public int mapRows = 8;
    public int mapColumns = 12;

    public char[,] map;


    // Use this for initialization
    void Awake()
    {
        InitializeMap();
        DisplayMap();
    }

    // Update is called once per frame
    void Update()
    {

    }
    // De map naar de console loggen.
    public void DisplayMap()
    {
        string output = "";
        for (int r = 0; r < mapRows; r++)
        {
            for (int c = 0; c < mapColumns; c++)
            {
                output += map[r, c];
            }
            output += "\n";
        }
        Debug.Log(output);
    }

    // De basis van de map initialiseren, zoals de X's plaatsen rondom de map en de andere plekken van de map vrijmaken d.m.v. een O.
    public void InitializeMap()
    {
        map = new char[mapRows, mapColumns];

        // Put 'X's in top and bottom rows.
        for (int c = 0; c < mapColumns; c++)
        {
            map[0, c] = 'X';
            map[mapRows - 1, c] = 'X';
        }

        // Put 'X's in the left and right columns.
        for (int r = 0; r < mapRows; r++)
        {
            map[r, 0] = 'X';
            map[r, mapColumns - 1] = 'X';
        }

        // Set 'O' for the other map spaces (which means 'free').
        for (int r = 1; r < mapRows - 1; r++)
        {
            for (int c = 1; c < mapColumns - 1; c++)
            {
                map[r, c] = 'O';
            }
        }
        int mapSeed = System.DateTime.Now.Millisecond;
        Random.InitState(mapSeed);
        Debug.Log("Current seed = " + mapSeed);
    }

    void GenerateRooms()
    {

    }

}