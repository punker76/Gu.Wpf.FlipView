namespace Gu.Wpf.FlipView.Demo.ControlDemos
{
    using System.Windows.Controls;
    using Gu.Wpf.FlipView.Gestures;

    public partial class CompositeGesturePanelView : UserControl
    {
        public CompositeGesturePanelView()
        {
            this.InitializeComponent();
        }

        private void GesturePanel_OnGestured(object sender, GesturedEventArgs e)
        {
            this.Gestures.Items.Add(e);
        }
    }
}
