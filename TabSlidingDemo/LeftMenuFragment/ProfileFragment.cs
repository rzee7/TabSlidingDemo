using Android.Content;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;

namespace TabSlidingDemo
{
    public class ProfileFragment : Fragment
    {
        #region Private Fields

        TextView textView;

        #endregion

        #region Constructor

        public ProfileFragment()
        {
            this.RetainInstance = true;
        }

        #endregion

        #region OnViewCreated Method

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
            var ignore = base.OnCreateView(inflater, container, savedInstanceState);
            var view = inflater.Inflate(Resource.Layout.profile_fragment, null);

            textView = view.FindViewById<TextView>(Resource.Id.textView);
            var btnClick = view.FindViewById<Button>(Resource.Id.btnClick);

            btnClick.Click += BtnClick_Click;

            return view;
        }

        #endregion

        #region Button Click

        private void BtnClick_Click(object sender, System.EventArgs e)
        {
            textView.Text = $"Youuu! {textView.Text} Hit Me!! :D";
        }

        #endregion
    }
}