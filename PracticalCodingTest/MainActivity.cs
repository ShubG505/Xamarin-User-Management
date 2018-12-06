using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;
using System.Collections.Generic;
using PracticalCodingTest.Model;

namespace PracticalCodingTest
{

   
    [Activity(Label = "User Management", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        public static List<User> Users = new List<User>();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
             // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            FindViewById<Button>(Resource.Id.itemsButton).Click += OnItemsClick;
            FindViewById<Button>(Resource.Id.addItemButton).Click += OnAddItemClick;
            FindViewById<Button>(Resource.Id.ValidateButton).Click += OnValidateButtonClick;
        }

        void OnItemsClick(object sender, EventArgs e)
        {
            //
            // Use the standard technique to start an Activity: create an Intent and then pass it to StartActivity.
            //
            var intent = new Intent(this, typeof(Items));

            StartActivity(intent);
        }

        void OnAddItemClick(object sender, EventArgs e)
        {
            // Use the convenience method to start an Activity without creating an Intent.

            StartActivity(typeof(AddItem));

        }

        void OnValidateButtonClick(object sender, EventArgs e)
        {
            //
            // Use the convenience method to start an Activity without creating an Intent.
            //
            StartActivity(typeof(ValidateUser));
        }
      
    }
}

