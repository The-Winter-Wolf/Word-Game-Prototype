using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter : MonoBehaviour
{
    [Header("Set Dynamically")]
    public TextMesh         tMesh;          // Отображает символ
    public Renderer         tRend;          // Определяет видимость символа
    public bool             big = false;    // Большие и малые плитки действуют по разному

    private char            _c;             // Символ, отображаемый на плитке
    private Renderer        rend;

    void Awake() 
    {
        tMesh = GetComponentInChildren<TextMesh>();
        tRend = tMesh.GetComponent<Renderer>();
        rend = GetComponent<Renderer>();
        visible = false;
    }

    // Свойство для чтения/записи буквы в поле _с, отображаемой объектом 3D Text
    public char c
    {
        get { return(_c);}
        set {
            _c = value;
            tMesh.text = _c.ToString();
        }
    }

    // Свойство для чтения/записи буквы в поле _с в виде строки
    public string str
    {
        get { return(_c.ToString()); }
        set { c = value[0]; }
    }

    // Разрешает или запрещает отображение 3D Text, что делает букву видимой или невидимой
    public bool visible
    {
        get { return(tRend.enabled); }
        set { tRend.enabled = value; }
    }

    // Свойство для чтения/записи цвета плитки
    public Color color 
    {
        get { return(rend.material.color); }
        set { rend.material.color = value; }
    }

    // Свойство для чтения/записи координат плитки
    public Vector3 pos
    {
        set{
            transform.position = value;
        }
    }
}
