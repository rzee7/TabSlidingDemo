using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Fragment = Android.Support.V4.App.Fragment;

namespace TabSlidingDemo
{
    public class BaseFragment : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        #region Show Toast

        public void ShowToast(string msg)
        {
            Toast.MakeText(this.Activity, msg, ToastLength.Short).Show();
        }

        #endregion
    }
}