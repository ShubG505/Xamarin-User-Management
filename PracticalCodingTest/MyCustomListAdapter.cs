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
using PracticalCodingTest.Model;

namespace PracticalCodingTest
{
    public class MyCustomListAdapter : BaseAdapter<User>
    {
        List<User> users;

        public MyCustomListAdapter(List<User> users)
        {
            //Add User
            this.users = users;
        }

        public override User this[int position]
        {
            get
            {
                return users[position];
            }
        }

        public override int Count
        {
            get
            {
                return users.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }
        // Get Use GetView 
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;

            if (view == null)
            {
                view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.userRow, parent, false);

                  var name = view.FindViewById<TextView>(Resource.Id.nameTextView);
                var user = view.FindViewById<TextView>(Resource.Id.usernameTextView);

                view.Tag = new ViewHolder() { Name = name, Username = user };
            }

            var holder = (ViewHolder)view.Tag;

             holder.Name.Text = users[position].Name;
            holder.Username.Text = users[position].UserName;


            return view;

        }
    }

    public class ViewHolder : Java.Lang.Object
    {
         public TextView Name { get; set; }
        public TextView Username { get; set; }
    }
}