using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DnD : MonoBehaviour
{
    public int Level = 1;
   
    private int Health = 1;
    
    public int Con = 0

    public int numDice = 1;

    public int dieType = 6;

    public bool toughFeat = false

    public bool isHillDwarf;

    bool rollHealth;

    int fixedValue = 1;

    public string className;


    Dictionary<string, int> Classes;  //string = class name - - int = hit die rolled


    // Start is called before the first frame update
    void Start()
    {
        
    }
    Private int HealthPerLevel(string userClass)
    {
        int leveledHealth;
        int hitDie;
        int dieAverage;

        dieAverage = AverageDie();

        if (Classes.TryGetValue(userClass, out result))
        {
            hitDie = result;
        }
        if (rollHealth)
        { 
            for (int i; i < Level; i++)
            {
                leveledHealth += Random.Range(0,hitDie)
            }
        }
        return leveledHealth;
`   }

    private int ConMod()
    {
        int mod;
        int con;
        if (con > 10 && con <= 30)
        {
            con = con 10;
            mod = con / 2;
            mod = mod * Level;
            return mod;
        }
        else if (con <= 10)
        {
            mod = 0;
            mod = mod * Level;
            return mod;
        } 
        else if (con > 30)
        {
            mod = 10;
            mod = mod * Level;
            return mod;
        }

    }

    private int toughMod()
    {
        int addedHealth;
        toughFeat = isTough;
        if isTough
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
