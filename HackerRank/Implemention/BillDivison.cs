using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    static void bonAppetit(List<int> bill, int k, int b) {
        int cout = 0;
        int last_charges;
        
        foreach(int paid in bill)
        {
            cout += paid;
        }
        
        last_charges = Convert.ToInt32((cout - bill[k]) / 2);
        
        if (b == last_charges)
        {
            Console.Write("Bon Appetit");
        }
        
        else
        {
            Console.Write((b - last_charges).ToString());    
        }
        
    }

    static void Main(string[] args) {
        string[] nk = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

        int b = Convert.ToInt32(Console.ReadLine().Trim());

        bonAppetit(bill, k, b);
    }
}
