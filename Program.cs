﻿using System;
using System.Xml;

namespace ReadXMLfromURL
{
    /// <summary>
    /// Summary description for Class1.
    /// </summary>
    class Class1
    {
        static void Main(string[] args)
        {
            String URLString = "http://opendata.dublincity.ie/TrafficOpenData/CP_TR/CPDATA.xml";
            XmlTextReader reader = new XmlTextReader(URLString);

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.

                        while (reader.MoveToNextAttribute()) // Read the attributes.
                            Console.Write(reader.Value + "  ");

                        break;
                    case XmlNodeType.Text: //Display the text in each element.
                        Console.WriteLine(reader.Value);
                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.
                        Console.WriteLine("");
                        break;
                }
            }
        }
    }
}