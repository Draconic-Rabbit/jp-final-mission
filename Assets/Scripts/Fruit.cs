using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Fruit : Food
{
    protected override string GetDisplayedText()
    {
        return "I am a fruit. My name is " + SpecificName + ". And i'm better than vegetable. And i'm " + ColorName + ".";
    }
}
