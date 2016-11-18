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

namespace TabSlidingDemo
{
    public class NotificationFragment : BaseFragment
    {
        #region Constructor

        public NotificationFragment()
        {
            this.RetainInstance = true;
        }

        #endregion

        #region OnCreatView

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
            // Use this to return your custom view for this Fragment
            var view = inflater.Inflate(Resource.Layout.NotificationFragmentLayout, container, false);
            //Init Your Controls Here


            return view;
        }

        #endregion
    }
}