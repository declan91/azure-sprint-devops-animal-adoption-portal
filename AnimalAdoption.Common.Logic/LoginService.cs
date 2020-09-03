using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalAdoption.Common.Logic
{
    public class LoginService
    {
        public string[] GetLoginIds()
        {
            return new string[]
            {
                "ferret",
                "pencil",
                "flower",
                "icecream",
                "basketball",
                "orange",
                "placeholder"
            };
        }

        public string GetLoginUserFromId(string id)
        {
            //switch name to convert from object to name
            string name = "";
            switch (id)
            {
                case "ferret":
                    name = "Merret";
                    break;
                case "pencil":
                    name = "Charlie";
                    break;
                case "flower":
                    name = "Jackie";
                    break;
                case "icecream":
                    name = "Alex";
                    break;
                case "basketball":
                    name = "Logan";
                    break;
                case "orange":
                    name = "Murphy";
                    break;
                case "placeholder":
                    name = "Merret";
                    break;
                default:
                    name = "Merret";
                    break;
            }
            return name;
        }
    }
}
