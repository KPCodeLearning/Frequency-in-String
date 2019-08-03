using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

public static void StringFrequency()
        {
            try
            {
                string str = "aaabbc";
                int[] counter = new int[256];
                for (int i = 0; i < str.Length; i++)
                    counter[str[i]]++;

                char[] arr = new char[str.Length];
                for (int i = 0; i < str.Length; i++)
                    arr[i] = str[i];

                for (int j = 0; j < 256; j++)
                    if (counter[j] != 0)
                        Console.WriteLine(Convert.ToChar(j) + " : " + counter[j]);
            }
            catch (Exception ex)
            {
                var d = ex.Message;
            }
        }