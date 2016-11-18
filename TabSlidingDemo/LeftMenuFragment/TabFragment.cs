using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Views;
using Java.Lang;

namespace TabSlidingDemo
{
    public class TabFragment : BaseFragment
    {
        #region Private Fields

        string[] dynamicMenusTeacher = new string[] { "T Menu 1", "T Menu 2", "T Menu 3" };
        string[] dynamicMenusParents = new string[] { "P Menu 1", "P Menu 2" };
        bool userRoleTeacher = true;

        TabLayout tabLayout;
        ViewPager viewPager;

        #endregion

        #region OnCreatedView Method

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            HasOptionsMenu = true;
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.tab_layout, null);

            tabLayout = view.FindViewById<TabLayout>(Resource.Id.sliding_tabs);
            viewPager = view.FindViewById<ViewPager>(Resource.Id.viewpager);

            //Setting Page Adaptor To View Pager
            viewPager.Adapter = new FragmentTabsAdaptor(this.FragmentManager);
            tabLayout.Post(new Runnable(() => { tabLayout.SetupWithViewPager(viewPager); }));

            return view;
        }

        #endregion

        #region On Create Menu

        public override void OnCreateOptionsMenu(IMenu menu, MenuInflater inflater)
        {
            // inflater.Inflate(Resource.Menu.tab_menu, menu);
            var refress = menu.Add(Menu.None, -1, Menu.First, "refresh");
            refress.SetIcon(Resource.Drawable.ic_forum);
            refress.SetShowAsAction(ShowAsAction.Always);

            if (userRoleTeacher) //If user role is teacher
            {
                for (int i = 0; i < dynamicMenusTeacher.Length; i++)
                {
                    string item = dynamicMenusTeacher[i];
                    menu.Add(Menu.None, i, 2, item);
                }

            }
            else //User role is parent or others
            {
                for (int i = 0; i < dynamicMenusParents.Length; i++)
                {
                    string item = dynamicMenusParents[i];
                    menu.Add(Menu.None, i, 2, item);
                }
            }

            //Adding Refresh Menu
            

            base.OnCreateOptionsMenu(menu, inflater);
        }

        #endregion

        #region Preparing Dynamic Menu

        public override void OnPrepareOptionsMenu(IMenu menu)
        {

            base.OnPrepareOptionsMenu(menu);
        }

        #endregion

        #region Option Menu Selected

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
             base.OnOptionsItemSelected(item);
            string mName = userRoleTeacher ? "T" : "P";
            switch (item.ItemId)
            {
                case 0:
                    ShowToast(string.Format("You clicked on {0} Menu 1", mName));
                    break;
                case 1:
                    ShowToast(string.Format("You clicked on {0} Menu 2", mName));
                    break;
                case 2:
                    ShowToast(string.Format("You clicked on {0} Menu 3", mName));
                    break;
                case -1:
                    userRoleTeacher = userRoleTeacher ? false : true;
                    this.Activity.InvalidateOptionsMenu();
                    break;
                default:
                    break;
            }
            return false;
        }

        #endregion
    }
}