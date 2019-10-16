using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int min = 1;
    int max = 500;
    int guess = 500;
    // Start is called before the first frame update
    void Start()
    {
        print("Witaj u Liczbowego Czarodzeija");
        print("Pomysl jakas liczbe w swojej glowie ale jej nie mow");
        print("Najwieksza liczba jaka mozesz wybrac jest"+max);
        print("Najmniensza licazba jaka mozesz wybrac to" +min);
        print("Aby odpowiedziec na pyanie nacisnij: Gorna strzalka = wyzsza liczba, Dolna liczba = nizsza liczba");

            //CTRL + ALT + M , CTRL + H = nakladka unity (wyszukiwarka) 
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (min + max) / 2;
            print("Czy twoja liczba jest wiekasza lub mniejsza niz " + guess);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            max = guess;
            guess = (min + max) / 2;
            print("Czy twoja liczba jest wiekasza lub mniejsza niz " + guess);
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            print("haha zgadlem");
        }
    }
}
