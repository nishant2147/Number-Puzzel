using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Gamepuzel : MonoBehaviour
{
    public Button b1, b2, b3, b4, b5, b6, b7, b8, b9;
    public Text text;
    public int count;
    /*public static int scorevalue = 0;
    public Text score ;*/

    // Start is called before the first frame update
    void Start()
    {
        ArrayList list = new ArrayList();

        while (list.Count < 9)
        {
            int a = UnityEngine.Random.Range(1, 10);
            if (!list.Contains(a))
            {
                list.Add(a);
            }
        }

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].ToString() == "9")
            {
                list[i] = "";
            }
            print(i+"-->" + list[i]);
        }

        //score = GetComponent<Text>();   

        b1.GetComponentInChildren<Text>().text = list[0].ToString();
        b2.GetComponentInChildren<Text>().text = list[1].ToString();
        b3.GetComponentInChildren<Text>().text = list[2].ToString();
        b4.GetComponentInChildren<Text>().text = list[3].ToString();
        b5.GetComponentInChildren<Text>().text = list[4].ToString();
        b6.GetComponentInChildren<Text>().text = list[5].ToString();
        b7.GetComponentInChildren<Text>().text = list[6].ToString();
        b8.GetComponentInChildren<Text>().text = list[7].ToString();
        b9.GetComponentInChildren<Text>().text = list[8].ToString();


    }
    public void button9()
    {
        string d = b8.GetComponentInChildren<Text>().text;
        string d1 = b6.GetComponentInChildren<Text>().text;
        if (d == "")
        {
            b8.GetComponentInChildren<Text>().text = b9.GetComponentInChildren<Text>().text;
            b9.GetComponentInChildren<Text>().text = "";
            win();
        }
        else if (d1 == "")
        {
            b6.GetComponentInChildren<Text>().text = b9.GetComponentInChildren<Text>().text;
            b9.GetComponentInChildren<Text>().text = "";
            win();
        }
    }
    public void button8()
    {
        string s= b9.GetComponentInChildren<Text>().text;
        string s1 = b7.GetComponentInChildren<Text>().text;
        string s2 = b5.GetComponentInChildren<Text>().text;
        if (s == "")
        { 
            b9.GetComponentInChildren<Text>().text = b8.GetComponentInChildren<Text>().text;
            b8.GetComponentInChildren<Text>().text = "";
            win();
        }
        else if(s1 == "")
        {
            b7.GetComponentInChildren<Text>().text = b8.GetComponentInChildren<Text>().text;
            b8.GetComponentInChildren<Text>().text = "";
            win();
        }
        else if(s2 == "")
        {
            b5.GetComponentInChildren<Text>().text = b8.GetComponentInChildren<Text>().text;
            b8.GetComponentInChildren<Text>().text = "";
            win();
        }
        
    }
    public void button7()
    {
        string c= b8.GetComponentInChildren<Text>().text;
        string c1 = b4.GetComponentInChildren<Text>().text;
        if (c == "")
        {
            b8.GetComponentInChildren<Text>().text = b7.GetComponentInChildren<Text>().text;
            b7.GetComponentInChildren<Text>().text = "";
            win();
        }
        else if (c1 == "")
        {
            b4.GetComponentInChildren<Text>().text = b7.GetComponentInChildren<Text>().text;
            b7.GetComponentInChildren<Text>().text = "";
            win();
        }
        
    }
    public void button4()
    {
        string x = b7.GetComponentInChildren<Text>().text;
        string x1 = b5.GetComponentInChildren<Text>().text;
        string x2 = b1.GetComponentInChildren<Text>().text;
        if (x == "")
        {
            b7.GetComponentInChildren<Text>().text = b4.GetComponentInChildren<Text>().text;
            b4.GetComponentInChildren<Text>().text = "";
            win();
        }
        else if (x1 == "")
        {
            b5.GetComponentInChildren<Text>().text = b4.GetComponentInChildren<Text>().text;
            b4.GetComponentInChildren<Text>().text = "";
            win();
        }
        else if (x2 == "")
        {
            b1.GetComponentInChildren<Text>().text = b4.GetComponentInChildren<Text>().text;
            b4.GetComponentInChildren<Text>().text = "";
            win();
        }

    }
    public void button5()
    {
        string z = b4.GetComponentInChildren<Text>().text;
        string z1 = b6.GetComponentInChildren<Text>().text;
        string z2 = b8.GetComponentInChildren<Text>().text;
        string z3 = b2.GetComponentInChildren<Text>().text;
        if (z == "")
        {
            b4.GetComponentInChildren<Text>().text = b5.GetComponentInChildren<Text>().text;
            b5.GetComponentInChildren<Text>().text = "";
            win();
        }
        else if(z1 == "")
        {
            b6.GetComponentInChildren<Text>().text = b5.GetComponentInChildren<Text>().text;
            b5.GetComponentInChildren<Text>().text = "";
            win();
        }
        else if(z2 == "")
        {
            b8.GetComponentInChildren<Text>().text = b5.GetComponentInChildren<Text>().text;
            b5.GetComponentInChildren<Text>().text = "";
            win();
        }
        else if (z3 == "")
        {
            b2.GetComponentInChildren<Text>().text = b5.GetComponentInChildren<Text>().text;
            b5.GetComponentInChildren<Text>().text = "";
            win();
        }

    }
    public void button6()
    {
        string a = b5.GetComponentInChildren<Text>().text;
        string a1 = b9.GetComponentInChildren<Text>().text;
        string a2 = b3.GetComponentInChildren<Text>().text;
        if (a == "")
        {
            b5.GetComponentInChildren<Text>().text = b6.GetComponentInChildren<Text>().text;
            b6.GetComponentInChildren<Text>().text = "";
            win();
        }
        else if(a1 == "")
        {
            b9.GetComponentInChildren<Text>().text = b6.GetComponentInChildren<Text>().text;
            b6.GetComponentInChildren<Text>().text = "";
            win();
        }
        else if(a2 == "")
        {
            b3.GetComponentInChildren<Text>().text = b6.GetComponentInChildren<Text>().text;
            b6.GetComponentInChildren<Text>().text = "";
            win();
        }
        
    }
    public void button3()
    {
        string q = b6.GetComponentInChildren<Text>().text;
        string q1 = b2.GetComponentInChildren<Text>().text;
        if (q == "")
        {
            b6.GetComponentInChildren<Text>().text = b3.GetComponentInChildren<Text>().text;
            b3.GetComponentInChildren<Text>().text = "";
            win();
        }
        else if(q1 == "")
        {
            b2.GetComponentInChildren<Text>().text = b3.GetComponentInChildren<Text>().text;
            b3.GetComponentInChildren<Text>().text = "";
            win();
        }
        
    }
    public void button2()
    {
        string w = b3.GetComponentInChildren<Text>().text;
        string w1 = b1.GetComponentInChildren<Text>().text;
        string w2 = b5.GetComponentInChildren<Text>().text;
        if (w == "")
        {
            b3.GetComponentInChildren<Text>().text = b2.GetComponentInChildren<Text>().text;
            b2.GetComponentInChildren<Text>().text = "";
            win();
        }
        else if(w1 == "")
        {
            b1.GetComponentInChildren<Text>().text = b2.GetComponentInChildren<Text>().text;
            b2.GetComponentInChildren<Text>().text = "";
            win();
        }
        else if (w2 == "")
        {
            b5.GetComponentInChildren<Text>().text = b2.GetComponentInChildren<Text>().text;
            b2.GetComponentInChildren<Text>().text = "";
            win();
        }

    }
    public void button1()
    {
        string e = b2.GetComponentInChildren<Text>().text;
        string e1 = b4.GetComponentInChildren<Text>().text;
        if (e == "")
        {
            b2.GetComponentInChildren<Text>().text = b1.GetComponentInChildren<Text>().text;
            b1.GetComponentInChildren<Text>().text = "";
            win();
        }
        else if (e1 == "")
        {
            b4.GetComponentInChildren<Text>().text = b1.GetComponentInChildren<Text>().text;
            b1.GetComponentInChildren<Text>().text = "";
            win();
        }

    }

    public void win()
    {
        if (b1.GetComponentInChildren<Text>().text.Equals("1") && b2.GetComponentInChildren<Text>().text.Equals("2")
          && b3.GetComponentInChildren<Text>().text.Equals("3") && b4.GetComponentInChildren<Text>().text.Equals("4")
          && b5.GetComponentInChildren<Text>().text.Equals("5") && b6.GetComponentInChildren<Text>().text.Equals("6")
          && b7.GetComponentInChildren<Text>().text.Equals("7") && b8.GetComponentInChildren<Text>().text.Equals("8")
          && b9.GetComponentInChildren<Text>().text.Equals(""))
        {
            text.text = "congratulations You winner Game";
            Console.WriteLine("Winner");
        }
        else
        {
            count = count + 1;
            text.text = ""+count;
        }
        
    }
    /*public void click()
    {
        count = count + 1;
        text.text = "NO" + count;
    }*/

    // Update is called once per frame
    void Update()
    {
        //score.text = "score" + scorevalue++;
    }
}
