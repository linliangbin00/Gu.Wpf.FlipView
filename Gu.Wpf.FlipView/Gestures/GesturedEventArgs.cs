namespace Gu.Wpf.FlipView.Gestures
{
    using System.Windows;

    public class GesturedEventArgs : RoutedEventArgs
    {
        public GesturedEventArgs(GestureType gesture, GestureEventArgs gestureEventArgs)
            : base(GesturePanel.GesturedEvent)
        {
            Gesture = gesture;
            GestureEventArgs = gestureEventArgs;
        }

        public GestureType Gesture { get; private set; }
        public GestureEventArgs GestureEventArgs { get; private set; }
    }


}