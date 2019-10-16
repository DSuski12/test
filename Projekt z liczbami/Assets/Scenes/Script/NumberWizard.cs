using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Witaj u Liczbowego Czarodzeija");
        print("Pomysl jakas liczbe w swojej glowie ale jej nie mow");
        int min = 1;
        int max = 500;
        print("Najwieksza liczba jaka mozesz wybrac jest"+max);
        print("Najmniensza licazba jaka mozesz wybrac to" +min);
        print("Czy twoja liczba jest wiekasza czy mniejsza od 500?");
        print("Aby odpowiedziec na pyanie nacisnij: Gorna strzalka = wyzsza liczba, Dolna liczba = nizsza liczba");
        if (Input.GetKeyDown(KeyCode.UpArrow)) ;
        print("Gorna strzalka zostala nacisnieta");
        if (Input.GetKeyUp(KeyCode.DownArrow)) ;
        print("Dolna strzalak zostala nacisnieta");
        if (Input.GetKeyDown(KeyCode.Return)) ;
            //CTRL + ALT + M , CTRL + H 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
