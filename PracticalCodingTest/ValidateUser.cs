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

namespace PracticalCodingTest
{
    [Activity(Label = "ValidateUser")]

   public class ValidateUser : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Layout 
            SetContentView(Resource.Layout.layout_validateuser);
            FindViewById<Button>(Resource.Id.saveButton).Click += OnSaveClick;
            FindViewById<Button>(Resource.Id.cancelButton).Click += OnCancelClick;
        }

        void OnSaveClick(object sender, EventArgs e)
        {
            //Save 
            string username = FindViewById<EditText>(Resource.Id.usernameInput).Text;
            string password = FindViewById<EditText>(Resource.Id.PasswordInput).Text;
            TextView txtvalidate = FindViewById<TextView>(Resource.Id.Validatetext);
            // Data service 
            DbService db = new DbService();
            var lst = db.getUsers();
            var user = lst.Where(c => c.UserName == username && c.Password == password).FirstOrDefault();

            if (user == null)
            {
                txtvalidate.Text = "User is not validate ";
                txtvalidate.SetTextColor(Color.Red);
                return;
            }
            else
            {
                txtvalidate.Text = "User Validate  ...";
                txtvalidate.SetTextColor(Color.Green);
            }



        }


        void OnCancelClick(object sender, EventArgs e)
        {
            // Kill App 
            Finish();
        }
    }
}