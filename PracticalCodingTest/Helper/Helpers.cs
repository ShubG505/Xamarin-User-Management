using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Text.RegularExpressions;

namespace PracticalCodingTest.Helper
{
    public static  class Helpers
    {

        public static string ValidatePassword(string password)
        {
            string strResult = "fail";
            try
            {
                bool result = false;
                
               result =  Regex.IsMatch(password,@"^(?!.*(?<g>[a-z\d]+)\k<g>.*)[a-z\d]{5,12}(?<=.*[a-z].*)(?<=.*\d.*)$");
               // result = true;

                if (result)
                    strResult = "success";
            }
            catch
            {
                strResult = "fail";
            }
            return strResult;
        }
    }
}