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
using Android.Graphics;
using PracticalCodingTest.Model;

namespace PracticalCodingTest
{
    [Activity(Label = "AddUser")]
    public class AddItem : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Layout :  
            SetContentView(Resource.Layout.layout_additem);
            // Click 
            FindViewById<Button>(Resource.Id.saveButton).Click += OnSaveClick;
            FindViewById<Button>(Resource.Id.cancelButton).Click += OnCancelClick;
        }

        void OnSaveClick(object sender, EventArgs e)
        {

            //  Save event 
            string name = FindViewById<EditText>(Resource.Id.nameInput).Text;
            string username = FindViewById<EditText>(Resource.Id.usernameInput).Text;
            string password = FindViewById<EditText>(Resource.Id.PasswordInput).Text;
            string confirmPassword = FindViewById<EditText>(Resource.Id.confirmpasswordInput).Text;
            TextView txtvalidate = FindViewById<TextView>(Resource.Id.Validatetext);
            var valid = Helper.Helpers.ValidatePassword(password);
            if(String.IsNullOrEmpty(name))
            {
                txtvalidate.Text = "Name can't blank";
                txtvalidate.SetTextColor(Color.Red);
                return;
            }
            if (String.IsNullOrEmpty(username))
            {
                txtvalidate.Text = "Username can't blank";
                txtvalidate.SetTextColor(Color.Red);
                return;
            }
            if (String.IsNullOrEmpty(password))
            {
                txtvalidate.Text = "Password can't blank";
                txtvalidate.SetTextColor(Color.Red);
                return;
            }
            if (valid.Contains("fail"))
            {
                //Validate 
                txtvalidate.Text = "Password must use a combination " +
      "I.Password must be mixture of letters and numerical digits only, with at least one of each." +
      "<br />II.Password  must be between 5 and 12 characters in length.<br />III." +
      "Password must not contain any sequence of characters immediately followed by the same sequence";
                txtvalidate.SetTextColor(Color.Red);
                return;
            }
            if(password != confirmPassword)
            {
                // Confirm Password 
                txtvalidate.Text = "Password and Confirm Password not match ..";
                txtvalidate.SetTextColor(Color.Red);
                return;
            }
           else
            {
                // Add User 
                User user = new User();
                user.Name = name;
                user.UserName = username;
                user.Password = password;
                DbService db = new DbService();
                db.AddUser(user);
                 txtvalidate.Text = "User Added ...";
                txtvalidate.SetTextColor(Color.Green);
            }



        }


        void OnCancelClick(object sender, EventArgs e)
        {
            Finish();
        }
    }
}