using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : Singleton<Info>
{

    public InternetType type;
    public enum InternetType { Client, Server, Host };
}
