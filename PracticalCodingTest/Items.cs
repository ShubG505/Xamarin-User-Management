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

namespace PracticalCodingTest
{

    [Activity(Label = "Users")]
    public class Items : Activity
    {
        ListView myList;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Layout_items);

            myList = FindViewById<ListView>(Resource.Id.listView);
            DbService db = new DbService();
            var lst = db.getUsers();
            myList.Adapter = new MyCustomListAdapter(lst);
        }

        private void Lv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            int position = e.Position;
            // Leave It blank 
        }
    }
}