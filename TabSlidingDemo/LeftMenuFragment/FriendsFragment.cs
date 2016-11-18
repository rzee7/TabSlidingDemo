using System;
using Android.OS;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;

namespace TabSlidingDemo
{
    public class FriendsFragment : Fragment
    {
        #region Private Fields

        EditText editFriend;

        #endregion
        #region Constructor

        public FriendsFragment()
        {
            this.RetainInstance = true;
        }

        #endregion

        #region OnViewCreated Method

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignore = base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.friend_fragment, null);

            editFriend = view.FindViewById<EditText>(Resource.Id.editFriend);
            var btnClick = view.FindViewById<Button>(Resource.Id.btnClick);

            btnClick.Click += BtnClick_Click;

            return view;
        }

        #endregion

        #region Button Click

        private void BtnClick_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this.Activity, $"Say Hi!! to {editFriend.Text} from my side!!", ToastLength.Short).Show();
        }

        #endregion


    }
}