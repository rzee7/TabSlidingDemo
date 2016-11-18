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
using Android.Support.V4.App;
using Java.Lang;

namespace TabSlidingDemo
{
    public class FragmentTabsAdaptor : FragmentPagerAdapter
    {
        #region Private Fields

        string[] pagesTitles = new string[] { "Home", "Notification", "Curriculam", "Calendar" };

        #endregion

        #region Constructor

        public FragmentTabsAdaptor(Android.Support.V4.App.FragmentManager fManager) : base(fManager)
        {

        }

        #endregion

        #region Init tabs view

        /// <summary>
        /// It will generate tabs based on array length e.g. 4 then 4 tab will be there
        /// </summary>
        public override int Count
        {
            get
            {
                return pagesTitles.Length;
            }
        }

        #endregion

        #region Setting Fragment to tabs

        public override Android.Support.V4.App.Fragment GetItem(int position)
        {
            switch (position)
            {
                case 0:
                    return new HomeFragment();
                case 1:
                    return new NotificationFragment();
                case 2:
                    return new CurriculamFragment();
                case 3:
                    return new CalenderFragment();
                /*You can add more Fragments here*/
                default:
                    return new HomeFragment();
            }
        }

        #endregion

        #region Set Pages Tilte

        public override ICharSequence GetPageTitleFormatted(int position)
        {
            return new Java.Lang.String(pagesTitles[position]);
        }

        #endregion
    }
}