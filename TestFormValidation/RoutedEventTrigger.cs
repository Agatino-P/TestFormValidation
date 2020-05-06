using System;
using System.Windows;
using System.Windows.Interactivity;

namespace TestFormValidation
{

    public class RoutedEventTrigger : EventTriggerBase<DependencyObject>
    {
        private RoutedEvent _routedEvent;

        public RoutedEvent RoutedEvent
        {
            get => _routedEvent;
            set => _routedEvent = value;
        }

        public RoutedEventTrigger() { }
        protected override void OnAttached()
        {
            Behavior behavior = base.AssociatedObject as Behavior;
            FrameworkElement associatedElement = base.AssociatedObject as FrameworkElement; if (behavior != null)
            {
                associatedElement = ((IAttachedObject)behavior).AssociatedObject as FrameworkElement;
            }
            if (associatedElement == null)
            {
                throw new ArgumentException("Routed Event trigger can only be associated to framework elements");
            }
            if (RoutedEvent != null)
            {
                associatedElement.AddHandler(RoutedEvent, new RoutedEventHandler(this.OnRoutedEvent));
            }
        }

        private void OnRoutedEvent(object sender, RoutedEventArgs args)
        {
            base.OnEvent(args);
        }

        protected override string GetEventName()
        {
            return RoutedEvent.Name;
        }
    }
}
