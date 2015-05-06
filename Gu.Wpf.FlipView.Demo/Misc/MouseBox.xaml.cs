﻿namespace Gu.Wpf.FlipView.Demo.Misc
{
    using System.Windows.Input;

    using Gu.Wpf.FlipView.Demo.MocksAndHelpers;
    using Gu.Wpf.FlipView.Gestures;

    /// <summary>
    /// Interaction logic for MouseBox.xaml
    /// </summary>
    public partial class MouseBox : EventBox
    {
        private bool _gestureStarted;

        private MouseGestureTracker _tracker;

        public MouseBox()
        {
            InitializeComponent();
            this._tracker = new MouseGestureTracker { InputElement = this.InputElement };
            this._tracker.Gestured += (_, g) => this.Args.Add(new ArgsVm(g));
        }

        protected override void OnStarted(object sender, InputEventArgs e)
        {
            this._gestureStarted = true;
            base.OnStarted(sender, e);
        }

        protected override void OnInput(object sender, InputEventArgs e)
        {
            if (this._gestureStarted)
            {
                base.OnInput(sender, e);
            }
        }

        protected override void OnEnded(object sender, InputEventArgs e)
        {
            this._gestureStarted = false;
            base.OnEnded(sender, e);
        }
    }
}