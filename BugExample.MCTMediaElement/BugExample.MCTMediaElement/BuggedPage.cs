using CommunityToolkit.Maui.Views;
using Microsoft.Maui.Layouts;

namespace BugExample.MCTMediaElement
{
    public class BuggedPage : ContentPage
    {
        AbsoluteLayout _view;

        public BuggedPage()
        {
            Content = _view = new AbsoluteLayout
            {
            };

            Loaded += (s, e) =>
            {
                MediaElement ele = new MediaElement
                {
                    Source = MediaSource.FromUri("https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4"),
                    ShouldShowPlaybackControls = true,
                };

                AbsoluteLayout.SetLayoutFlags(ele, AbsoluteLayoutFlags.PositionProportional);
                AbsoluteLayout.SetLayoutBounds(ele, new Rect(0.5, 0.5, 300, 300));

                _view.Add(ele);
            };
        }
    }
}

