using pract5;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;


int[] x = new int[6] { 0, 0, 0, 0, 0, 0 };
string[] z = new string[6] { "", "", "", "", "", "" };
while (true)
{

    Class2.main(x, z);
    int max = 7;
    int pos = Class1.meny(max, x, z);
    Class1.spis(max, pos, x, z);
}

